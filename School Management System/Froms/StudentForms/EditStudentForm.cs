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
    public partial class EditStudentForm : Form {
        private int studentId;
        private void EditStudentForm_Load(object sender, EventArgs e) {

        }
        public EditStudentForm(int studentId) {
            InitializeComponent();
            this.studentId = studentId;
            LoadStudentData();
        }

        

        private void LoadStudentData() {
           
            string query = "SELECT * FROM Student WHERE student_id = :studentId";
            OracleParameter parameter = new OracleParameter("studentId", OracleDbType.Int32, studentId, ParameterDirection.Input);

            DataTable studentData = SchoolDatabase.ExecuteQuery(query, new OracleParameter[] { parameter });

            if (studentData.Rows.Count > 0) {
                DataRow row = studentData.Rows[0];
                firstNameTextBox.Text = row["first_name"].ToString();
                lastNameTextBox.Text = row["last_name"].ToString();
                dateOfBirthDateTimePicker.Value = Convert.ToDateTime(row["date_of_birth"]);
                genderComboBox.SelectedItem = row["gender"].ToString();
                addressTextBox.Text = row["address"].ToString();
                parentNameTextBox.Text = row["parent_name"].ToString();
                parentContactTextBox.Text = row["parent_contact"].ToString();
            }
            else {
                MessageBox.Show("Student not found.");
            }
        }

        private void updateButton_Click(object sender, EventArgs e) {
           
            Student updatedStudent = new Student {
                StudentId = studentId,
                FirstName = firstNameTextBox.Text,
                LastName = lastNameTextBox.Text,
                DateOfBirth = dateOfBirthDateTimePicker.Value,
                Gender = genderComboBox.SelectedItem.ToString(),
                Address = addressTextBox.Text,
                ParentName = parentNameTextBox.Text,
                ParentContact = parentContactTextBox.Text
            };

            string updateQuery = @"UPDATE Student 
                                   SET first_name = :firstName, 
                                       last_name = :lastName, 
                                       date_of_birth = :dateOfBirth, 
                                       gender = :gender, 
                                       address = :address, 
                                       parent_name = :parentName, 
                                       parent_contact = :parentContact 
                                 WHERE student_id = :studentId";

            OracleParameter[] parameters = new OracleParameter[]
            {
                new OracleParameter("firstName", OracleDbType.Varchar2, updatedStudent.FirstName, ParameterDirection.Input),
                new OracleParameter("lastName", OracleDbType.Varchar2, updatedStudent.LastName, ParameterDirection.Input),
                new OracleParameter("dateOfBirth", OracleDbType.Date, updatedStudent.DateOfBirth, ParameterDirection.Input),
                new OracleParameter("gender", OracleDbType.Varchar2, updatedStudent.Gender, ParameterDirection.Input),
                new OracleParameter("address", OracleDbType.Varchar2, updatedStudent.Address, ParameterDirection.Input),
                new OracleParameter("parentName", OracleDbType.Varchar2, updatedStudent.ParentName, ParameterDirection.Input),
                new OracleParameter("parentContact", OracleDbType.Varchar2, updatedStudent.ParentContact, ParameterDirection.Input),
                new OracleParameter("studentId", OracleDbType.Int32, updatedStudent.StudentId, ParameterDirection.Input)
            };

            int rowsAffected = SchoolDatabase.ExecuteNonQuery(updateQuery, parameters);

           
            if (rowsAffected > 0) {
                MessageBox.Show("Student updated successfully!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else {
                MessageBox.Show("An error occurred while updating the student.");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}