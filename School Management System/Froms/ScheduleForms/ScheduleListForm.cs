using Oracle.ManagedDataAccess.Client;
using School_database_homework_try_2.Froms; 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_database_homework_try_2.Froms.ScheduleForms {
    public partial class ScheduleListForm : Form {
        public ScheduleListForm() {
            InitializeComponent();
        }

        private void ScheduleListForm_Load(object sender, EventArgs e) {
            LoadSchedule();
        }

        private void LoadSchedule() {
            
            string query = @"SELECT 
                                s.schedule_id,
                                c.class_name AS ClassName,
                                r.room_number AS Classroom,
                                su.subject_name AS SubjectName,
                                e.first_name || ' ' || e.last_name AS TeacherName,
                                se.semester_name || ' ' || se.school_year AS Semester,
                                s.day_of_week AS DayOfWeek,
                                TO_CHAR(s.start_time, 'HH24:MI') AS StartTime,
                                TO_CHAR(s.end_time, 'HH24:MI') AS EndTime
                            FROM 
                                Schedule s
                            JOIN 
                                Class c ON s.class_id = c.class_id
                            JOIN 
                                Classroom r ON s.classroom_id = r.classroom_id
                            JOIN 
                                ClassSession cs ON s.session_id = cs.session_id
                            JOIN 
                                Employee e ON cs.teacher_id = e.employee_id
                            JOIN 
                                Semester se ON cs.semester_id = se.semester_id
                            JOIN 
                                Subject su ON cs.subject_id = su.subject_id";

            DataTable scheduleDataTable = SchoolDatabase.ExecuteQuery(query);

            
            scheduleDataGridView.DataSource = scheduleDataTable;
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e) {
            
            string searchTerm = searchTextBox.Text.Trim();

            
            string query = @"SELECT * FROM Schedule WHERE class_id IN (SELECT class_id FROM Class WHERE class_name LIKE :searchTerm)
                            OR classroom_id IN (SELECT classroom_id FROM Classroom WHERE room_number LIKE :searchTerm)
                            OR session_id IN (SELECT session_id FROM ClassSession WHERE teacher_id IN (SELECT employee_id FROM Employee WHERE first_name LIKE :searchTerm OR last_name LIKE :searchTerm))";

            
            OracleParameter searchTermParameter = new OracleParameter(":searchTerm", OracleDbType.Varchar2);
            searchTermParameter.Value = "%" + searchTerm + "%"; 

            
            DataTable searchResults = SchoolDatabase.ExecuteQuery(query, new OracleParameter[] { searchTermParameter });

            
            scheduleDataGridView.DataSource = searchResults;
        }

        private void addScheduleButton_Click(object sender, EventArgs e) {
            AddScheduleForm addScheduleForm = new AddScheduleForm();
            DialogResult result = addScheduleForm.ShowDialog();
            if (result == DialogResult.OK) {
                LoadSchedule();
            }
        }

        private void deleteScheduleButton_Click(object sender, EventArgs e) {
            
            if (scheduleDataGridView.SelectedRows.Count == 0) {
                MessageBox.Show("Please select a schedule to delete.");
                return;
            }

            int scheduleId = Convert.ToInt32(scheduleDataGridView.SelectedRows[0].Cells["schedule_id"].Value);

            
            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete schedule with ID {scheduleId}?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.No) {
                return;
            }

            
            try {
                
                OracleParameter scheduleIdParameter = new OracleParameter("schedule_id", scheduleId);

                
                int rowsAffected = SchoolDatabase.ExecuteNonQuery(
                    "DELETE FROM Schedule WHERE schedule_id = :schedule_id",
                    new OracleParameter[] { scheduleIdParameter });

                if (rowsAffected > 0) {
                    MessageBox.Show("Schedule deleted successfully.");
                    
                    LoadSchedule();
                }
                else {
                    MessageBox.Show("An error occurred while deleting the schedule.");
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void editScheduleButton_Click(object sender, EventArgs e) {
            
            if (scheduleDataGridView.SelectedRows.Count == 0) {
                MessageBox.Show("Please select a schedule to edit.");
                return;
            }

            
            int selectedScheduleId = Convert.ToInt32(scheduleDataGridView.SelectedRows[0].Cells["schedule_id"].Value);

            
            EditScheduleForm editScheduleForm = new EditScheduleForm(selectedScheduleId);

            
            DialogResult result = editScheduleForm.ShowDialog();

            
            if (result == DialogResult.OK) {
                LoadSchedule();
            }
        }

    }
}