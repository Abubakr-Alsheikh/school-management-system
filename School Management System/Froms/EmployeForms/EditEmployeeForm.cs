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

namespace School_database_homework_try_2.Froms.EmployeForms {
    public partial class EditEmployeeForm : Form {
        private int employeeId;

        public EditEmployeeForm(int employeeId) {
            InitializeComponent();
            this.employeeId = employeeId;
            LoadRolesIntoListBox();
            LoadEmployeeData();
        }

        private void LoadEmployeeData() {
            string query = "SELECT * FROM Employee WHERE employee_id = :employeeId"; 
            OracleParameter parameter = new OracleParameter("employeeId", OracleDbType.Int32, employeeId, ParameterDirection.Input);
            DataTable employeeData = SchoolDatabase.ExecuteQuery(query, new OracleParameter[] { parameter });

            if (employeeData.Rows.Count > 0) {
                DataRow row = employeeData.Rows[0];
                firstNameTextBox.Text = row["first_name"].ToString();
                lastNameTextBox.Text = row["last_name"].ToString();
                dateOfBirthDateTimePicker.Value = Convert.ToDateTime(row["date_of_birth"]);
                phoneNumberTextBox.Text = row["phone_number"].ToString();
                addressTextBox.Text = row["address"].ToString();
                hireDateDateTimePicker.Value = Convert.ToDateTime(row["hire_date"]);
            }
            else {
                MessageBox.Show("Employee not found.");
            }
        }

        private void LoadRolesIntoListBox() {
            DataTable roles = SchoolDatabase.ExecuteQuery("SELECT role_id, role_name FROM Role");
            roleListBox.DataSource = roles;
            roleListBox.DisplayMember = "role_name"; 
            roleListBox.ValueMember = "role_id";    

            string roleQuery = "SELECT r.role_id, r.role_name FROM EmployeeRole er JOIN Role r ON er.role_id = r.role_id WHERE er.employee_id = :employeeId";
            OracleParameter employeeIdParam = new OracleParameter("employeeId", OracleDbType.Int32, employeeId, ParameterDirection.Input);
            DataTable roleData = SchoolDatabase.ExecuteQuery(roleQuery, new OracleParameter[] { employeeIdParam });

            foreach (int roleId in roleData.AsEnumerable().Select(row => Convert.ToInt32(row["role_id"]))) {
                for (int i = 0; i < roleListBox.Items.Count; i++) {
                    int listboxRoleId = Convert.ToInt32(((DataRowView)roleListBox.Items[i])["role_id"].ToString());
                    
                    if (listboxRoleId == roleId) {
                        roleListBox.SetSelected(i, true);
                    }
                }
            }
        }

        private void updateButton_Click(object sender, EventArgs e) {
            Employee updatedEmployee = new Employee {
                EmployeeId = employeeId,
                FirstName = firstNameTextBox.Text,
                LastName = lastNameTextBox.Text,
                DateOfBirth = dateOfBirthDateTimePicker.Value,
                PhoneNumber = phoneNumberTextBox.Text,
                Address = addressTextBox.Text,
                HireDate = hireDateDateTimePicker.Value
            };

            string updateQuery = "UPDATE Employee SET first_name = :firstName, last_name = :lastName, date_of_birth = :dateOfBirth, phone_number = :phoneNumber, address = :address, hire_date = :hireDate WHERE employee_id = :employeeId";
            OracleParameter[] parameters = new OracleParameter[]
            {
                new OracleParameter("firstName", OracleDbType.Varchar2, updatedEmployee.FirstName, ParameterDirection.Input),
                new OracleParameter("lastName", OracleDbType.Varchar2, updatedEmployee.LastName, ParameterDirection.Input),
                new OracleParameter("dateOfBirth", OracleDbType.Date, updatedEmployee.DateOfBirth, ParameterDirection.Input),
                new OracleParameter("phoneNumber", OracleDbType.Varchar2, updatedEmployee.PhoneNumber, ParameterDirection.Input),
                new OracleParameter("address", OracleDbType.Varchar2, updatedEmployee.Address, ParameterDirection.Input),
                new OracleParameter("hireDate", OracleDbType.Date, updatedEmployee.HireDate, ParameterDirection.Input),
                new OracleParameter("employeeId", OracleDbType.Int32, updatedEmployee.EmployeeId, ParameterDirection.Input)
            };
            int rowsAffected = SchoolDatabase.ExecuteNonQuery(updateQuery, parameters);
            
            string deleteRoleQuery = "DELETE FROM EmployeeRole WHERE employee_id = :employeeId";
            OracleParameter employeeIdParam = new OracleParameter("employeeId", OracleDbType.Int32, updatedEmployee.EmployeeId, ParameterDirection.Input);
            SchoolDatabase.ExecuteNonQuery(deleteRoleQuery, new OracleParameter[] { employeeIdParam });
            
            foreach (int roleId in roleListBox.SelectedItems.Cast<DataRowView>().Select(row => Convert.ToInt32(row.Row["role_id"]))) {
                string insertRoleQuery = "INSERT INTO EmployeeRole (employee_id, role_id) VALUES (:employeeId, :roleId)";
                OracleParameter[] insertRoleParams = new OracleParameter[]
                {
                    new OracleParameter("employeeId", OracleDbType.Int32, updatedEmployee.EmployeeId, ParameterDirection.Input),
                    new OracleParameter("roleId", OracleDbType.Int32, roleId, ParameterDirection.Input)
                };
                SchoolDatabase.ExecuteNonQuery(insertRoleQuery, insertRoleParams);
            }
            if (rowsAffected > 0) {
                MessageBox.Show("Employee updated successfully!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else {
                MessageBox.Show("An error occurred while updating the employee.");
            }
        }

        private void EditEmployeeForm_Load(object sender, EventArgs e) {
            LoadRolesIntoListBox();
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
