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
    public partial class GradeForm : Form {
        private void GradeForm_Load(object sender, EventArgs e) {

        }
        public GradeForm() {
            InitializeComponent();
            RefreshGradeList();
        }

        private void addGradeButton_Click(object sender, EventArgs e) {
            string gradeName = gradeNameTextBox.Text.Trim();
            if (string.IsNullOrEmpty(gradeName)) {
                MessageBox.Show("Please enter a grade name.");
                return;
            }
            
            string insertQuery = @"INSERT INTO Grade (grade_name) VALUES (:gradeName)";
            OracleParameter gradeNameParameter = new OracleParameter(":gradeName", OracleDbType.Varchar2, gradeName, ParameterDirection.Input);
            int rowsAffected = SchoolDatabase.ExecuteNonQuery(insertQuery, new OracleParameter[] { gradeNameParameter });

            if (rowsAffected > 0) {
                MessageBox.Show("Grade added successfully.");
                gradeNameTextBox.Clear(); 
                RefreshGradeList(); 
            }
            else {
                MessageBox.Show("An error occurred while adding the grade.");
            }
        }

        private void deleteGradeButton_Click(object sender, EventArgs e) {
            
            if (gradeDataGridView.SelectedRows.Count == 0) {
                MessageBox.Show("Please select a grade to delete.");
                return;
            }

            int gradeId = Convert.ToInt32(gradeDataGridView.SelectedRows[0].Cells["grade_id"].Value);

            
            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete grade with ID {gradeId}?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.No) {
                return;
            }

            
            string deleteQuery = "DELETE FROM Grade WHERE grade_id = :gradeId";
            OracleParameter gradeIdParameter = new OracleParameter(":gradeId", gradeId);
            int rowsAffected = SchoolDatabase.ExecuteNonQuery(deleteQuery, new OracleParameter[] { gradeIdParameter });

            if (rowsAffected > 0) {
                MessageBox.Show("Grade deleted successfully.");
                RefreshGradeList();
            }
            else {
                MessageBox.Show("An error occurred while deleting the grade.");
            }
        }

        private void RefreshGradeList() {
            DataTable gradeDataTable = SchoolDatabase.ExecuteQuery("SELECT * FROM Grade");
            gradeDataGridView.DataSource = gradeDataTable;
        }
    }
}
