using System.Windows.Forms;

namespace School_database_homework_try_2.Froms {
    partial class SemesterForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private DataGridView semesterDataGridView; // Add a DataGridView to display semesters
        private Button addButton; // Add button to add a new semester
        private Button editButton; // Edit button to modify a semester
        private Button deleteButton; // Delete button to remove a semester
        private TextBox semesterNameTextBox; // Textbox for entering/editing the semester name
        private Label semesterNameLabel; // Label for the semester name textbox
        private TextBox schoolYearTextBox; // Textbox for entering/editing the school year
        private Label schoolYearLabel; // Label for the school year textbox
        private Label searchLabel; // Label for the search textbox
        private TextBox searchTextBox; // Search textbox to filter semesters
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
            this.semesterDataGridView = new System.Windows.Forms.DataGridView();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.semesterNameTextBox = new System.Windows.Forms.TextBox();
            this.semesterNameLabel = new System.Windows.Forms.Label();
            this.schoolYearTextBox = new System.Windows.Forms.TextBox();
            this.schoolYearLabel = new System.Windows.Forms.Label();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.semesterDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // semesterDataGridView
            // 
            this.semesterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.semesterDataGridView.Location = new System.Drawing.Point(12, 66);
            this.semesterDataGridView.Name = "semesterDataGridView";
            this.semesterDataGridView.RowHeadersWidth = 51;
            this.semesterDataGridView.RowTemplate.Height = 24;
            this.semesterDataGridView.Size = new System.Drawing.Size(776, 258);
            this.semesterDataGridView.TabIndex = 0;
            this.semesterDataGridView.SelectionChanged += new System.EventHandler(this.semesterDataGridView_SelectionChanged);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(356, 348);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(117, 46);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add Semester";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(494, 348);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(117, 46);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Edit Semester";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(631, 348);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(117, 46);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete Semester";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // semesterNameTextBox
            // 
            this.semesterNameTextBox.Location = new System.Drawing.Point(136, 348);
            this.semesterNameTextBox.Name = "semesterNameTextBox";
            this.semesterNameTextBox.Size = new System.Drawing.Size(200, 24);
            this.semesterNameTextBox.TabIndex = 4;
            // 
            // semesterNameLabel
            // 
            this.semesterNameLabel.AutoSize = true;
            this.semesterNameLabel.Location = new System.Drawing.Point(21, 351);
            this.semesterNameLabel.Name = "semesterNameLabel";
            this.semesterNameLabel.Size = new System.Drawing.Size(109, 17);
            this.semesterNameLabel.TabIndex = 5;
            this.semesterNameLabel.Text = "Semester Name:";
            // 
            // schoolYearTextBox
            // 
            this.schoolYearTextBox.Location = new System.Drawing.Point(136, 388);
            this.schoolYearTextBox.Name = "schoolYearTextBox";
            this.schoolYearTextBox.Size = new System.Drawing.Size(200, 24);
            this.schoolYearTextBox.TabIndex = 6;
            // 
            // schoolYearLabel
            // 
            this.schoolYearLabel.AutoSize = true;
            this.schoolYearLabel.Location = new System.Drawing.Point(21, 391);
            this.schoolYearLabel.Name = "schoolYearLabel";
            this.schoolYearLabel.Size = new System.Drawing.Size(85, 17);
            this.schoolYearLabel.TabIndex = 7;
            this.schoolYearLabel.Text = "School Year:";
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(12, 9);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(55, 17);
            this.searchLabel.TabIndex = 8;
            this.searchLabel.Text = "Search:";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(12, 28);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(257, 24);
            this.searchTextBox.TabIndex = 9;
            // 
            // SemesterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.schoolYearLabel);
            this.Controls.Add(this.schoolYearTextBox);
            this.Controls.Add(this.semesterNameLabel);
            this.Controls.Add(this.semesterNameTextBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.semesterDataGridView);
            this.Name = "SemesterForm";
            this.Text = "SemesterForm";
            this.Load += new System.EventHandler(this.SemesterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.semesterDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}