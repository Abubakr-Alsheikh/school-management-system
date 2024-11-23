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
    public partial class AddClassForm : Form {
        public AddClassForm() {
            InitializeComponent();
            LoadGradeLevels();
        }

        private void AddClassForm_Load(object sender, EventArgs e) {
        }

        private void LoadGradeLevels() {
            DataTable gradeLevels = SchoolDatabase.ExecuteQuery("SELECT * FROM Grade");
            gradeComboBox.DataSource = gradeLevels;
            gradeComboBox.DisplayMember = "grade_name";
            gradeComboBox.ValueMember = "grade_id"; 
        }

        private void saveButton_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(classNameTextBox.Text)) {
                MessageBox.Show("Please enter a class name.");
                return;
            }
            Classes newClass = new Classes {
                ClassName = classNameTextBox.Text,
                GradeId = Convert.ToInt32(gradeComboBox.SelectedValue) 
            };
            string insertQuery = @"INSERT INTO Class (class_name, grade_id) VALUES (:className, :gradeId)";
            OracleParameter[] parameters = new OracleParameter[]
            {
                new OracleParameter("className", OracleDbType.Varchar2, newClass.ClassName, ParameterDirection.Input),
                new OracleParameter("gradeId", OracleDbType.Int32, newClass.GradeId, ParameterDirection.Input)
            };
            int rowsAffected = SchoolDatabase.ExecuteNonQuery(insertQuery, parameters);
            if (rowsAffected > 0) {
                MessageBox.Show("Class added successfully!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else {
                MessageBox.Show("An error occurred while adding the class.");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}