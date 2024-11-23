using System.Windows.Forms;

namespace School_database_homework_try_2.Froms {
    partial class SubjectForm {
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
            this.subjectDataGridView = new System.Windows.Forms.DataGridView();
            this.addSubjectButton = new System.Windows.Forms.Button();
            this.editSubjectButton = new System.Windows.Forms.Button();
            this.deleteSubjectButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.subjectNameTextBox = new System.Windows.Forms.TextBox();
            this.subjectNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.subjectDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // subjectDataGridView
            // 
            this.subjectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subjectDataGridView.Location = new System.Drawing.Point(12, 66);
            this.subjectDataGridView.Name = "subjectDataGridView";
            this.subjectDataGridView.RowHeadersWidth = 51;
            this.subjectDataGridView.RowTemplate.Height = 24;
            this.subjectDataGridView.Size = new System.Drawing.Size(776, 258);
            this.subjectDataGridView.TabIndex = 0;
            this.subjectDataGridView.SelectionChanged += new System.EventHandler(this.subjectDataGridView_SelectionChanged);
            // 
            // addSubjectButton
            // 
            this.addSubjectButton.Location = new System.Drawing.Point(12, 392);
            this.addSubjectButton.Name = "addSubjectButton";
            this.addSubjectButton.Size = new System.Drawing.Size(117, 46);
            this.addSubjectButton.TabIndex = 1;
            this.addSubjectButton.Text = "Add Subject";
            this.addSubjectButton.UseVisualStyleBackColor = true;
            this.addSubjectButton.Click += new System.EventHandler(this.addSubjectButton_Click);
            // 
            // editSubjectButton
            // 
            this.editSubjectButton.Location = new System.Drawing.Point(139, 392);
            this.editSubjectButton.Name = "editSubjectButton";
            this.editSubjectButton.Size = new System.Drawing.Size(117, 46);
            this.editSubjectButton.TabIndex = 2;
            this.editSubjectButton.Text = "Edit Subject";
            this.editSubjectButton.UseVisualStyleBackColor = true;
            this.editSubjectButton.Click += new System.EventHandler(this.editSubjectButton_Click);
            // 
            // deleteSubjectButton
            // 
            this.deleteSubjectButton.Location = new System.Drawing.Point(266, 392);
            this.deleteSubjectButton.Name = "deleteSubjectButton";
            this.deleteSubjectButton.Size = new System.Drawing.Size(117, 46);
            this.deleteSubjectButton.TabIndex = 3;
            this.deleteSubjectButton.Text = "Delete Subject";
            this.deleteSubjectButton.UseVisualStyleBackColor = true;
            this.deleteSubjectButton.Click += new System.EventHandler(this.deleteSubjectButton_Click);
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
            // subjectNameTextBox
            // 
            this.subjectNameTextBox.Location = new System.Drawing.Point(12, 355);
            this.subjectNameTextBox.Name = "subjectNameTextBox";
            this.subjectNameTextBox.Size = new System.Drawing.Size(257, 24);
            this.subjectNameTextBox.TabIndex = 6;
            // 
            // subjectNameLabel
            // 
            this.subjectNameLabel.AutoSize = true;
            this.subjectNameLabel.Location = new System.Drawing.Point(12, 335);
            this.subjectNameLabel.Name = "subjectNameLabel";
            this.subjectNameLabel.Size = new System.Drawing.Size(99, 17);
            this.subjectNameLabel.TabIndex = 7;
            this.subjectNameLabel.Text = "Subject Name:";
            // 
            // SubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.subjectNameLabel);
            this.Controls.Add(this.subjectNameTextBox);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.deleteSubjectButton);
            this.Controls.Add(this.editSubjectButton);
            this.Controls.Add(this.addSubjectButton);
            this.Controls.Add(this.subjectDataGridView);
            this.Name = "SubjectForm";
            this.Text = "Subject Management";
            this.Load += new System.EventHandler(this.SubjectListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.subjectDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private DataGridView subjectDataGridView;
        private Button addSubjectButton;
        private Button editSubjectButton;
        private Button deleteSubjectButton;
        private TextBox searchTextBox;
        private Label searchLabel;
        private TextBox subjectNameTextBox;
        private Label subjectNameLabel;
    }
}
