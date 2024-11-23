using Oracle.ManagedDataAccess.Client;
using School_database_homework_try_2.Froms.StudentForms;
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
    public partial class StudentListForm : Form {
        public StudentListForm() {
            InitializeComponent();
        }

        private void StudentListForm_Load(object sender, EventArgs e) {
            DataTable studentsDataTable = SchoolDatabase.ExecuteQuery("select * from student");
            studentDataGridView.DataSource = studentsDataTable;
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e) {
            string searchTerm = searchTextBox.Text.Trim();
            string query = @"SELECT * FROM Student WHERE First_Name LIKE :searchTerm OR Last_Name LIKE :searchTerm";
            OracleParameter searchTermParameter = new OracleParameter(":searchTerm", OracleDbType.Varchar2);
            searchTermParameter.Value = "%" + searchTerm + "%"; 
            DataTable searchResults = SchoolDatabase.ExecuteQuery(query, new OracleParameter[] { searchTermParameter });
            studentDataGridView.DataSource = searchResults;
        }

        private void deleteButton_Click(object sender, EventArgs e) {
            if (studentDataGridView.SelectedRows.Count == 0) {
                MessageBox.Show("Please select a student to delete.");
                return; 
            }
            int studentId = Convert.ToInt32(studentDataGridView.SelectedRows[0].Cells["student_id"].Value);
            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete student with ID {studentId}?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (result == DialogResult.No) {
                return; 
            }
            try {
                OracleParameter studentIdParameter = new OracleParameter("student_id", studentId);
                int rowsAffected = SchoolDatabase.ExecuteNonQuery(
                    "DELETE FROM Student WHERE student_id = :student_id",
                    new OracleParameter[] { studentIdParameter });
                if (rowsAffected > 0) {
                    MessageBox.Show("Student deleted successfully.");
                    RefreshStudentList();
                }
                else {
                    MessageBox.Show("An error occurred while deleting the student.");
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void editButton_Click(object sender, EventArgs e) {
            if (studentDataGridView.SelectedRows.Count == 0) {
                MessageBox.Show("Please select a student to edit.");
                return; 
            }
            int selectedStudentId = Convert.ToInt32(studentDataGridView.SelectedRows[0].Cells["student_id"].Value); 
            EditStudentForm editStudentForm = new EditStudentForm(selectedStudentId); 
            DialogResult result = editStudentForm.ShowDialog();
            if (result == DialogResult.OK) {
                RefreshStudentList();
            }
        }

        private void addButton_Click(object sender, EventArgs e) {
            AddStudentForm addStudentForm = new AddStudentForm();
            DialogResult result = addStudentForm.ShowDialog();
            if (result == DialogResult.OK) {
                DataTable studentsDataTable = SchoolDatabase.ExecuteQuery("select * from student");
                studentDataGridView.DataSource = studentsDataTable;
            }
        }

        private void RefreshStudentList() {
            DataTable studentDataTable = SchoolDatabase.ExecuteQuery("SELECT * FROM Student");
            studentDataGridView.DataSource = studentDataTable;
        }

        private void enrollButton_Click(object sender, EventArgs e) {
            if (studentDataGridView.SelectedRows.Count == 0) {
                MessageBox.Show("Please select a student to enroll.");
                return; 
            }
            int selectedStudentId = Convert.ToInt32(studentDataGridView.SelectedRows[0].Cells["student_id"].Value);
            EnrollmentForm enrollmentForm = new EnrollmentForm(selectedStudentId);
            enrollmentForm.ShowDialog();
        }
        private void notesButton_Click(object sender, EventArgs e) {
            if (studentDataGridView.SelectedRows.Count == 0) {
                MessageBox.Show("Please select a student to view notes.");
                return;
            }
            int selectedStudentId = Convert.ToInt32(studentDataGridView.SelectedRows[0].Cells["student_id"].Value);
            string enrollmentQuery = "SELECT enrollment_id FROM Enrollment WHERE student_id = :studentId";
            OracleParameter studentIdParam = new OracleParameter("studentId", OracleDbType.Int32, selectedStudentId, ParameterDirection.Input);
            DataTable enrollmentData = SchoolDatabase.ExecuteQuery(enrollmentQuery, new OracleParameter[] { studentIdParam });

            if (enrollmentData.Rows.Count > 0) {
                

                
                
                
            }
            else {
                MessageBox.Show("No enrollment found for this student.");
            }
        }
    }
}