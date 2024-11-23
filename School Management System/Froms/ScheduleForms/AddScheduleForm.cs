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

namespace School_database_homework_try_2.Froms.ScheduleForms {
    public partial class AddScheduleForm : Form {
        public AddScheduleForm() {
            InitializeComponent();
            LoadClassData();
            LoadClassroomData();
            LoadClassSessionData(); 
        }

        private void LoadClassData() {
            DataTable classData = SchoolDatabase.ExecuteQuery("SELECT * FROM Class");
            classComboBox.DataSource = classData;
            classComboBox.DisplayMember = "class_name";
            classComboBox.ValueMember = "class_id";
        }

        private void LoadClassroomData() {
            DataTable classroomData = SchoolDatabase.ExecuteQuery("SELECT * FROM Classroom");
            classroomComboBox.DataSource = classroomData;
            classroomComboBox.DisplayMember = "room_number";
            classroomComboBox.ValueMember = "classroom_id";
        }

        private void LoadClassSessionData() {
            DataTable classSessionData = SchoolDatabase.ExecuteQuery(@"
                SELECT 
                    cs.session_id,
                    (c.class_name || ' - ' || s.subject_name || ' (' || e.first_name || ' ' || e.last_name || ')' || ' (Semester ' || se.semester_name || ')') AS session_details
                FROM 
                    ClassSession cs
                JOIN 
                    Class c ON cs.class_id = c.class_id
                JOIN 
                    Subject s ON cs.subject_id = s.subject_id
                JOIN 
                    Employee e ON cs.teacher_id = e.employee_id
                JOIN 
                    Semester se ON cs.semester_id = se.semester_id
            ");

            classSessionComboBox.DataSource = classSessionData;
            classSessionComboBox.DisplayMember = "session_details"; 
            classSessionComboBox.ValueMember = "session_id";
        }

        private void saveScheduleButton_Click(object sender, EventArgs e) {
            
            if (classComboBox.SelectedValue == null || classroomComboBox.SelectedValue == null ||
                classSessionComboBox.SelectedValue == null || dayOfWeekComboBox.SelectedItem == null) {
                MessageBox.Show("Please select all required values.");
                return;
            }

            
            Schedule newSchedule = new Schedule {
                ClassId = Convert.ToInt32(classComboBox.SelectedValue),
                ClassroomId = Convert.ToInt32(classroomComboBox.SelectedValue),
                SessionId = Convert.ToInt32(classSessionComboBox.SelectedValue), 
                DayOfTheWeek = dayOfWeekComboBox.SelectedItem.ToString(),
                StartTime = startTimePicker.Value.TimeOfDay, 
                EndTime = endTimePicker.Value.TimeOfDay    
            };

            
            string insertQuery = @"INSERT INTO Schedule (class_id, classroom_id, session_id, day_of_week, start_time, end_time)
                           VALUES (:classId, :classroomId, :sessionId, :dayOfWeek, :startTime, :endTime)";

            
            DateTime startTime = startTimePicker.Value.Date.Add(newSchedule.StartTime); 
            DateTime endTime = endTimePicker.Value.Date.Add(newSchedule.EndTime); 

            OracleParameter[] parameters = new OracleParameter[]
            {
        new OracleParameter("classId", OracleDbType.Int32, newSchedule.ClassId, ParameterDirection.Input),
        new OracleParameter("classroomId", OracleDbType.Int32, newSchedule.ClassroomId, ParameterDirection.Input),
        new OracleParameter("sessionId", OracleDbType.Int32, newSchedule.SessionId, ParameterDirection.Input), 
        new OracleParameter("dayOfWeek", OracleDbType.Varchar2, newSchedule.DayOfTheWeek, ParameterDirection.Input),
        new OracleParameter("startTime", OracleDbType.Date, startTime, ParameterDirection.Input), 
        new OracleParameter("endTime", OracleDbType.Date, endTime, ParameterDirection.Input) 
            };

            int rowsAffected = SchoolDatabase.ExecuteNonQuery(insertQuery, parameters);

            
            if (rowsAffected > 0) {
                MessageBox.Show("Schedule added successfully!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else {
                MessageBox.Show("An error occurred while adding the schedule.");
            }
        }

        private void cancelScheduleButton_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}