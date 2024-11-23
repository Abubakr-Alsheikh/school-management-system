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
public partial class AddStudentGradeForm : Form {
    public AddStudentGradeForm() {
        InitializeComponent();
        LoadStudents();
        LoadClassSessions();
        LoadGradeComponents();
    }

    private void LoadStudents() {
            
        DataTable students = SchoolDatabase.ExecuteQuery("SELECT student_id, first_name || ' ' || last_name AS student_name FROM Student");

            
        studentComboBox.DataSource = students;
        studentComboBox.DisplayMember = "student_name";
        studentComboBox.ValueMember = "student_id";
    }

    private void LoadClassSessions() {
            
        DataTable classSessions = SchoolDatabase.ExecuteQuery(
            "SELECT cs.session_id, c.class_name " +
            "FROM ClassSession cs " +
            "JOIN Class c ON cs.class_id = c.class_id");

            
        classSessionComboBox.DataSource = classSessions;
        classSessionComboBox.DisplayMember = "class_name";
        classSessionComboBox.ValueMember = "session_id";
    }

    private void LoadGradeComponents() {
            
        DataTable gradeComponents = SchoolDatabase.ExecuteQuery("SELECT component_id, component_name FROM GradeComponent");

            
        gradeComponentComboBox.DataSource = gradeComponents;
        gradeComponentComboBox.DisplayMember = "component_name";
        gradeComponentComboBox.ValueMember = "component_id";
    }

    private void saveButton_Click(object sender, EventArgs e) {
            
        if (string.IsNullOrEmpty(scoreTextBox.Text)) {
            MessageBox.Show("Please enter a score.");
            return;
        }

        if (!decimal.TryParse(scoreTextBox.Text, out decimal score)) {
            MessageBox.Show("Please enter a valid numeric score.");
            return;
        }

            
        int studentId = Convert.ToInt32(studentComboBox.SelectedValue);
        int classSessionId = Convert.ToInt32(classSessionComboBox.SelectedValue);
        int gradeComponentId = Convert.ToInt32(gradeComponentComboBox.SelectedValue);

            
        string checkEnrollmentQuery = "SELECT 1 FROM Enrollment WHERE student_id = :studentId AND session_id = :classSessionId";
        OracleParameter[] checkEnrollmentParameters = new OracleParameter[]
        {
            new OracleParameter("studentId", OracleDbType.Int32, studentId, ParameterDirection.Input),
            new OracleParameter("classSessionId", OracleDbType.Int32, classSessionId, ParameterDirection.Input)
        };

        DataTable enrollmentCheck = SchoolDatabase.ExecuteQuery(checkEnrollmentQuery, checkEnrollmentParameters);

        if (enrollmentCheck.Rows.Count == 0) {
            MessageBox.Show("The student is not enrolled in this class session. Please enroll the student first.");
            return;
        }

            
        string getEnrollmentIdQuery = "SELECT enrollment_id FROM Enrollment WHERE student_id = :studentId AND session_id = :classSessionId";
        OracleParameter[] getEnrollmentIdParameters = new OracleParameter[]
        {
            new OracleParameter("studentId", OracleDbType.Int32, studentId, ParameterDirection.Input),
            new OracleParameter("classSessionId", OracleDbType.Int32, classSessionId, ParameterDirection.Input)
        };

        DataTable enrollmentIdData = SchoolDatabase.ExecuteQuery(getEnrollmentIdQuery, getEnrollmentIdParameters);

        if (enrollmentIdData.Rows.Count == 0) {
            MessageBox.Show("Error retrieving enrollment ID.");
            return;
        }

        int enrollmentId = Convert.ToInt32(enrollmentIdData.Rows[0]["enrollment_id"]);

            
        string insertQuery = @"INSERT INTO StudentGrade (enrollment_id, component_id, score) VALUES (:enrollmentId, :gradeComponentId, :score)";
        OracleParameter[] parameters = new OracleParameter[]
        {
            new OracleParameter("enrollmentId", OracleDbType.Int32, enrollmentId, ParameterDirection.Input),
            new OracleParameter("gradeComponentId", OracleDbType.Int32, gradeComponentId, ParameterDirection.Input),
            new OracleParameter("score", OracleDbType.Decimal, score, ParameterDirection.Input)
        };

        int rowsAffected = SchoolDatabase.ExecuteNonQuery(insertQuery, parameters);

        if (rowsAffected > 0) {
            MessageBox.Show("Grade added successfully!");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        else {
            MessageBox.Show("An error occurred while adding the grade.");
        }
    }

    private void cancelButton_Click(object sender, EventArgs e) {
        this.Close();
    }

    private void AddStudentGradeForm_Load(object sender, EventArgs e) {

    }
}
}
