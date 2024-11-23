using Oracle.ManagedDataAccess.Client;
using School_database_homework_try_2.Froms;
using School_database_homework_try_2.Froms.ScheduleForms;
using School_database_homework_try_2.Froms.StudentGradesForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_database_homework_try_2 {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            throw new NotImplementedException();
        }

        private void systemSettingsToolStripMenuItem_Click(object sender, EventArgs e) {
            throw new NotImplementedException();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e) {
            throw new NotImplementedException();
        }

        private void enrollmentToolStripMenuItem_Click(object sender, EventArgs e) {
            //subFormContainerPanel.Controls.Clear();
            //// Hide the Welcome Screen
            //welcomeScreenPanel.Visible = false;

            //// Create an instance of the Employee List sub-form
            //ScheduleListForm scheduleListForm = new ScheduleListForm();

            //// Show the Employee List sub-form in the Main Area
            //scheduleListForm.TopLevel = false; // Make it a child form
            //scheduleListForm.FormBorderStyle = FormBorderStyle.None; // Remove border
            //subFormContainerPanel.Controls.Add(scheduleListForm); // Add to the Sub-Form Container
            //scheduleListForm.Show();
        }

        private void scheduleToolStripMenuItem_Click(object sender, EventArgs e) {
            subFormContainerPanel.Controls.Clear();
            // Hide the Welcome Screen
            welcomeScreenPanel.Visible = false;

            // Create an instance of the Employee List sub-form
            ScheduleListForm scheduleListForm = new ScheduleListForm();

            // Show the Employee List sub-form in the Main Area
            scheduleListForm.TopLevel = false; // Make it a child form
            scheduleListForm.FormBorderStyle = FormBorderStyle.None; // Remove border
            subFormContainerPanel.Controls.Add(scheduleListForm); // Add to the Sub-Form Container
            scheduleListForm.Show();
        }

        private void subjectsToolStripMenuItem_Click(object sender, EventArgs e) {
        }

        private void classesToolStripMenuItem_Click(object sender, EventArgs e) {
            subFormContainerPanel.Controls.Clear();
            // Hide the Welcome Screen
            welcomeScreenPanel.Visible = false;

            // Create an instance of the Employee List sub-form
            ClassListForm studentListForm = new ClassListForm();

            // Show the Employee List sub-form in the Main Area
            studentListForm.TopLevel = false; // Make it a child form
            studentListForm.FormBorderStyle = FormBorderStyle.None; // Remove border
            subFormContainerPanel.Controls.Add(studentListForm); // Add to the Sub-Form Container
            studentListForm.Show();
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e) {
            subFormContainerPanel.Controls.Clear();
            // Hide the Welcome Screen
            welcomeScreenPanel.Visible = false;

            // Create an instance of the Employee List sub-form
            StudentListForm studentListForm = new StudentListForm();

            // Show the Employee List sub-form in the Main Area
            studentListForm.TopLevel = false; // Make it a child form
            studentListForm.FormBorderStyle = FormBorderStyle.None; // Remove border
            subFormContainerPanel.Controls.Add(studentListForm); // Add to the Sub-Form Container
            studentListForm.Show();
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e) {
            subFormContainerPanel.Controls.Clear();
            
            welcomeScreenPanel.Visible = false;

            EmployeeListForm employeeListForm = new EmployeeListForm();
            
            employeeListForm.TopLevel = false; 
            employeeListForm.FormBorderStyle = FormBorderStyle.None; 
            subFormContainerPanel.Controls.Add(employeeListForm); 
            employeeListForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            throw new NotImplementedException();
        }


        private void gradesToolStripMenuItem_Click(object sender, EventArgs e) {
            subFormContainerPanel.Controls.Clear();
            // Hide the Welcome Screen
            welcomeScreenPanel.Visible = false;

            // Create an instance of the Employee List sub-form
            StudentGradesForm studentGradesForm = new StudentGradesForm();

            // Show the Employee List sub-form in the Main Area
            studentGradesForm.TopLevel = false; // Make it a child form
            studentGradesForm.FormBorderStyle = FormBorderStyle.None; // Remove border
            subFormContainerPanel.Controls.Add(studentGradesForm); // Add to the Sub-Form Container
            studentGradesForm.Show();
        }

    }
}
