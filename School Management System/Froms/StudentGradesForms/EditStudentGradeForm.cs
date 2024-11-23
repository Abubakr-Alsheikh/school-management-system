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
    public partial class EditStudentGradeForm : Form {
        private int gradeId; 

        public EditStudentGradeForm(int gradeId) {
            InitializeComponent();
            this.gradeId = gradeId;
            LoadGradeData();
            LoadStudents();
            LoadClassSessions();
            LoadGradeComponents();
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

        private void LoadGradeComponents() {
            
            DataTable gradeComponents = SchoolDatabase.ExecuteQuery("SELECT component_id, component_name FROM GradeComponent");

            
            gradeComponentComboBox.DataSource = gradeComponents;
            gradeComponentComboBox.DisplayMember = "component_name";
            gradeComponentComboBox.ValueMember = "component_id";
        }

        private void LoadGradeData() {
            string query = "SELECT sg.grade_id, sg.score, e.student_id, e.session_id, sg.component_id " +
                           "FROM StudentGrade sg " +
                           "JOIN Enrollment e ON sg.enrollment_id = e.enrollment_id " +
                           "WHERE sg.grade_id = :gradeId";

            OracleParameter parameter = new OracleParameter("gradeId", OracleDbType.Int32, gradeId, ParameterDirection.Input);

            DataTable gradeData = SchoolDatabase.ExecuteQuery(query, new OracleParameter[] { parameter });

            if (gradeData.Rows.Count > 0) {
                DataRow row = gradeData.Rows[0];

                
                

                scoreTextBox.Text = row["score"].ToString();
                studentComboBox.SelectedValue = row["student_id"];
                classSessionComboBox.SelectedValue = row["session_id"];
                gradeComponentComboBox.SelectedValue = row["component_id"];
            }
            else {
                MessageBox.Show("Grade not found.");
            }
        }

        private void updateButton_Click(object sender, EventArgs e) {
            
            if (string.IsNullOrEmpty(scoreTextBox.Text)) {
                MessageBox.Show("Please enter a score.");
                return;
            }

            if (!decimal.TryParse(scoreTextBox.Text, out decimal score)) {
                MessageBox.Show("Please enter a valid numeric score.");
                return;
            }

            
            string updateQuery = @"UPDATE StudentGrade SET score = :score WHERE grade_id = :gradeId";

            OracleParameter[] parameters = new OracleParameter[]
            {
                new OracleParameter("score", OracleDbType.Decimal, score, ParameterDirection.Input),
                new OracleParameter("gradeId", OracleDbType.Int32, gradeId, ParameterDirection.Input)
            };

            int rowsAffected = SchoolDatabase.ExecuteNonQuery(updateQuery, parameters);

            if (rowsAffected > 0) {
                MessageBox.Show("Grade updated successfully!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else {
                MessageBox.Show("An error occurred while updating the grade.");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void EditStudentGradeForm_Load(object sender, EventArgs e) {

        }
    }
}
