namespace School_database_homework_try_2.Froms {
    partial class ClassSessionForm {
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
            this.classSessionDataGridView = new System.Windows.Forms.DataGridView();
            this.addSessionButton = new System.Windows.Forms.Button();
            this.subjectLabel = new System.Windows.Forms.Label();
            this.subjectComboBox = new System.Windows.Forms.ComboBox();
            this.teacherLabel = new System.Windows.Forms.Label();
            this.teacherComboBox = new System.Windows.Forms.ComboBox();
            this.semesterLabel = new System.Windows.Forms.Label();
            this.semesterComboBox = new System.Windows.Forms.ComboBox();
            this.classLabel = new System.Windows.Forms.Label();
            this.classComboBox = new System.Windows.Forms.ComboBox();
            this.deleteSessionButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.classSessionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // classSessionDataGridView
            // 
            this.classSessionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.classSessionDataGridView.Location = new System.Drawing.Point(12, 133);
            this.classSessionDataGridView.Name = "classSessionDataGridView";
            this.classSessionDataGridView.RowHeadersWidth = 51;
            this.classSessionDataGridView.RowTemplate.Height = 24;
            this.classSessionDataGridView.Size = new System.Drawing.Size(776, 258);
            this.classSessionDataGridView.TabIndex = 0;
            // 
            // addSessionButton
            // 
            this.addSessionButton.Location = new System.Drawing.Point(12, 415);
            this.addSessionButton.Name = "addSessionButton";
            this.addSessionButton.Size = new System.Drawing.Size(117, 46);
            this.addSessionButton.TabIndex = 1;
            this.addSessionButton.Text = "Add Session";
            this.addSessionButton.UseVisualStyleBackColor = true;
            this.addSessionButton.Click += new System.EventHandler(this.addSessionButton_Click);
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Location = new System.Drawing.Point(12, 9);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(60, 17);
            this.subjectLabel.TabIndex = 2;
            this.subjectLabel.Text = "Subject:";
            // 
            // subjectComboBox
            // 
            this.subjectComboBox.FormattingEnabled = true;
            this.subjectComboBox.Location = new System.Drawing.Point(12, 28);
            this.subjectComboBox.Name = "subjectComboBox";
            this.subjectComboBox.Size = new System.Drawing.Size(150, 24);
            this.subjectComboBox.TabIndex = 3;
            // 
            // teacherLabel
            // 
            this.teacherLabel.AutoSize = true;
            this.teacherLabel.Location = new System.Drawing.Point(12, 66);
            this.teacherLabel.Name = "teacherLabel";
            this.teacherLabel.Size = new System.Drawing.Size(62, 17);
            this.teacherLabel.TabIndex = 4;
            this.teacherLabel.Text = "Teacher:";
            // 
            // teacherComboBox
            // 
            this.teacherComboBox.FormattingEnabled = true;
            this.teacherComboBox.Location = new System.Drawing.Point(12, 85);
            this.teacherComboBox.Name = "teacherComboBox";
            this.teacherComboBox.Size = new System.Drawing.Size(150, 24);
            this.teacherComboBox.TabIndex = 5;
            // 
            // semesterLabel
            // 
            this.semesterLabel.AutoSize = true;
            this.semesterLabel.Location = new System.Drawing.Point(197, 9);
            this.semesterLabel.Name = "semesterLabel";
            this.semesterLabel.Size = new System.Drawing.Size(70, 17);
            this.semesterLabel.TabIndex = 6;
            this.semesterLabel.Text = "Semester:";
            // 
            // semesterComboBox
            // 
            this.semesterComboBox.FormattingEnabled = true;
            this.semesterComboBox.Location = new System.Drawing.Point(197, 28);
            this.semesterComboBox.Name = "semesterComboBox";
            this.semesterComboBox.Size = new System.Drawing.Size(150, 24);
            this.semesterComboBox.TabIndex = 7;
            // 
            // classLabel
            // 
            this.classLabel.AutoSize = true;
            this.classLabel.Location = new System.Drawing.Point(197, 66);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(43, 17);
            this.classLabel.TabIndex = 8;
            this.classLabel.Text = "Class:";
            // 
            // classComboBox
            // 
            this.classComboBox.FormattingEnabled = true;
            this.classComboBox.Location = new System.Drawing.Point(197, 85);
            this.classComboBox.Name = "classComboBox";
            this.classComboBox.Size = new System.Drawing.Size(150, 24);
            this.classComboBox.TabIndex = 9;
            // 
            // deleteSessionButton
            // 
            this.deleteSessionButton.Location = new System.Drawing.Point(150, 415);
            this.deleteSessionButton.Name = "deleteSessionButton";
            this.deleteSessionButton.Size = new System.Drawing.Size(117, 46);
            this.deleteSessionButton.TabIndex = 10;
            this.deleteSessionButton.Text = "Delete Session";
            this.deleteSessionButton.UseVisualStyleBackColor = true;
            this.deleteSessionButton.Click += new System.EventHandler(this.deleteSessionButton_Click);
            // 
            // ClassSessionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 483);
            this.Controls.Add(this.deleteSessionButton);
            this.Controls.Add(this.classComboBox);
            this.Controls.Add(this.classLabel);
            this.Controls.Add(this.semesterComboBox);
            this.Controls.Add(this.semesterLabel);
            this.Controls.Add(this.teacherComboBox);
            this.Controls.Add(this.teacherLabel);
            this.Controls.Add(this.subjectComboBox);
            this.Controls.Add(this.subjectLabel);
            this.Controls.Add(this.addSessionButton);
            this.Controls.Add(this.classSessionDataGridView);
            this.Name = "ClassSessionForm";
            this.Text = "Class Session Management";
            this.Load += new System.EventHandler(this.ClassSessionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.classSessionDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView classSessionDataGridView;
        private System.Windows.Forms.Button addSessionButton;
        private System.Windows.Forms.Label subjectLabel;
        private System.Windows.Forms.ComboBox subjectComboBox;
        private System.Windows.Forms.Label teacherLabel;
        private System.Windows.Forms.ComboBox teacherComboBox;
        private System.Windows.Forms.Label semesterLabel;
        private System.Windows.Forms.ComboBox semesterComboBox;
        private System.Windows.Forms.Label classLabel;
        private System.Windows.Forms.ComboBox classComboBox;
        private System.Windows.Forms.Button deleteSessionButton;
    }
}