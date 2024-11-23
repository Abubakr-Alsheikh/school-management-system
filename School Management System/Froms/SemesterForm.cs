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
    public partial class SemesterForm : Form {
        public SemesterForm() {
            InitializeComponent();
            LoadSemesterData();
        }

        private void SemesterForm_Load(object sender, EventArgs e) {
        }

        private void LoadSemesterData() {
            
            DataTable semesterDataTable = SchoolDatabase.ExecuteQuery("SELECT * FROM Semester");

            
            semesterDataGridView.DataSource = semesterDataTable;
        }

        private void addButton_Click(object sender, EventArgs e) {
            
            string semesterName = semesterNameTextBox.Text.Trim();
            int schoolYear;
            if (!int.TryParse(schoolYearTextBox.Text.Trim(), out schoolYear)) {
                MessageBox.Show("Please enter a valid school year (number).");
                return;
            }

            
            if (string.IsNullOrEmpty(semesterName)) {
                MessageBox.Show("Please enter a semester name.");
                return;
            }

            
            string insertQuery = "INSERT INTO Semester (semester_name, school_year) VALUES (:semesterName, :schoolYear)";
            OracleParameter[] parameters = new OracleParameter[]
            {
                new OracleParameter("semesterName", OracleDbType.Varchar2, semesterName, ParameterDirection.Input),
                new OracleParameter("schoolYear", OracleDbType.Int32, schoolYear, ParameterDirection.Input)
            };

            int rowsAffected = SchoolDatabase.ExecuteNonQuery(insertQuery, parameters);

            if (rowsAffected > 0) {
                MessageBox.Show("Semester added successfully.");
                
                LoadSemesterData();
            }
            else {
                MessageBox.Show("An error occurred while adding the semester.");
            }
        }

        private void updateButton_Click(object sender, EventArgs e) {
            
            if (semesterDataGridView.SelectedRows.Count == 0) {
                MessageBox.Show("Please select a semester to update.");
                return;
            }

            int semesterId = Convert.ToInt32(semesterDataGridView.SelectedRows[0].Cells["semester_id"].Value);
            string semesterName = semesterNameTextBox.Text.Trim();
            int schoolYear;
            if (!int.TryParse(schoolYearTextBox.Text.Trim(), out schoolYear)) {
                MessageBox.Show("Please enter a valid school year (number).");
                return;
            }

            
            if (string.IsNullOrEmpty(semesterName)) {
                MessageBox.Show("Please enter a semester name.");
                return;
            }

            
            string updateQuery = "UPDATE Semester SET semester_name = :semesterName, school_year = :schoolYear WHERE semester_id = :semesterId";
            OracleParameter[] parameters = new OracleParameter[]
            {
                new OracleParameter("semesterName", OracleDbType.Varchar2, semesterName, ParameterDirection.Input),
                new OracleParameter("schoolYear", OracleDbType.Int32, schoolYear, ParameterDirection.Input),
                new OracleParameter("semesterId", OracleDbType.Int32, semesterId, ParameterDirection.Input)
            };

            int rowsAffected = SchoolDatabase.ExecuteNonQuery(updateQuery, parameters);

            if (rowsAffected > 0) {
                MessageBox.Show("Semester updated successfully.");
                LoadSemesterData();
            }
            else {
                MessageBox.Show("An error occurred while updating the semester.");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e) {
            
            if (semesterDataGridView.SelectedRows.Count == 0) {
                MessageBox.Show("Please select a semester to delete.");
                return;
            }

            int semesterId = Convert.ToInt32(semesterDataGridView.SelectedRows[0].Cells["semester_id"].Value);

            
            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete semester with ID {semesterId}?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes) {
                
                string deleteQuery = "DELETE FROM Semester WHERE semester_id = :semesterId";
                OracleParameter semesterIdParameter = new OracleParameter("semesterId", OracleDbType.Int32, semesterId, ParameterDirection.Input);
                int rowsAffected = SchoolDatabase.ExecuteNonQuery(deleteQuery, new OracleParameter[] { semesterIdParameter });

                if (rowsAffected > 0) {
                    MessageBox.Show("Semester deleted successfully.");
                    LoadSemesterData();
                }
                else {
                    MessageBox.Show("An error occurred while deleting the semester.");
                }
            }
        }

        private void semesterDataGridView_SelectionChanged(object sender, EventArgs e) {
            
            if (semesterDataGridView.SelectedRows.Count > 0) {
                DataRowView selectedRow = (DataRowView)semesterDataGridView.SelectedRows[0].DataBoundItem;
                semesterNameTextBox.Text = selectedRow["semester_name"].ToString();
                schoolYearTextBox.Text = selectedRow["school_year"].ToString();
            }
        }
    }
}
