using Oracle.ManagedDataAccess.Client;
using School_database_homework_try_2.Froms.ClassForms; // Assuming you'll create a ClassForms folder
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
    public partial class ClassListForm : Form {
        public ClassListForm() {
            InitializeComponent();
        }

        private void ClassListForm_Load(object sender, EventArgs e) {
            string query = @"SELECT 
                        C.class_id, 
                        C.class_name, 
                        G.grade_name 
                    FROM Class C
                    JOIN Grade G ON C.grade_id = G.grade_id";

            DataTable classDataTable = SchoolDatabase.ExecuteQuery(query);
            classDataGridView.DataSource = classDataTable;
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e) {
            string searchTerm = searchTextBox.Text.Trim();
            string query = @"SELECT * FROM Class WHERE class_name LIKE :searchTerm";
            OracleParameter searchTermParameter = new OracleParameter(":searchTerm", OracleDbType.Varchar2);
            searchTermParameter.Value = "%" + searchTerm + "%"; 
            DataTable searchResults = SchoolDatabase.ExecuteQuery(query, new OracleParameter[] { searchTermParameter });
            classDataGridView.DataSource = searchResults;
        }
        private void classroomButton_Click(object sender, EventArgs e) {
            ClassroomForm classroomForm = new ClassroomForm();
            classroomForm.ShowDialog();
        }

        private void deleteButton_Click(object sender, EventArgs e) {
            if (classDataGridView.SelectedRows.Count == 0) {
                MessageBox.Show("Please select a class to delete.");
                return; 
            }
            int classId = Convert.ToInt32(classDataGridView.SelectedRows[0].Cells["class_id"].Value);
            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete class with ID {classId}?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (result == DialogResult.No) {
                return; 
            }
            try {
                OracleParameter classIdParameter = new OracleParameter("class_id", classId);
                int rowsAffected = SchoolDatabase.ExecuteNonQuery(
                    "DELETE FROM Class WHERE class_id = :class_id",
                    new OracleParameter[] { classIdParameter });
                if (rowsAffected > 0) {
                    MessageBox.Show("Class deleted successfully.");
                    
                    RefreshClassList();
                }
                else {
                    MessageBox.Show("An error occurred while deleting the class.");
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void gradeButton_Click(object sender, EventArgs e) {
            GradeForm gradeForm = new GradeForm();
            gradeForm.ShowDialog();
        }

        private void editButton_Click(object sender, EventArgs e) {
            if (classDataGridView.SelectedRows.Count == 0) {
                MessageBox.Show("Please select a class to edit.");
                return; 
            }
            int selectedClassId = Convert.ToInt32(classDataGridView.SelectedRows[0].Cells["class_id"].Value);
            EditClassForm editClassForm = new EditClassForm(selectedClassId);
            DialogResult result = editClassForm.ShowDialog();
            if (result == DialogResult.OK) {
                RefreshClassList();
            }
        }

        private void addButton_Click(object sender, EventArgs e) {
            AddClassForm addClassForm = new AddClassForm();
            DialogResult result = addClassForm.ShowDialog();
            if (result == DialogResult.OK) {
                DataTable classDataTable = SchoolDatabase.ExecuteQuery("select * from Class");
                classDataGridView.DataSource = classDataTable;
            }
        }

        private void RefreshClassList() {
            DataTable classDataTable = SchoolDatabase.ExecuteQuery("SELECT * FROM Class");
            classDataGridView.DataSource = classDataTable;
        }

        private void classSessionButton_Click(object sender, EventArgs e) {
            ClassSessionForm classSessionForm = new ClassSessionForm(); 
            classSessionForm.ShowDialog(); 
        }
        private void manageSectionsButton_Click(object sender, EventArgs e) {
            SectionForm sectionForm = new SectionForm();
            sectionForm.ShowDialog();
        }
        private void subjectButton_Click(object sender, EventArgs e) {
            SubjectForm subjectForm = new SubjectForm();
            subjectForm.ShowDialog();
        }
        private void semesterButton_Click(object sender, EventArgs e) {
            SemesterForm semesterForm = new SemesterForm();
            semesterForm.ShowDialog();
        }
    }
}