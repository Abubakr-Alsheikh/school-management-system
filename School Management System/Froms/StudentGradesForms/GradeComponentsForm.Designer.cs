using System.Windows.Forms;

namespace School_database_homework_try_2.Froms.StudentGradesForms {
    partial class GradeComponentsForm {
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
            this.gradeComponentsDataGridView = new System.Windows.Forms.DataGridView();
            this.componentNameTextBox = new System.Windows.Forms.TextBox();
            this.componentNameLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gradeComponentsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // gradeComponentsDataGridView
            // 
            this.gradeComponentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gradeComponentsDataGridView.Location = new System.Drawing.Point(12, 12);
            this.gradeComponentsDataGridView.Name = "gradeComponentsDataGridView";
            this.gradeComponentsDataGridView.RowHeadersWidth = 51;
            this.gradeComponentsDataGridView.RowTemplate.Height = 24;
            this.gradeComponentsDataGridView.Size = new System.Drawing.Size(776, 258);
            this.gradeComponentsDataGridView.TabIndex = 0;
            this.gradeComponentsDataGridView.SelectionChanged += new System.EventHandler(this.gradeComponentsDataGridView_SelectionChanged);
            // 
            // componentNameTextBox
            // 
            this.componentNameTextBox.Location = new System.Drawing.Point(12, 320);
            this.componentNameTextBox.Name = "componentNameTextBox";
            this.componentNameTextBox.Size = new System.Drawing.Size(257, 24);
            this.componentNameTextBox.TabIndex = 1;
            // 
            // componentNameLabel
            // 
            this.componentNameLabel.AutoSize = true;
            this.componentNameLabel.Location = new System.Drawing.Point(12, 294);
            this.componentNameLabel.Name = "componentNameLabel";
            this.componentNameLabel.Size = new System.Drawing.Size(125, 17);
            this.componentNameLabel.TabIndex = 2;
            this.componentNameLabel.Text = "Component Name:";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 360);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(117, 46);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(139, 360);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(117, 46);
            this.editButton.TabIndex = 4;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(266, 360);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(117, 46);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // GradeComponentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.componentNameLabel);
            this.Controls.Add(this.componentNameTextBox);
            this.Controls.Add(this.gradeComponentsDataGridView);
            this.Name = "GradeComponentsForm";
            this.Text = "Grade Components";
            this.Load += new System.EventHandler(this.GradeComponentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gradeComponentsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private DataGridView gradeComponentsDataGridView;
        private TextBox componentNameTextBox;
        private Label componentNameLabel;
        private Button addButton;
        private Button editButton;
        private Button deleteButton;

        #endregion
    }
}