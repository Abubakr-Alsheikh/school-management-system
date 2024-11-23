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
public partial class AddEmployeeForm : Form {
    public AddEmployeeForm() {
        InitializeComponent();
        LoadRolesIntoListBox(); 
    }
    private void LoadRolesIntoListBox() {
        DataTable roles = SchoolDatabase.ExecuteQuery("SELECT role_id, role_name FROM Role");
        roleListBox.DataSource = roles;
        roleListBox.DisplayMember = "role_name"; 
        roleListBox.ValueMember = "role_id";    
    }

    private void AddEmployeeForm_Load(object sender, EventArgs e) {
    }

    private void cancelButton_Click(object sender, EventArgs e) {
        this.Close(); 
    }

    private void saveButton_Click(object sender, EventArgs e) {
        Employee newEmployee = new Employee {
            FirstName = firstNameTextBox.Text,
            LastName = lastNameTextBox.Text,
            DateOfBirth = dateOfBirthDateTimePicker.Value,
            PhoneNumber = phoneNumberTextBox.Text,
            Address = addressTextBox.Text,
            HireDate = hireDateDateTimePicker.Value
        };
        string insertQuery = "INSERT INTO Employee (first_name, last_name, date_of_birth, phone_number, address, hire_date) VALUES (:firstName, :lastName, :dateOfBirth, :phoneNumber, :address, :hireDate)";
        OracleParameter[] parameters = new OracleParameter[]
        {
            new OracleParameter("firstName", OracleDbType.Varchar2, newEmployee.FirstName, ParameterDirection.Input),
            new OracleParameter("lastName", OracleDbType.Varchar2, newEmployee.LastName, ParameterDirection.Input),
            new OracleParameter("dateOfBirth", OracleDbType.Date, newEmployee.DateOfBirth, ParameterDirection.Input),
            new OracleParameter("phoneNumber", OracleDbType.Varchar2, newEmployee.PhoneNumber, ParameterDirection.Input),
            new OracleParameter("address", OracleDbType.Varchar2, newEmployee.Address, ParameterDirection.Input),
            new OracleParameter("hireDate", OracleDbType.Date, newEmployee.HireDate, ParameterDirection.Input)
        };

        int rowsAffected = SchoolDatabase.ExecuteNonQuery(insertQuery, parameters);
            
        string getEmployeeIdQuery = "SELECT employee_id FROM Employee WHERE first_name = :firstName AND last_name = :lastName AND date_of_birth = :dateOfBirth AND phone_number = :phoneNumber AND address = :address AND hire_date = :hireDate";
        OracleParameter[] employeeIdParams = new OracleParameter[]
        {
            new OracleParameter("firstName", OracleDbType.Varchar2, newEmployee.FirstName, ParameterDirection.Input),
            new OracleParameter("lastName", OracleDbType.Varchar2, newEmployee.LastName, ParameterDirection.Input),
            new OracleParameter("dateOfBirth", OracleDbType.Date, newEmployee.DateOfBirth, ParameterDirection.Input),
            new OracleParameter("phoneNumber", OracleDbType.Varchar2, newEmployee.PhoneNumber, ParameterDirection.Input),
            new OracleParameter("address", OracleDbType.Varchar2, newEmployee.Address, ParameterDirection.Input),
            new OracleParameter("hireDate", OracleDbType.Date, newEmployee.HireDate, ParameterDirection.Input)
        };

        DataTable employeeIdData = SchoolDatabase.ExecuteQuery(getEmployeeIdQuery, employeeIdParams);

        if (employeeIdData.Rows.Count > 0) {
            int newEmployeeId = Convert.ToInt32(employeeIdData.Rows[0]["employee_id"]);
            foreach (int roleId in roleListBox.SelectedItems.Cast<DataRowView>().Select(row => Convert.ToInt32(row.Row["role_id"]))) {
                string insertRoleQuery = "INSERT INTO EmployeeRole (employee_id, role_id) VALUES (:employeeId, :roleId)";
                OracleParameter[] insertRoleParams = new OracleParameter[]
                {
                    new OracleParameter("employeeId", OracleDbType.Int32, newEmployeeId, ParameterDirection.Input),
                    new OracleParameter("roleId", OracleDbType.Int32, roleId, ParameterDirection.Input)
                };
                SchoolDatabase.ExecuteNonQuery(insertRoleQuery, insertRoleParams);
            }
            if (rowsAffected > 0) {
                MessageBox.Show("Employee added successfully!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else {
                MessageBox.Show("An error occurred while adding the employee.");
            }
        }
        else {
            MessageBox.Show("An error occurred while getting the new employee ID.");
        }
    }
}
}
