using System;
using System.Windows.Forms;

namespace School_database_homework_try_2.Froms.ClassForms {
    partial class AddClassForm {
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
            this.classNameTextBox = new System.Windows.Forms.TextBox();
            this.classNameLabel = new System.Windows.Forms.Label();
            this.gradeComboBox = new System.Windows.Forms.ComboBox();
            this.gradeLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // classNameTextBox
            // 
            this.classNameTextBox.Location = new System.Drawing.Point(136, 27);
            this.classNameTextBox.Name = "classNameTextBox";
            this.classNameTextBox.Size = new System.Drawing.Size(200, 22);
            this.classNameTextBox.TabIndex = 0;
            // 
            // classNameLabel
            // 
            this.classNameLabel.AutoSize = true;
            this.classNameLabel.Location = new System.Drawing.Point(42, 30);
            this.classNameLabel.Name = "classNameLabel";
            this.classNameLabel.Size = new System.Drawing.Size(88, 16);
            this.classNameLabel.TabIndex = 1;
            this.classNameLabel.Text = "Class Name:";
            // 
            // gradeComboBox
            // 
            this.gradeComboBox.FormattingEnabled = true;
            this.gradeComboBox.Location = new System.Drawing.Point(136, 67);
            this.gradeComboBox.Name = "gradeComboBox";
            this.gradeComboBox.Size = new System.Drawing.Size(200, 24);
            this.gradeComboBox.TabIndex = 2;
            // 
            // gradeLabel
            // 
            this.gradeLabel.AutoSize = true;
            this.gradeLabel.Location = new System.Drawing.Point(42, 70);
            this.gradeLabel.Name = "gradeLabel";
            this.gradeLabel.Size = new System.Drawing.Size(54, 16);
            this.gradeLabel.TabIndex = 3;
            this.gradeLabel.Text = "Grade:";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(136, 125);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(93, 35);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(247, 125);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(89, 35);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // AddClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.gradeLabel);
            this.Controls.Add(this.gradeComboBox);
            this.Controls.Add(this.classNameLabel);
            this.Controls.Add(this.classNameTextBox);
            this.Name = "AddClassForm";
            this.Text = "Add Class";
            this.Load += new System.EventHandler(this.AddClassForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }


        private TextBox classNameTextBox;
        private Label classNameLabel;
        private ComboBox gradeComboBox;
        private Label gradeLabel;
        private Button saveButton;
        private Button cancelButton;
    }

    #endregion
}
