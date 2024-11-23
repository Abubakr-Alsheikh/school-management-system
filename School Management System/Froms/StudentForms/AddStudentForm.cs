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
    public partial class AddStudentForm : Form {
        public AddStudentForm() {
            InitializeComponent();
        }

        private void AddStudentForm_Load(object sender, EventArgs e) {
            
            genderComboBox.Items.AddRange(new string[] { "Male", "Female" }); // Or use your preferred gender options
        }

        private void saveButton_Click(object sender, EventArgs e) {
            Student newStudent = new Student {
                FirstName = firstNameTextBox.Text,
                LastName = lastNameTextBox.Text,
                DateOfBirth = dateOfBirthDateTimePicker.Value,
                Gender = genderComboBox.SelectedItem != null ? genderComboBox.SelectedItem.ToString() : string.Empty, 
                Address = addressTextBox.Text,
                ParentName = parentNameTextBox.Text,
                ParentContact = parentContactTextBox.Text,
                EnrollmentDate = DateTime.Now 
            };
            
            string insertQuery = @"INSERT INTO Student (first_name, last_name, date_of_birth, gender, address, parent_name, parent_contact, enrollment_date) 
                         VALUES (:firstName, :lastName, :dateOfBirth, :gender, :address, :parentName, :parentContact, :enrollmentDate)";

            OracleParameter[] parameters = new OracleParameter[]
            {
        new OracleParameter("firstName", OracleDbType.Varchar2, newStudent.FirstName, ParameterDirection.Input),
        new OracleParameter("lastName", OracleDbType.Varchar2, newStudent.LastName, ParameterDirection.Input),
        new OracleParameter("dateOfBirth", OracleDbType.Date, newStudent.DateOfBirth, ParameterDirection.Input),
        new OracleParameter("gender", OracleDbType.Varchar2, newStudent.Gender, ParameterDirection.Input),
        new OracleParameter("address", OracleDbType.Varchar2, newStudent.Address, ParameterDirection.Input),
        new OracleParameter("parentName", OracleDbType.Varchar2, newStudent.ParentName, ParameterDirection.Input),
        new OracleParameter("parentContact", OracleDbType.Varchar2, newStudent.ParentContact, ParameterDirection.Input),
        new OracleParameter("enrollmentDate", OracleDbType.Date, newStudent.EnrollmentDate, ParameterDirection.Input)
            };

            int rowsAffected = SchoolDatabase.ExecuteNonQuery(insertQuery, parameters);

            
            string getStudentIdQuery = @"SELECT student_id FROM Student 
                                  WHERE first_name = :firstName 
                                  AND last_name = :lastName 
                                  AND date_of_birth = :dateOfBirth 
                                  AND gender = :gender 
                                  AND address = :address 
                                  AND parent_name = :parentName 
                                  AND parent_contact = :parentContact 
                                  AND enrollment_date = :enrollmentDate";

            OracleParameter[] studentIdParams = new OracleParameter[]
            {
        new OracleParameter("firstName", OracleDbType.Varchar2, newStudent.FirstName, ParameterDirection.Input),
        new OracleParameter("lastName", OracleDbType.Varchar2, newStudent.LastName, ParameterDirection.Input),
        new OracleParameter("dateOfBirth", OracleDbType.Date, newStudent.DateOfBirth, ParameterDirection.Input),
        new OracleParameter("gender", OracleDbType.Varchar2, newStudent.Gender, ParameterDirection.Input),
        new OracleParameter("address", OracleDbType.Varchar2, newStudent.Address, ParameterDirection.Input),
        new OracleParameter("parentName", OracleDbType.Varchar2, newStudent.ParentName, ParameterDirection.Input),
        new OracleParameter("parentContact", OracleDbType.Varchar2, newStudent.ParentContact, ParameterDirection.Input),
        new OracleParameter("enrollmentDate", OracleDbType.Date, newStudent.EnrollmentDate, ParameterDirection.Input)
            };

            DataTable studentIdData = SchoolDatabase.ExecuteQuery(getStudentIdQuery, studentIdParams);

            if (studentIdData.Rows.Count > 0) {
                
                if (rowsAffected > 0) {
                    MessageBox.Show("Student added successfully!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else {
                    MessageBox.Show("An error occurred while adding the student.");
                }
            }
            else {
                MessageBox.Show("An error occurred while getting the new student ID.");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}