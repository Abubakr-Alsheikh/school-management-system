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
public partial class EditScheduleForm : Form {
    private int scheduleId;

    public EditScheduleForm(int scheduleId) {
        InitializeComponent();
        this.scheduleId = scheduleId;
        LoadScheduleData();
        LoadClassData();
        LoadClassroomData();
        LoadClassSessionData(); 
    }

    private void LoadScheduleData() {
            
        string query = "SELECT * FROM Schedule WHERE schedule_id = :scheduleId";
        OracleParameter parameter = new OracleParameter("scheduleId", OracleDbType.Int32, scheduleId, ParameterDirection.Input);

        DataTable scheduleData = SchoolDatabase.ExecuteQuery(query, new OracleParameter[] { parameter });

        if (scheduleData.Rows.Count > 0) {
            DataRow row = scheduleData.Rows[0];
            classComboBox.SelectedValue = row["class_id"];
            classroomComboBox.SelectedValue = row["classroom_id"];
            classSessionComboBox.SelectedValue = row["session_id"]; 
            dayOfWeekComboBox.SelectedItem = row["day_of_week"];
            startTimePicker.Value = DateTime.Parse(row["start_time"].ToString());
            endTimePicker.Value = DateTime.Parse(row["end_time"].ToString());
        }
        else {
            MessageBox.Show("Schedule not found.");
        }
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

    private void updateScheduleButton_Click(object sender, EventArgs e) {
            
        if (classComboBox.SelectedValue == null || classroomComboBox.SelectedValue == null ||
            classSessionComboBox.SelectedValue == null || dayOfWeekComboBox.SelectedItem == null) {
            MessageBox.Show("Please select all required values.");
            return;
        }

            
        Schedule updatedSchedule = new Schedule {
            ScheduleId = scheduleId, 
            ClassId = Convert.ToInt32(classComboBox.SelectedValue),
            ClassroomId = Convert.ToInt32(classroomComboBox.SelectedValue),
            SessionId = Convert.ToInt32(classSessionComboBox.SelectedValue), 
            DayOfTheWeek = dayOfWeekComboBox.SelectedItem.ToString(),
            StartTime = startTimePicker.Value.TimeOfDay,
            EndTime = endTimePicker.Value.TimeOfDay
        };

        string updateQuery = @"UPDATE Schedule 
                        SET class_id = :classId, 
                            classroom_id = :classroomId, 
                            session_id = :sessionId, 
                            day_of_week = :dayOfWeek, 
                            start_time = :startTime, 
                            end_time = :endTime 
                        WHERE schedule_id = :scheduleId"; 

            
        DateTime startTime = startTimePicker.Value.Date.Add(updatedSchedule.StartTime); 
        DateTime endTime = endTimePicker.Value.Date.Add(updatedSchedule.EndTime); 

        OracleParameter[] parameters = new OracleParameter[]
        {
    new OracleParameter("classId", OracleDbType.Int32, updatedSchedule.ClassId, ParameterDirection.Input),
    new OracleParameter("classroomId", OracleDbType.Int32, updatedSchedule.ClassroomId, ParameterDirection.Input),
    new OracleParameter("sessionId", OracleDbType.Int32, updatedSchedule.SessionId, ParameterDirection.Input), 
    new OracleParameter("dayOfWeek", OracleDbType.Varchar2, updatedSchedule.DayOfTheWeek, ParameterDirection.Input),
    new OracleParameter("startTime", OracleDbType.Date, startTime, ParameterDirection.Input), 
    new OracleParameter("endTime", OracleDbType.Date, endTime, ParameterDirection.Input), 
    new OracleParameter("scheduleId", OracleDbType.Int32, updatedSchedule.ScheduleId, ParameterDirection.Input) 
        };

        int rowsAffected = SchoolDatabase.ExecuteNonQuery(updateQuery, parameters);

            
        if (rowsAffected > 0) {
            MessageBox.Show("Schedule updated successfully!");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        else {
            MessageBox.Show("An error occurred while updating the schedule.");
        }
    }

    private void cancelScheduleButton_Click(object sender, EventArgs e) {
        this.Close();
    }
}
}