using System.Windows.Forms;

namespace School_database_homework_try_2.Froms.StudentGradesForms {
    partial class StudentGradesForm {
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
            this.gradesDataGridView = new System.Windows.Forms.DataGridView();
            this.studentComboBox = new System.Windows.Forms.ComboBox();
            this.classSessionComboBox = new System.Windows.Forms.ComboBox();
            this.addGradeButton = new System.Windows.Forms.Button();
            this.editGradeButton = new System.Windows.Forms.Button();
            this.deleteGradeButton = new System.Windows.Forms.Button();
            this.studentLabel = new System.Windows.Forms.Label();
            this.classSessionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gradesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // gradesDataGridView
            // 
            this.gradesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gradesDataGridView.Location = new System.Drawing.Point(12, 98);
            this.gradesDataGridView.Name = "gradesDataGridView";
            this.gradesDataGridView.RowHeadersWidth = 51;
            this.gradesDataGridView.RowTemplate.Height = 24;
            this.gradesDataGridView.Size = new System.Drawing.Size(776, 258);
            this.gradesDataGridView.TabIndex = 0;
            // 
            // studentComboBox
            // 
            this.studentComboBox.FormattingEnabled = true;
            this.studentComboBox.Location = new System.Drawing.Point(12, 42);
            this.studentComboBox.Name = "studentComboBox";
            this.studentComboBox.Size = new System.Drawing.Size(200, 24);
            this.studentComboBox.TabIndex = 1;
            this.studentComboBox.SelectedIndexChanged += new System.EventHandler(this.studentComboBox_SelectedIndexChanged);
            // 
            // classSessionComboBox
            // 
            this.classSessionComboBox.FormattingEnabled = true;
            this.classSessionComboBox.Location = new System.Drawing.Point(250, 42);
            this.classSessionComboBox.Name = "classSessionComboBox";
            this.classSessionComboBox.Size = new System.Drawing.Size(200, 24);
            this.classSessionComboBox.TabIndex = 2;
            this.classSessionComboBox.SelectedIndexChanged += new System.EventHandler(this.classSessionComboBox_SelectedIndexChanged);
            // 
            // addGradeButton
            // 
            this.addGradeButton.Location = new System.Drawing.Point(12, 391);
            this.addGradeButton.Name = "addGradeButton";
            this.addGradeButton.Size = new System.Drawing.Size(117, 46);
            this.addGradeButton.TabIndex = 3;
            this.addGradeButton.Text = "Add Grade";
            this.addGradeButton.UseVisualStyleBackColor = true;
            this.addGradeButton.Click += new System.EventHandler(this.addGradeButton_Click);
            // 
            // editGradeButton
            // 
            this.editGradeButton.Location = new System.Drawing.Point(139, 391);
            this.editGradeButton.Name = "editGradeButton";
            this.editGradeButton.Size = new System.Drawing.Size(117, 46);
            this.editGradeButton.TabIndex = 4;
            this.editGradeButton.Text = "Edit Grade";
            this.editGradeButton.UseVisualStyleBackColor = true;
            this.editGradeButton.Click += new System.EventHandler(this.editGradeButton_Click);
            // 
            // deleteGradeButton
            // 
            this.deleteGradeButton.Location = new System.Drawing.Point(266, 391);
            this.deleteGradeButton.Name = "deleteGradeButton";
            this.deleteGradeButton.Size = new System.Drawing.Size(117, 46);
            this.deleteGradeButton.TabIndex = 5;
            this.deleteGradeButton.Text = "Delete Grade";
            this.deleteGradeButton.UseVisualStyleBackColor = true;
            this.deleteGradeButton.Click += new System.EventHandler(this.deleteGradeButton_Click);
            // 
            // studentLabel
            // 
            this.studentLabel.AutoSize = true;
            this.studentLabel.Location = new System.Drawing.Point(12, 19);
            this.studentLabel.Name = "studentLabel";
            this.studentLabel.Size = new System.Drawing.Size(63, 17);
            this.studentLabel.TabIndex = 6;
            this.studentLabel.Text = "Student:";
            // 
            // classSessionLabel
            // 
            this.classSessionLabel.AutoSize = true;
            this.classSessionLabel.Location = new System.Drawing.Point(250, 19);
            this.classSessionLabel.Name = "classSessionLabel";
            this.classSessionLabel.Size = new System.Drawing.Size(105, 17);
            this.classSessionLabel.TabIndex = 7;
            this.classSessionLabel.Text = "Class Session:";
            // Add the manageComponentsButton
            this.manageComponentsButton = new System.Windows.Forms.Button();
            this.manageComponentsButton.Location = new System.Drawing.Point(403, 391); // Adjust location as needed
            this.manageComponentsButton.Name = "manageComponentsButton";
            this.manageComponentsButton.Size = new System.Drawing.Size(117, 46);
            this.manageComponentsButton.TabIndex = 8;
            this.manageComponentsButton.Text = "Manage Components";
            this.manageComponentsButton.UseVisualStyleBackColor = true;
            this.manageComponentsButton.Click += new System.EventHandler(this.manageComponentsButton_Click);

            // 
            // StudentGradesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.classSessionLabel);
            this.Controls.Add(this.studentLabel);
            this.Controls.Add(this.deleteGradeButton);
            this.Controls.Add(this.editGradeButton);
            this.Controls.Add(this.addGradeButton);
            this.Controls.Add(this.classSessionComboBox);
            this.Controls.Add(this.studentComboBox);
            this.Controls.Add(this.gradesDataGridView);
            this.Controls.Add(this.manageComponentsButton);
            this.Name = "StudentGradesForm";
            this.Text = "Student Grades";
            this.Load += new System.EventHandler(this.StudentGradesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gradesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // ... (Rest of your existing code) ...
        #endregion

        private DataGridView gradesDataGridView;
        private ComboBox studentComboBox;
        private ComboBox classSessionComboBox;
        private Button addGradeButton;
        private Button editGradeButton;
        private Button deleteGradeButton;
        private Label studentLabel;
        private Label classSessionLabel;
        private Button manageComponentsButton;
    }
}