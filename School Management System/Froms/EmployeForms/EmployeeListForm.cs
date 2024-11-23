using Oracle.ManagedDataAccess.Client;
using School_database_homework_try_2.Froms.EmployeForms;
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
    public partial class EmployeeListForm : Form {
        public EmployeeListForm() {
            InitializeComponent();
        }

        private void EmployeeListForm_Load(object sender, EventArgs e) {
            DataTable employeesDataTable = SchoolDatabase.ExecuteQuery("select * from employee");

            employeeDataGridView.DataSource = employeesDataTable;
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e) {
            string searchTerm = searchTextBox.Text.Trim();

            string query = @"SELECT * FROM Employee WHERE First_Name LIKE :searchTerm OR Last_Name LIKE :searchTerm";

            OracleParameter searchTermParameter = new OracleParameter(":searchTerm", OracleDbType.Varchar2);
            searchTermParameter.Value = "%" + searchTerm + "%";
            DataTable searchResults = SchoolDatabase.ExecuteQuery(query, new OracleParameter[] { searchTermParameter });
            employeeDataGridView.DataSource = searchResults;
        }

        private void deleteButton_Click(object sender, EventArgs e) {

            if (employeeDataGridView.SelectedRows.Count == 0) {
                MessageBox.Show("Please select an employee to delete.");
                return;
            }

            int employeeId = Convert.ToInt32(employeeDataGridView.SelectedRows[0].Cells["employee_id"].Value);

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete employee with ID {employeeId}?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.No) {
                return;
            }

            try {
                OracleParameter employeeIdParameter = new OracleParameter("employee_id", employeeId);

                int rowsAffected = SchoolDatabase.ExecuteNonQuery(
                    "DELETE FROM Employee WHERE employee_id = :employee_id",
                    new OracleParameter[] { employeeIdParameter });

                if (rowsAffected > 0) {
                    MessageBox.Show("Employee deleted successfully.");

                    RefreshEmployeeList();
                }
                else {
                    MessageBox.Show("An error occurred while deleting the employee.");
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void editButton_Click(object sender, EventArgs e) {

            if (employeeDataGridView.SelectedRows.Count == 0) {
                MessageBox.Show("Please select an employee to edit.");
                return;
            }

            int selectedEmployeeId = Convert.ToInt32(employeeDataGridView.SelectedRows[0].Cells["employee_id"].Value);
            EditEmployeeForm editEmployeeForm = new EditEmployeeForm(selectedEmployeeId);
            DialogResult result = editEmployeeForm.ShowDialog();

            if (result == DialogResult.OK) {
                RefreshEmployeeList();
            }
        }

        private void addButton_Click(object sender, EventArgs e) {
            AddEmployeeForm addEmployeeForm = new AddEmployeeForm();
            DialogResult result = addEmployeeForm.ShowDialog();
            if (result == DialogResult.OK) {
                DataTable employeesDataTable = SchoolDatabase.ExecuteQuery("select * from employee");
                employeeDataGridView.DataSource = employeesDataTable;
            }
        }

        private void RefreshEmployeeList() {
            DataTable employeeDataTable = SchoolDatabase.ExecuteQuery("SELECT * FROM Employee");
            employeeDataGridView.DataSource = employeeDataTable;
        }

        private void employeeDataGridView_SelectionChanged(object sender, EventArgs e) {
            if (employeeDataGridView.SelectedRows.Count > 0) {
                int selectedEmployeeId = Convert.ToInt32(employeeDataGridView.SelectedRows[0].Cells["employee_id"].Value);

                string roleQuery = "SELECT r.role_name FROM EmployeeRole er JOIN Role r ON er.role_id = r.role_id WHERE er.employee_id = :employeeId";
                OracleParameter employeeIdParam = new OracleParameter("employeeId", OracleDbType.Int32, selectedEmployeeId, ParameterDirection.Input);
                DataTable roleData = SchoolDatabase.ExecuteQuery(roleQuery, new OracleParameter[] { employeeIdParam });
                rolesDataGridView.DataSource = roleData;
            }
            else {
                rolesDataGridView.DataSource = null;
            }
        }

        private void viewRolesButton_Click(object sender, EventArgs e) {
            EmployeeRolesForm manageRolesForm = new EmployeeRolesForm();
            manageRolesForm.ShowDialog();
        }
    }
}
