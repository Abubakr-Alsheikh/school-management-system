using System;
using System.Drawing;
using System.Windows.Forms;

namespace School_database_homework_try_2.Froms {
    partial class ClassListForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private DataGridView classDataGridView;
        private Button addButton;
        private Button editButton;
        private Button deleteButton;
        private TextBox searchTextBox;
        private Label searchLabel;
        private Button gradeButton; // Add the gradeButton variable
        private Button classroomButton;
        private Button classSessionButton;

        private Button manageSectionsButton;
        private Button subjectButton;
        private Button semesterButton;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.classDataGridView = new System.Windows.Forms.DataGridView();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.gradeButton = new System.Windows.Forms.Button();
            this.classroomButton = new System.Windows.Forms.Button();
            this.classSessionButton = new System.Windows.Forms.Button();
            this.manageSectionsButton = new System.Windows.Forms.Button();
            this.subjectButton = new System.Windows.Forms.Button();
            this.semesterButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.classDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // classDataGridView
            // 
            this.classDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.classDataGridView.Location = new System.Drawing.Point(12, 66);
            this.classDataGridView.Name = "classDataGridView";
            this.classDataGridView.RowHeadersWidth = 51;
            this.classDataGridView.RowTemplate.Height = 24;
            this.classDataGridView.Size = new System.Drawing.Size(776, 258);
            this.classDataGridView.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 360);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(117, 46);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add Class";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(139, 360);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(117, 46);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Edit Class";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(266, 360);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(117, 46);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete Class";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(12, 28);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(257, 24);
            this.searchTextBox.TabIndex = 4;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(12, 9);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(55, 17);
            this.searchLabel.TabIndex = 5;
            this.searchLabel.Text = "Search:";
            // 
            // gradeButton
            // 
            this.gradeButton.Location = new System.Drawing.Point(393, 360);
            this.gradeButton.Name = "gradeButton";
            this.gradeButton.Size = new System.Drawing.Size(117, 46);
            this.gradeButton.TabIndex = 6;
            this.gradeButton.Text = "Grade";
            this.gradeButton.UseVisualStyleBackColor = true;
            this.gradeButton.Click += new System.EventHandler(this.gradeButton_Click);
            // 
            // classroomButton
            // 
            this.classroomButton.Location = new System.Drawing.Point(520, 360);
            this.classroomButton.Name = "classroomButton";
            this.classroomButton.Size = new System.Drawing.Size(117, 46);
            this.classroomButton.TabIndex = 6;
            this.classroomButton.Text = "Classroom";
            this.classroomButton.UseVisualStyleBackColor = true;
            this.classroomButton.Click += new System.EventHandler(this.classroomButton_Click);
            // 
            // classSessionButton
            // 
            this.classSessionButton.Location = new System.Drawing.Point(647, 360);
            this.classSessionButton.Name = "classSessionButton";
            this.classSessionButton.Size = new System.Drawing.Size(117, 46);
            this.classSessionButton.TabIndex = 6;
            this.classSessionButton.Text = "Class Sessions";
            this.classSessionButton.UseVisualStyleBackColor = true;
            this.classSessionButton.Click += new System.EventHandler(this.classSessionButton_Click);
            // 
            // manageSectionsButton
            // 
            this.manageSectionsButton.Location = new System.Drawing.Point(647, 412);
            this.manageSectionsButton.Name = "manageSectionsButton";
            this.manageSectionsButton.Size = new System.Drawing.Size(117, 46);
            this.manageSectionsButton.TabIndex = 6;
            this.manageSectionsButton.Text = "Manage Sections";
            this.manageSectionsButton.UseVisualStyleBackColor = true;
            this.manageSectionsButton.Click += new System.EventHandler(this.manageSectionsButton_Click);
            // 
            // subjectButton
            // 
            this.subjectButton.Location = new System.Drawing.Point(520, 412);
            this.subjectButton.Name = "subjectButton";
            this.subjectButton.Size = new System.Drawing.Size(117, 46);
            this.subjectButton.TabIndex = 6;
            this.subjectButton.Text = "Subject";
            this.subjectButton.UseVisualStyleBackColor = true;
            this.subjectButton.Click += new System.EventHandler(this.subjectButton_Click);
            // 
            // semesterButton
            // 
            this.semesterButton.Location = new System.Drawing.Point(393, 412);
            this.semesterButton.Name = "semesterButton";
            this.semesterButton.Size = new System.Drawing.Size(117, 46);
            this.semesterButton.TabIndex = 0;
            this.semesterButton.Text = "Manage Semesters";
            this.semesterButton.Click += new System.EventHandler(this.semesterButton_Click);
            // 
            // ClassListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 467);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.classDataGridView);
            this.Controls.Add(this.gradeButton);
            this.Controls.Add(this.classroomButton);
            this.Controls.Add(this.classSessionButton);
            this.Controls.Add(this.manageSectionsButton);
            this.Controls.Add(this.subjectButton);
            this.Controls.Add(this.semesterButton);
            this.Name = "ClassListForm";
            this.Text = "Class List";
            this.Load += new System.EventHandler(this.ClassListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.classDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion
    }
}