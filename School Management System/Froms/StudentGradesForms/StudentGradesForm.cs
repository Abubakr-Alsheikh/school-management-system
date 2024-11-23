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

namespace School_database_homework_try_2.Froms.StudentGradesForms {
    public partial class StudentGradesForm : Form {
        public StudentGradesForm() {
            InitializeComponent();
            LoadStudents();
            LoadClassSessions();
        }

        private void StudentGradesForm_Load(object sender, EventArgs e) {
        }

        private void LoadStudents() {
            
            DataTable students = SchoolDatabase.ExecuteQuery("SELECT student_id, first_name || ' ' || last_name AS student_name FROM Student");

            
            studentComboBox.DataSource = students;
            studentComboBox.DisplayMember = "student_name";
            studentComboBox.ValueMember = "student_id";
        }

        private void LoadClassSessions() {
            
            DataTable classSessions = SchoolDatabase.ExecuteQuery(
                "SELECT cs.session_id, c.class_name " +
                "FROM ClassSession cs " +
                "JOIN Class c ON cs.class_id = c.class_id");

            
            classSessionComboBox.DataSource = classSessions;
            classSessionComboBox.DisplayMember = "class_name";
            classSessionComboBox.ValueMember = "session_id";
        }

        private void studentComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            
            RefreshGrades();
        }

        private void classSessionComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            
            RefreshGrades();
        }

        private void RefreshGrades() {
            
            int studentId = Convert.ToInt32(studentComboBox.SelectedValue);
            int classSessionId = Convert.ToInt32(classSessionComboBox.SelectedValue);

            
            string query = @"
                            SELECT 
                                sg.grade_id, 
                                gc.component_name AS GradeComponent,
                                sg.score AS Score
                            FROM 
                                StudentGrade sg
                            JOIN 
                                Enrollment e ON sg.enrollment_id = e.enrollment_id
                            JOIN
                                GradeComponent gc ON sg.component_id = gc.component_id
                            WHERE 
                                e.student_id = :studentId AND e.session_id = :classSessionId
                        ";

            OracleParameter[] parameters = new OracleParameter[]
            {
        new OracleParameter("studentId", OracleDbType.Int32, studentId, ParameterDirection.Input),
        new OracleParameter("classSessionId", OracleDbType.Int32, classSessionId, ParameterDirection.Input)
            };

            
            Console.WriteLine(query);

            DataTable grades = SchoolDatabase.ExecuteQuery(query, parameters);

            
            gradesDataGridView.DataSource = grades;
        }

        private void addGradeButton_Click(object sender, EventArgs e) {
            
            AddStudentGradeForm addGradeForm = new AddStudentGradeForm();
            addGradeForm.ShowDialog();

            
            RefreshGrades();
        }

        private void editGradeButton_Click(object sender, EventArgs e) {
            
            if (gradesDataGridView.SelectedRows.Count == 0) {
                MessageBox.Show("Please select a grade to edit.");
                return;
            }

            
            int gradeId = Convert.ToInt32(gradesDataGridView.SelectedRows[0].Cells["grade_id"].Value);

            
            EditStudentGradeForm editGradeForm = new EditStudentGradeForm(gradeId);
            editGradeForm.ShowDialog();

            
            RefreshGrades();
        }

        private void deleteGradeButton_Click(object sender, EventArgs e) {
            
            if (gradesDataGridView.SelectedRows.Count == 0) {
                MessageBox.Show("Please select a grade to delete.");
                return;
            }

            
            int gradeId = Convert.ToInt32(gradesDataGridView.SelectedRows[0].Cells["grade_id"].Value);

            
            DialogResult result = MessageBox.Show("Are you sure you want to delete this grade?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes) {
                
                try {
                    
                    OracleParameter gradeIdParameter = new OracleParameter("gradeId", OracleDbType.Int32, gradeId, ParameterDirection.Input);

                    
                    int rowsAffected = SchoolDatabase.ExecuteNonQuery(
                        "DELETE FROM StudentGrade WHERE grade_id = :gradeId",
                        new OracleParameter[] { gradeIdParameter });

                    if (rowsAffected > 0) {
                        MessageBox.Show("Grade deleted successfully.");
                        
                        RefreshGrades();
                    }
                    else {
                        MessageBox.Show("An error occurred while deleting the grade.");
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void manageComponentsButton_Click(object sender, EventArgs e) {
            
            GradeComponentsForm gradeComponentsForm = new GradeComponentsForm();

            
            gradeComponentsForm.ShowDialog();
        }
    }
}