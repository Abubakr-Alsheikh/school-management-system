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

namespace School_database_homework_try_2.Froms {
    public partial class SectionForm : Form {
        public SectionForm() {
            InitializeComponent();
            LoadClassData();
        }

        private void SectionForm_Load(object sender, EventArgs e) {
            LoadSectionData();
        }

        private void LoadSectionData() {
            
            string query = @"SELECT s.*, c.class_name 
                    FROM Section s
                    JOIN Class c ON s.class_id = c.class_id";

            
            DataTable sectionDataTable = SchoolDatabase.ExecuteQuery(query);

            
            sectionDataGridView.DataSource = sectionDataTable;

            sectionDataGridView.Columns["class_id"].Visible = false;
        }

        private void LoadClassData() {
            
            DataTable classData = SchoolDatabase.ExecuteQuery("SELECT class_name FROM Class");

            
            classComboBox.Items.Clear();
            foreach (DataRow row in classData.Rows) {
                classComboBox.Items.Add(row["class_name"].ToString());
            }
        }

        private void sectionDataGridView_SelectionChanged(object sender, EventArgs e) {
            if (sectionDataGridView.SelectedRows.Count > 0) {
                DataRowView selectedRow = (DataRowView)sectionDataGridView.SelectedRows[0].DataBoundItem;
                sectionNameTextBox.Text = selectedRow["section_name"].ToString();

                
                int classId = Convert.ToInt32(selectedRow["class_id"]); 

                
                string className = GetClassNameFromId(classId); 

                
                classComboBox.SelectedItem = className;
            }
        }

        private void addButton_Click(object sender, EventArgs e) {
            string sectionName = sectionNameTextBox.Text;
            string className = classComboBox.SelectedItem.ToString();

            
            if (string.IsNullOrEmpty(sectionName) || string.IsNullOrEmpty(className)) {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            
            int classId = GetClassIdFromName(className);

            
            string insertQuery = "INSERT INTO Section (section_name, class_id) VALUES (:sectionName, :classId)";
            OracleParameter[] parameters = new OracleParameter[]
            {
                new OracleParameter("sectionName", OracleDbType.Varchar2, sectionName, ParameterDirection.Input),
                new OracleParameter("classId", OracleDbType.Int32, classId, ParameterDirection.Input)
            };

            int rowsAffected = SchoolDatabase.ExecuteNonQuery(insertQuery, parameters);

            if (rowsAffected > 0) {
                MessageBox.Show("Section added successfully.");
                
                LoadSectionData();
            }
            else {
                MessageBox.Show("An error occurred while adding the section.");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e) {
            if (sectionDataGridView.SelectedRows.Count == 0) {
                MessageBox.Show("Please select a section to delete.");
                return;
            }

            int sectionId = Convert.ToInt32(sectionDataGridView.SelectedRows[0].Cells["section_id"].Value);

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete section with ID {sectionId}?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes) {
                
                string deleteQuery = "DELETE FROM Section WHERE section_id = :sectionId";
                OracleParameter sectionIdParameter = new OracleParameter("sectionId", OracleDbType.Int32, sectionId, ParameterDirection.Input);
                int rowsAffected = SchoolDatabase.ExecuteNonQuery(deleteQuery, new OracleParameter[] { sectionIdParameter });

                if (rowsAffected > 0) {
                    MessageBox.Show("Section deleted successfully.");
                    LoadSectionData();
                }
                else {
                    MessageBox.Show("An error occurred while deleting the section.");
                }
            }
        }

        private void updateButton_Click(object sender, EventArgs e) {
            if (sectionDataGridView.SelectedRows.Count == 0) {
                MessageBox.Show("Please select a section to update.");
                return;
            }

            int sectionId = Convert.ToInt32(sectionDataGridView.SelectedRows[0].Cells["section_id"].Value);
            string sectionName = sectionNameTextBox.Text;
            string className = classComboBox.SelectedItem.ToString();

            
            if (string.IsNullOrEmpty(sectionName) || string.IsNullOrEmpty(className)) {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            
            int classId = GetClassIdFromName(className);

            
            string updateQuery = "UPDATE Section SET section_name = :sectionName, class_id = :classId WHERE section_id = :sectionId";
            OracleParameter[] parameters = new OracleParameter[]
            {
                new OracleParameter("sectionName", OracleDbType.Varchar2, sectionName, ParameterDirection.Input),
                new OracleParameter("classId", OracleDbType.Int32, classId, ParameterDirection.Input),
                new OracleParameter("sectionId", OracleDbType.Int32, sectionId, ParameterDirection.Input)
            };

            int rowsAffected = SchoolDatabase.ExecuteNonQuery(updateQuery, parameters);

            if (rowsAffected > 0) {
                MessageBox.Show("Section updated successfully.");
                LoadSectionData();
            }
            else {
                MessageBox.Show("An error occurred while updating the section.");
            }
        }

        
        private int GetClassIdFromName(string className) {
            string selectClassIdQuery = "SELECT class_id FROM Class WHERE class_name = :className";
            OracleParameter classNameParameter = new OracleParameter("className", OracleDbType.Varchar2, className, ParameterDirection.Input);

            DataTable classIdData = SchoolDatabase.ExecuteQuery(selectClassIdQuery, new OracleParameter[] { classNameParameter });

            if (classIdData.Rows.Count > 0) {
                return Convert.ToInt32(classIdData.Rows[0]["class_id"]);
            }
            else {
                MessageBox.Show($"Class '{className}' not found.");
                return -1; 
            }
        }
        
        private string GetClassNameFromId(int classId) {
            string selectClassNameQuery = "SELECT class_name FROM Class WHERE class_id = :classId";
            OracleParameter classIdParameter = new OracleParameter("classId", OracleDbType.Int32, classId, ParameterDirection.Input);

            DataTable classNameData = SchoolDatabase.ExecuteQuery(selectClassNameQuery, new OracleParameter[] { classIdParameter });

            if (classNameData.Rows.Count > 0) {
                return classNameData.Rows[0]["class_name"].ToString();
            }
            else {
                MessageBox.Show($"Class with ID {classId} not found.");
                return string.Empty; 
            }
        }
    }
}