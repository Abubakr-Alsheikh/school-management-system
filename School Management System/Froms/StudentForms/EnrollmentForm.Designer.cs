using System;
using System.Windows.Forms;

namespace School_database_homework_try_2.Froms.StudentForms {
    partial class EnrollmentForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Button enrollButton;
        private Button removeButton;
        private Label availableClassesLabel;
        private Label enrolledClassesLabel;
        private DataGridView availableClassesDataGridView;
        private DataGridView enrolledClassesDataGridView;

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
            this.availableClassesDataGridView = new System.Windows.Forms.DataGridView();
            this.enrolledClassesDataGridView = new System.Windows.Forms.DataGridView();
            this.enrollButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.availableClassesLabel = new System.Windows.Forms.Label();
            this.enrolledClassesLabel = new System.Windows.Forms.Label();

            this.SuspendLayout();
            //
            // availableClassesDataGridView
            //
            this.availableClassesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.availableClassesDataGridView.Location = new System.Drawing.Point(12, 63);
            this.availableClassesDataGridView.Name = "availableClassesDataGridView";
            this.availableClassesDataGridView.RowHeadersWidth = 51;
            this.availableClassesDataGridView.RowTemplate.Height = 24;
            this.availableClassesDataGridView.Size = new System.Drawing.Size(375, 292);
            this.availableClassesDataGridView.TabIndex = 0;

            //
            // enrolledClassesDataGridView
            //
            this.enrolledClassesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.enrolledClassesDataGridView.Location = new System.Drawing.Point(406, 63);
            this.enrolledClassesDataGridView.Name = "enrolledClassesDataGridView";
            this.enrolledClassesDataGridView.RowHeadersWidth = 51;
            this.enrolledClassesDataGridView.RowTemplate.Height = 24;
            this.enrolledClassesDataGridView.Size = new System.Drawing.Size(375, 292);
            this.enrolledClassesDataGridView.TabIndex = 1;
            // 
            // enrollButton
            // 
            this.enrollButton.Location = new System.Drawing.Point(12, 396);
            this.enrollButton.Name = "enrollButton";
            this.enrollButton.Size = new System.Drawing.Size(117, 46);
            this.enrollButton.TabIndex = 2;
            this.enrollButton.Text = "Enroll";
            this.enrollButton.UseVisualStyleBackColor = true;
            this.enrollButton.Click += new System.EventHandler(this.enrollButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(406, 396);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(117, 46);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // availableClassesLabel
            // 
            this.availableClassesLabel.AutoSize = true;
            this.availableClassesLabel.Location = new System.Drawing.Point(12, 31);
            this.availableClassesLabel.Name = "availableClassesLabel";
            this.availableClassesLabel.Size = new System.Drawing.Size(125, 16);
            this.availableClassesLabel.TabIndex = 4;
            this.availableClassesLabel.Text = "Available Classes:";
            // 
            // enrolledClassesLabel
            // 
            this.enrolledClassesLabel.AutoSize = true;
            this.enrolledClassesLabel.Location = new System.Drawing.Point(406, 31);
            this.enrolledClassesLabel.Name = "enrolledClassesLabel";
            this.enrolledClassesLabel.Size = new System.Drawing.Size(116, 16);
            this.enrolledClassesLabel.TabIndex = 5;
            this.enrolledClassesLabel.Text = "Enrolled Classes:";
            // 
            // EnrollmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.enrolledClassesLabel);
            this.Controls.Add(this.availableClassesLabel);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.enrollButton);
            this.Controls.Add(this.availableClassesDataGridView);
            this.Controls.Add(this.enrolledClassesDataGridView);
            this.Name = "EnrollmentForm";
            this.Text = "Enrollment";
            this.Load += new System.EventHandler(this.EnrollmentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }


        #endregion
    }
}