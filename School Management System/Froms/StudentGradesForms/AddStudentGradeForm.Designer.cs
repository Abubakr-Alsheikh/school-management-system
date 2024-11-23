using System.Windows.Forms;

namespace School_database_homework_try_2.Froms.StudentGradesForms {
    partial class AddStudentGradeForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.studentComboBox = new System.Windows.Forms.ComboBox();
            this.classSessionComboBox = new System.Windows.Forms.ComboBox();
            this.gradeComponentComboBox = new System.Windows.Forms.ComboBox();
            this.scoreTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.studentLabel = new System.Windows.Forms.Label();
            this.classSessionLabel = new System.Windows.Forms.Label();
            this.gradeComponentLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // studentComboBox
            // 
            this.studentComboBox.FormattingEnabled = true;
            this.studentComboBox.Location = new System.Drawing.Point(169, 27);
            this.studentComboBox.Name = "studentComboBox";
            this.studentComboBox.Size = new System.Drawing.Size(200, 24);
            this.studentComboBox.TabIndex = 0;
            // 
            // classSessionComboBox
            // 
            this.classSessionComboBox.FormattingEnabled = true;
            this.classSessionComboBox.Location = new System.Drawing.Point(169, 67);
            this.classSessionComboBox.Name = "classSessionComboBox";
            this.classSessionComboBox.Size = new System.Drawing.Size(200, 24);
            this.classSessionComboBox.TabIndex = 1;
            // 
            // gradeComponentComboBox
            // 
            this.gradeComponentComboBox.FormattingEnabled = true;
            this.gradeComponentComboBox.Location = new System.Drawing.Point(169, 107);
            this.gradeComponentComboBox.Name = "gradeComponentComboBox";
            this.gradeComponentComboBox.Size = new System.Drawing.Size(200, 24);
            this.gradeComponentComboBox.TabIndex = 2;
            // 
            // scoreTextBox
            // 
            this.scoreTextBox.Location = new System.Drawing.Point(169, 147);
            this.scoreTextBox.Name = "scoreTextBox";
            this.scoreTextBox.Size = new System.Drawing.Size(200, 24);
            this.scoreTextBox.TabIndex = 3;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(169, 199);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(93, 35);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(280, 199);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(89, 35);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // studentLabel
            // 
            this.studentLabel.AutoSize = true;
            this.studentLabel.Location = new System.Drawing.Point(42, 30);
            this.studentLabel.Name = "studentLabel";
            this.studentLabel.Size = new System.Drawing.Size(62, 17);
            this.studentLabel.TabIndex = 6;
            this.studentLabel.Text = "Student:";
            // 
            // classSessionLabel
            // 
            this.classSessionLabel.AutoSize = true;
            this.classSessionLabel.Location = new System.Drawing.Point(42, 70);
            this.classSessionLabel.Name = "classSessionLabel";
            this.classSessionLabel.Size = new System.Drawing.Size(92, 17);
            this.classSessionLabel.TabIndex = 7;
            this.classSessionLabel.Text = "Class Session:";
            // 
            // gradeComponentLabel
            // 
            this.gradeComponentLabel.AutoSize = true;
            this.gradeComponentLabel.Location = new System.Drawing.Point(42, 110);
            this.gradeComponentLabel.Name = "gradeComponentLabel";
            this.gradeComponentLabel.Size = new System.Drawing.Size(126, 17);
            this.gradeComponentLabel.TabIndex = 8;
            this.gradeComponentLabel.Text = "Grade Component:";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(42, 150);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(48, 17);
            this.scoreLabel.TabIndex = 9;
            this.scoreLabel.Text = "Score:";
            // 
            // AddStudentGradeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 282);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.gradeComponentLabel);
            this.Controls.Add(this.classSessionLabel);
            this.Controls.Add(this.studentLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.scoreTextBox);
            this.Controls.Add(this.gradeComponentComboBox);
            this.Controls.Add(this.classSessionComboBox);
            this.Controls.Add(this.studentComboBox);
            this.Name = "AddStudentGradeForm";
            this.Text = "Add Student Grade";
            this.Load += new System.EventHandler(this.AddStudentGradeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private ComboBox studentComboBox;
        private ComboBox classSessionComboBox;
        private ComboBox gradeComponentComboBox;
        private TextBox scoreTextBox;
        private Button saveButton;
        private Button cancelButton;
        private Label studentLabel;
        private Label classSessionLabel;
        private Label gradeComponentLabel;
        private Label scoreLabel;
    }

    #endregion
}
