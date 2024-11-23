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
    public partial class ClassroomForm : Form {
        public ClassroomForm() {
            InitializeComponent();
            RefreshClassroomList();
        }

        private void addClassroomButton_Click(object sender, EventArgs e) {
            
            string roomNumber = roomNumberTextBox.Text.Trim();
            if (string.IsNullOrEmpty(roomNumber)) {
                MessageBox.Show("Please enter a room number.");
                return;
            }

            int capacity;
            if (!int.TryParse(capacityTextBox.Text, out capacity)) {
                MessageBox.Show("Please enter a valid capacity (integer).");
                return;
            }

            
            string insertQuery = @"INSERT INTO Classroom (room_number, capacity) VALUES (:roomNumber, :capacity)";
            OracleParameter roomNumberParameter = new OracleParameter(":roomNumber", OracleDbType.Varchar2, roomNumber, ParameterDirection.Input);
            OracleParameter capacityParameter = new OracleParameter(":capacity", OracleDbType.Int32, capacity, ParameterDirection.Input);
            int rowsAffected = SchoolDatabase.ExecuteNonQuery(insertQuery, new OracleParameter[] { roomNumberParameter, capacityParameter });

            if (rowsAffected > 0) {
                MessageBox.Show("Classroom added successfully.");
                roomNumberTextBox.Clear();
                capacityTextBox.Clear();
                RefreshClassroomList(); 
            }
            else {
                MessageBox.Show("An error occurred while adding the classroom.");
            }
        }

        private void deleteClassroomButton_Click(object sender, EventArgs e) {
            
            if (classroomDataGridView.SelectedRows.Count == 0) {
                MessageBox.Show("Please select a classroom to delete.");
                return;
            }

            int classroomId = Convert.ToInt32(classroomDataGridView.SelectedRows[0].Cells["classroom_id"].Value);

            
            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete classroom with ID {classroomId}?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.No) {
                return;
            }

            
            string deleteQuery = "DELETE FROM Classroom WHERE classroom_id = :classroomId";
            OracleParameter classroomIdParameter = new OracleParameter(":classroomId", classroomId);
            int rowsAffected = SchoolDatabase.ExecuteNonQuery(deleteQuery, new OracleParameter[] { classroomIdParameter });

            if (rowsAffected > 0) {
                MessageBox.Show("Classroom deleted successfully.");
                RefreshClassroomList();
            }
            else {
                MessageBox.Show("An error occurred while deleting the classroom.");
            }
        }

        private void RefreshClassroomList() {
            DataTable classroomDataTable = SchoolDatabase.ExecuteQuery("SELECT * FROM Classroom");
            classroomDataGridView.DataSource = classroomDataTable;
        }
    }
}
