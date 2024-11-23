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
    public partial class GradeComponentsForm : Form {
        private int selectedComponentId; 

        public GradeComponentsForm() {
            InitializeComponent();
            LoadGradeComponents();
        }

        private void LoadGradeComponents() {
            
            DataTable gradeComponents = SchoolDatabase.ExecuteQuery("SELECT * FROM GradeComponent");

            
            gradeComponentsDataGridView.DataSource = gradeComponents;
        }

        private void addButton_Click(object sender, EventArgs e) {
            
            if (string.IsNullOrEmpty(componentNameTextBox.Text)) {
                MessageBox.Show("Please enter a component name.");
                return;
            }

            
            string insertQuery = @"INSERT INTO GradeComponent (component_name) VALUES (:componentName)";

            OracleParameter[] parameters = new OracleParameter[]
            {
                new OracleParameter("componentName", OracleDbType.Varchar2, componentNameTextBox.Text, ParameterDirection.Input)
            };

            int rowsAffected = SchoolDatabase.ExecuteNonQuery(insertQuery, parameters);

            if (rowsAffected > 0) {
                MessageBox.Show("Grade component added successfully!");
                LoadGradeComponents(); 
                componentNameTextBox.Clear(); 
            }
            else {
                MessageBox.Show("An error occurred while adding the grade component.");
            }
        }

        private void editButton_Click(object sender, EventArgs e) {
            
            string updateQuery = @"UPDATE GradeComponent SET component_name = :componentName WHERE component_id = :componentId";

            OracleParameter[] parameters = new OracleParameter[]
            {
                new OracleParameter("componentName", OracleDbType.Varchar2, componentNameTextBox.Text, ParameterDirection.Input),
                new OracleParameter("componentId", OracleDbType.Int32, selectedComponentId, ParameterDirection.Input)
            };

            int rowsAffected = SchoolDatabase.ExecuteNonQuery(updateQuery, parameters);

            if (rowsAffected > 0) {
                MessageBox.Show("Grade component updated successfully!");
                LoadGradeComponents(); 
                componentNameTextBox.Clear(); 
                selectedComponentId = 0; 
            }
            else {
                MessageBox.Show("An error occurred while updating the grade component.");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e) {
            
            if (gradeComponentsDataGridView.SelectedRows.Count == 0) {
                MessageBox.Show("Please select a grade component to delete.");
                return;
            }

            int componentId = Convert.ToInt32(gradeComponentsDataGridView.SelectedRows[0].Cells["component_id"].Value);

            
            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete the grade component with ID {componentId}?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes) {
                
                string deleteQuery = @"DELETE FROM GradeComponent WHERE component_id = :componentId";

                OracleParameter[] parameters = new OracleParameter[]
                {
                    new OracleParameter("componentId", OracleDbType.Int32, componentId, ParameterDirection.Input)
                };

                int rowsAffected = SchoolDatabase.ExecuteNonQuery(deleteQuery, parameters);

                if (rowsAffected > 0) {
                    MessageBox.Show("Grade component deleted successfully!");
                    LoadGradeComponents(); 
                }
                else {
                    MessageBox.Show("An error occurred while deleting the grade component.");
                }
            }
        }

        private void gradeComponentsDataGridView_SelectionChanged(object sender, EventArgs e) {
            
            if (gradeComponentsDataGridView.SelectedRows.Count > 0) {
                selectedComponentId = Convert.ToInt32(gradeComponentsDataGridView.SelectedRows[0].Cells["component_id"].Value);
                componentNameTextBox.Text = gradeComponentsDataGridView.SelectedRows[0].Cells["component_name"].Value.ToString();
            }
            else {
                selectedComponentId = 0; 
                componentNameTextBox.Clear();
            }
        }

        private void GradeComponentsForm_Load(object sender, EventArgs e) {

        }
    }
}
