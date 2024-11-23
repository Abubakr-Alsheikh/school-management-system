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
    public partial class EmployeeRolesForm : Form {
        public EmployeeRolesForm() {
            InitializeComponent();
            LoadRolesIntoListBox();
        }

        private void LoadRolesIntoListBox() {
            DataTable roles = SchoolDatabase.ExecuteQuery("SELECT role_id, role_name FROM Role");
            availableRolesListBox.DataSource = roles;
            availableRolesListBox.DisplayMember = "role_name";
            availableRolesListBox.ValueMember = "role_id";
        }

        private void LoadRoles() {
            DataTable roles = SchoolDatabase.ExecuteQuery("SELECT role_id, role_name FROM Role");
            availableRolesListBox.DataSource = roles;
            availableRolesListBox.DisplayMember = "role_name";
            availableRolesListBox.ValueMember = "role_id";
        }

        private void addRoleButton_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(newRoleNameTextBox.Text.Trim())) {
                MessageBox.Show("Please enter a valid role name.");
                return;
            }

            string insertRoleQuery = "INSERT INTO Role (role_name) VALUES (:roleName)";
            OracleParameter roleNameParam = new OracleParameter("roleName", OracleDbType.Varchar2, newRoleNameTextBox.Text.Trim(), ParameterDirection.Input);
            SchoolDatabase.ExecuteNonQuery(insertRoleQuery, new OracleParameter[] { roleNameParam });

            LoadRoles();
        }


        private void deleteRoleButton_Click(object sender, EventArgs e) {
            if (availableRolesListBox.SelectedItem == null) {
                MessageBox.Show("Please select a role to delete.");
                return;
            }

            int roleId = Convert.ToInt32(availableRolesListBox.SelectedValue);

            string deleteRoleQuery = "DELETE FROM Role WHERE role_id = :roleId";
            OracleParameter[] deleteRoleParams = new OracleParameter[]
            {
                new OracleParameter("roleId", OracleDbType.Int32, roleId, ParameterDirection.Input)
            };
            SchoolDatabase.ExecuteNonQuery(deleteRoleQuery, deleteRoleParams);

            LoadRoles();
        }

        private void closeButton_Click(object sender, EventArgs e) {
            this.Close();
        }
        private void EmployeeRolesForm_Load(object sender, EventArgs e) {
        }
    }
}
