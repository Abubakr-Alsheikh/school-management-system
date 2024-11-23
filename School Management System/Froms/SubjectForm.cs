using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_database_homework_try_2.Froms {
    public partial class SubjectForm : Form {
        public SubjectForm() {
            InitializeComponent();
        }

        private void SubjectListForm_Load(object sender, EventArgs e) {
            
            DataTable subjectDataTable = SchoolDatabase.ExecuteQuery("SELECT * FROM Subject");

            
            subjectDataGridView.DataSource = subjectDataTable;
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e) {
            
            string searchTerm = searchTextBox.Text.Trim();

            
            string query = @"SELECT * FROM Subject WHERE subject_name LIKE :searchTerm";

            
            OracleParameter searchTermParameter = new OracleParameter(":searchTerm", OracleDbType.Varchar2);
            searchTermParameter.Value = "%" + searchTerm + "%"; 

            
            DataTable searchResults = SchoolDatabase.ExecuteQuery(query, new OracleParameter[] { searchTermParameter });

            
            subjectDataGridView.DataSource = searchResults;
        }

        private void addSubjectButton_Click(object sender, EventArgs e) {
            
            string newSubjectName = subjectNameTextBox.Text.Trim();

            if (string.IsNullOrEmpty(newSubjectName)) {
                MessageBox.Show("Please enter a subject name.");
                return;
            }

            
            string insertQuery = @"INSERT INTO Subject (subject_name) VALUES (:subjectName)";

            OracleParameter subjectNameParameter = new OracleParameter(":subjectName", OracleDbType.Varchar2);
            subjectNameParameter.Value = newSubjectName;

            int rowsAffected = SchoolDatabase.ExecuteNonQuery(insertQuery, new OracleParameter[] { subjectNameParameter });

            if (rowsAffected > 0) {
                MessageBox.Show("Subject added successfully!");
                RefreshSubjectList(); 
                subjectNameTextBox.Clear(); 
            }
            else {
                MessageBox.Show("An error occurred while adding the subject.");
            }
        }

        private void editSubjectButton_Click(object sender, EventArgs e) {
            
            if (subjectDataGridView.SelectedRows.Count == 0) {
                MessageBox.Show("Please select a subject to edit.");
                return;
            }

            
            int subjectId = Convert.ToInt32(subjectDataGridView.SelectedRows[0].Cells["subject_id"].Value);

            
            string currentSubjectName = subjectDataGridView.SelectedRows[0].Cells["subject_name"].Value.ToString();

            
            string updateQuery = @"UPDATE Subject 
                                   SET subject_name = :subjectName 
                                 WHERE subject_id = :subjectId";

            OracleParameter subjectNameParameter = new OracleParameter(":subjectName", OracleDbType.Varchar2);
            subjectNameParameter.Value = subjectNameTextBox.Text.Trim(); 

            OracleParameter subjectIdParameter = new OracleParameter(":subjectId", OracleDbType.Int32);
            subjectIdParameter.Value = subjectId;

            int rowsAffected = SchoolDatabase.ExecuteNonQuery(updateQuery, new OracleParameter[] { subjectNameParameter, subjectIdParameter });

            if (rowsAffected > 0) {
                MessageBox.Show("Subject updated successfully!");
                RefreshSubjectList(); 
                subjectNameTextBox.Clear(); 
            }
            else {
                MessageBox.Show("An error occurred while updating the subject.");
            }
        }

        private void deleteSubjectButton_Click(object sender, EventArgs e) {
            
            if (subjectDataGridView.SelectedRows.Count == 0) {
                MessageBox.Show("Please select a subject to delete.");
                return;
            }
            int subjectId = Convert.ToInt32(subjectDataGridView.SelectedRows[0].Cells["subject_id"].Value);

            
            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete subject with ID {subjectId}?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.No) {
                return; 
            }

            
            try {
                
                OracleParameter subjectIdParameter = new OracleParameter("subject_id", subjectId);

                
                int rowsAffected = SchoolDatabase.ExecuteNonQuery(
                    "DELETE FROM Subject WHERE subject_id = :subject_id",
                    new OracleParameter[] { subjectIdParameter });

                if (rowsAffected > 0) {
                    MessageBox.Show("Subject deleted successfully.");
                    
                    RefreshSubjectList();
                }
                else {
                    MessageBox.Show("An error occurred while deleting the subject.");
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void RefreshSubjectList() {
            DataTable subjectDataTable = SchoolDatabase.ExecuteQuery("SELECT * FROM Subject");
            subjectDataGridView.DataSource = subjectDataTable;
        }

        private void subjectDataGridView_SelectionChanged(object sender, EventArgs e) {
            if (subjectDataGridView.SelectedRows.Count > 0) {
                
                string selectedSubjectName = subjectDataGridView.SelectedRows[0].Cells["subject_name"].Value.ToString();

                
                subjectNameTextBox.Text = selectedSubjectName;
            }
        }
    }
}