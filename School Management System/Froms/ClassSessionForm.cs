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
public partial class ClassSessionForm : Form {
    public ClassSessionForm() {
        InitializeComponent();
        LoadClassSessions();
        LoadSubjects();
        LoadTeachers();
        LoadSemesters();
        LoadClasses();
    }

        
    private void LoadClassSessions() {
            
        DataTable sessionData = SchoolDatabase.ExecuteQuery(
            @"SELECT 
                cs.session_id,
                s.subject_name AS Subject,
                e.first_name || ' ' || e.last_name AS Teacher,
                sem.semester_name AS Semester,
                c.class_name AS Class
            FROM ClassSession cs
            JOIN Subject s ON cs.subject_id = s.subject_id
            JOIN Employee e ON cs.teacher_id = e.employee_id
            JOIN Semester sem ON cs.semester_id = sem.semester_id
            JOIN Class c ON cs.class_id = c.class_id");

        classSessionDataGridView.DataSource = sessionData;

            
        classSessionDataGridView.Columns["session_id"].HeaderText = "Session ID";
        classSessionDataGridView.Columns["Subject"].HeaderText = "Subject";
        classSessionDataGridView.Columns["Teacher"].HeaderText = "Teacher";
        classSessionDataGridView.Columns["Semester"].HeaderText = "Semester";
        classSessionDataGridView.Columns["Class"].HeaderText = "Class";
    }

    private void LoadSubjects() {
        DataTable subjectData = SchoolDatabase.ExecuteQuery("SELECT * FROM Subject");
        subjectComboBox.DataSource = subjectData;
        subjectComboBox.DisplayMember = "subject_name"; 
        subjectComboBox.ValueMember = "subject_id"; 
    }

    private void LoadTeachers() {
            
        DataTable teacherData = SchoolDatabase.ExecuteQuery(
            @"SELECT e.employee_id, e.first_name || ' ' || e.last_name AS EmployeeName 
                FROM Employee e
                INNER JOIN EmployeeRole er ON e.employee_id = er.employee_id
                INNER JOIN Role r ON er.role_id = r.role_id
                WHERE r.role_name = 'Teacher'");

        teacherComboBox.DataSource = teacherData;
        teacherComboBox.DisplayMember = "EmployeeName"; 
        teacherComboBox.ValueMember = "employee_id"; 
    }

    private void LoadSemesters() {
        DataTable semesterData = SchoolDatabase.ExecuteQuery("SELECT * FROM Semester");
        semesterComboBox.DataSource = semesterData;
        semesterComboBox.DisplayMember = "semester_name"; 
        semesterComboBox.ValueMember = "semester_id"; 
    }

    private void LoadClasses() {
        DataTable classData = SchoolDatabase.ExecuteQuery("SELECT * FROM Class");
        classComboBox.DataSource = classData;
        classComboBox.DisplayMember = "class_name"; 
        classComboBox.ValueMember = "class_id"; 
    }

    private void addSessionButton_Click(object sender, EventArgs e) {
            
        int subjectId = Convert.ToInt32(subjectComboBox.SelectedValue);
        int teacherId = Convert.ToInt32(teacherComboBox.SelectedValue);
        int semesterId = Convert.ToInt32(semesterComboBox.SelectedValue);
        int classId = Convert.ToInt32(classComboBox.SelectedValue);

            
        string insertQuery = @"INSERT INTO ClassSession (subject_id, teacher_id, semester_id, class_id) 
                        VALUES (:subjectId, :teacherId, :semesterId, :classId)";

        OracleParameter[] parameters = new OracleParameter[]
        {
            new OracleParameter("subjectId", subjectId),
            new OracleParameter("teacherId", teacherId),
            new OracleParameter("semesterId", semesterId),
            new OracleParameter("classId", classId)
        };

        int rowsAffected = SchoolDatabase.ExecuteNonQuery(insertQuery, parameters);

        if (rowsAffected > 0) {
            MessageBox.Show("Class session added successfully.");
            LoadClassSessions(); 
        }
        else {
            MessageBox.Show("An error occurred while adding the class session.");
        }
    }

    private void deleteSessionButton_Click(object sender, EventArgs e) {
            
        if (classSessionDataGridView.SelectedRows.Count == 0) {
            MessageBox.Show("Please select a class session to delete.");
            return;
        }

        int sessionId = Convert.ToInt32(classSessionDataGridView.SelectedRows[0].Cells["session_id"].Value);

            
        DialogResult result = MessageBox.Show(
            $"Are you sure you want to delete class session with ID {sessionId}?",
            "Confirm Deletion",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

        if (result == DialogResult.No) {
            return;
        }

            
        string deleteQuery = "DELETE FROM ClassSession WHERE session_id = :sessionId";
        OracleParameter sessionIdParameter = new OracleParameter(":sessionId", sessionId);
        int rowsAffected = SchoolDatabase.ExecuteNonQuery(deleteQuery, new OracleParameter[] { sessionIdParameter });

        if (rowsAffected > 0) {
            MessageBox.Show("Class session deleted successfully.");
            LoadClassSessions(); 
        }
        else {
            MessageBox.Show("An error occurred while deleting the class session.");
        }
    }

    private void ClassSessionForm_Load(object sender, EventArgs e) {

    }
}
}