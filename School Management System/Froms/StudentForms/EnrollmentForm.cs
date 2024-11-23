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

namespace School_database_homework_try_2.Froms.StudentForms {
    public partial class EnrollmentForm : Form {
        private int studentId;
        private void EnrollmentForm_Load(object sender, EventArgs e) {

        }
        public EnrollmentForm(int studentId) {
            InitializeComponent();
            this.studentId = studentId;
            LoadAvailableClasses();
            LoadEnrolledClasses();
        }
        private void LoadAvailableClasses() {
            string query = @"SELECT 
                                  cs.session_id, 
                                  c.class_name, 
                                  s.subject_name, 
                                  g.grade_name,
                                  se.semester_id,
                                  se.semester_name
                              FROM ClassSession cs
                              JOIN Class c ON cs.class_id = c.class_id
                              JOIN Subject s ON cs.subject_id = s.subject_id
                              JOIN Grade g ON c.grade_id = g.grade_id
                              JOIN Semester se ON cs.semester_id = se.semester_id"; 

            DataTable availableClassesData = SchoolDatabase.ExecuteQuery(query);
            availableClassesDataGridView.DataSource = availableClassesData;
        }

        private void LoadEnrolledClasses() {
            string query = @"SELECT 
                                  cs.session_id, 
                                  c.class_name, 
                                  s.subject_name, 
                                  g.grade_name,
                                  se.semester_name
                              FROM Enrollment e
                              JOIN ClassSession cs ON e.session_id = cs.session_id
                              JOIN Class c ON cs.class_id = c.class_id
                              JOIN Subject s ON cs.subject_id = s.subject_id
                              JOIN Grade g ON c.grade_id = g.grade_id
                              JOIN Semester se ON cs.semester_id = se.semester_id
                              WHERE e.student_id = :studentId";

            OracleParameter studentIdParam = new OracleParameter("studentId", OracleDbType.Int32, studentId, ParameterDirection.Input);
            DataTable enrolledClassesData = SchoolDatabase.ExecuteQuery(query, new OracleParameter[] { studentIdParam });
            enrolledClassesDataGridView.DataSource = enrolledClassesData;
        }

        private void enrollButton_Click(object sender, EventArgs e) {
            if (availableClassesDataGridView.SelectedRows.Count == 0) {
                MessageBox.Show("Please select a class to enroll in.");
                return;
            }
            int selectedSessionId = Convert.ToInt32(availableClassesDataGridView.SelectedRows[0].Cells["session_id"].Value);
            int selectedSemesterId = Convert.ToInt32(availableClassesDataGridView.SelectedRows[0].Cells["semester_id"].Value);
            if (enrolledClassesDataGridView.Rows.Cast<DataGridViewRow>().Any(row => Convert.ToInt32(row.Cells["session_id"].Value) == selectedSessionId)) {
                MessageBox.Show("The student is already enrolled in this class.");
                return;
            }
            string insertQuery = "INSERT INTO Enrollment (student_id, session_id, semester_id) VALUES (:studentId, :sessionId, :semesterId)";
            OracleParameter[] parameters = new OracleParameter[]
            {
        new OracleParameter("studentId", OracleDbType.Int32, studentId, ParameterDirection.Input),
        new OracleParameter("sessionId", OracleDbType.Int32, selectedSessionId, ParameterDirection.Input),
        new OracleParameter("semesterId", OracleDbType.Int32, selectedSemesterId, ParameterDirection.Input)
            };
            int rowsAffected = SchoolDatabase.ExecuteNonQuery(insertQuery, parameters);
            if (rowsAffected > 0) {
                MessageBox.Show("Enrollment successful!");
                LoadEnrolledClasses();
                LoadAvailableClasses(); 
            }
            else {
                MessageBox.Show("An error occurred while enrolling the student.");
            }
        }

        private void removeButton_Click(object sender, EventArgs e) {
            if (enrolledClassesDataGridView.SelectedRows.Count == 0) {
                MessageBox.Show("Please select a class to remove the student from.");
                return;
            }
            int selectedSessionId = Convert.ToInt32(enrolledClassesDataGridView.SelectedRows[0].Cells["session_id"].Value);
            string deleteQuery = "DELETE FROM Enrollment WHERE student_id = :studentId AND session_id = :sessionId";
            OracleParameter[] parameters = new OracleParameter[]
            {
                new OracleParameter("studentId", OracleDbType.Int32, studentId, ParameterDirection.Input),
                new OracleParameter("sessionId", OracleDbType.Int32, selectedSessionId, ParameterDirection.Input)
            };
            int rowsAffected = SchoolDatabase.ExecuteNonQuery(deleteQuery, parameters);
            if (rowsAffected > 0) {
                MessageBox.Show("Enrollment removed successfully!");
                LoadEnrolledClasses();
                LoadAvailableClasses(); 
            }
            else {
                MessageBox.Show("An error occurred while removing the enrollment.");
            }
        }
    }
}