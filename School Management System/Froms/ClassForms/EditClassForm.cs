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

namespace School_database_homework_try_2.Froms.ClassForms {
    public partial class EditClassForm : Form {
        private int classId;

        public EditClassForm(int classId) {
            InitializeComponent();
            this.classId = classId;
            LoadClassData();
        }

        private void EditClassForm_Load(object sender, EventArgs e) {
            DataTable grades = SchoolDatabase.ExecuteQuery("SELECT grade_id, grade_name FROM Grade");
            gradeComboBox.DataSource = grades;
            gradeComboBox.DisplayMember = "grade_name"; 
            gradeComboBox.ValueMember = "grade_id";    
        }

        private void LoadClassData() {
            
            string query = "SELECT * FROM Class WHERE class_id = :classId";
            OracleParameter parameter = new OracleParameter("classId", OracleDbType.Int32, classId, ParameterDirection.Input);

            DataTable classData = SchoolDatabase.ExecuteQuery(query, new OracleParameter[] { parameter });

            if (classData.Rows.Count > 0) {
                DataRow row = classData.Rows[0];
                classNameTextBox.Text = row["class_name"].ToString();

                
                string gradeQuery = "SELECT grade_name FROM Grade WHERE grade_id = :gradeId";
                OracleParameter gradeIdParameter = new OracleParameter("gradeId", OracleDbType.Int32, row["grade_id"], ParameterDirection.Input);

                DataTable gradeData = SchoolDatabase.ExecuteQuery(gradeQuery, new OracleParameter[] { gradeIdParameter });

                if (gradeData.Rows.Count > 0) {
                    gradeComboBox.SelectedItem = gradeData.Rows[0]["grade_name"].ToString();
                }
                else {
                    MessageBox.Show("Grade not found for this class.");
                }
            }
            else {
                MessageBox.Show("Class not found.");
            }
        }

        private void updateButton_Click(object sender, EventArgs e) {
            string gradeName = ((DataRowView)gradeComboBox.SelectedItem).Row["grade_name"].ToString();
            
            int gradeId = GetGradeIdFromComboBox(gradeName);

            if (gradeId == -1) {
                
                MessageBox.Show("Please select a valid grade from the list.");
                return;
            }

            
            Classes updatedClass = new Classes {
                ClassId = classId,
                ClassName = classNameTextBox.Text,
                GradeId = gradeId
            };

            string updateQuery = @"UPDATE Class 
                                   SET class_name = :className, 
                                       grade_id = :gradeId 
                                 WHERE class_id = :classId";

            OracleParameter[] parameters = new OracleParameter[]
            {
                new OracleParameter("className", OracleDbType.Varchar2, updatedClass.ClassName, ParameterDirection.Input),
                new OracleParameter("gradeId", OracleDbType.Int32, updatedClass.GradeId, ParameterDirection.Input),
                new OracleParameter("classId", OracleDbType.Int32, updatedClass.ClassId, ParameterDirection.Input)
            };

            int rowsAffected = SchoolDatabase.ExecuteNonQuery(updateQuery, parameters);

            
            if (rowsAffected > 0) {
                MessageBox.Show("Class updated successfully!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else {
                MessageBox.Show("An error occurred while updating the class.");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        private int GetGradeIdFromComboBox(string gradeName) {
            
            string query = "SELECT grade_id FROM Grade WHERE grade_name = :gradeName";
            OracleParameter parameter = new OracleParameter("gradeName", OracleDbType.Varchar2, gradeName, ParameterDirection.Input);

            DataTable gradeData = SchoolDatabase.ExecuteQuery(query, new OracleParameter[] { parameter });

            if (gradeData.Rows.Count > 0) {
                return Convert.ToInt32(gradeData.Rows[0]["grade_id"]);
            }
            else {
                
                MessageBox.Show($"The grade '{gradeName}' does not exist. Please add the grade first or select a valid grade.");
                return -1; 
            }
        }
    }
}