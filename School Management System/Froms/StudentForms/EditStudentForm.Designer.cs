using System;
using System.Windows.Forms;

namespace School_database_homework_try_2.Froms.StudentForms {
    partial class EditStudentForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private TextBox firstNameTextBox;
        private Label firstNameLabel;
        private TextBox lastNameTextBox;
        private Label lastNameLabel;
        private DateTimePicker dateOfBirthDateTimePicker;
        private Label dateOfBirthLabel;
        private ComboBox genderComboBox;
        private Label genderLabel;
        private TextBox addressTextBox;
        private Label addressLabel;
        private TextBox parentNameTextBox;
        private Label parentNameLabel;
        private TextBox parentContactTextBox;
        private Label parentContactLabel;
        private Button updateButton;
        private Button cancelButton;

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
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.dateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateOfBirthLabel = new System.Windows.Forms.Label();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.genderLabel = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.parentNameTextBox = new System.Windows.Forms.TextBox();
            this.parentNameLabel = new System.Windows.Forms.Label();
            this.parentContactTextBox = new System.Windows.Forms.TextBox();
            this.parentContactLabel = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(136, 27);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(200, 22);
            this.firstNameTextBox.TabIndex = 0;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(42, 30);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(88, 16);
            this.firstNameLabel.TabIndex = 1;
            this.firstNameLabel.Text = "First Name:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(136, 67);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(200, 22);
            this.lastNameTextBox.TabIndex = 2;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(42, 70);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(88, 16);
            this.lastNameLabel.TabIndex = 3;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // dateOfBirthDateTimePicker
            // 
            this.dateOfBirthDateTimePicker.Location = new System.Drawing.Point(136, 108);
            this.dateOfBirthDateTimePicker.Name = "dateOfBirthDateTimePicker";
            this.dateOfBirthDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateOfBirthDateTimePicker.TabIndex = 4;
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.AutoSize = true;
            this.dateOfBirthLabel.Location = new System.Drawing.Point(42, 111);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(93, 16);
            this.dateOfBirthLabel.TabIndex = 5;
            this.dateOfBirthLabel.Text = "Date of Birth:";
            // 
            // genderComboBox
            // 
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderComboBox.Location = new System.Drawing.Point(136, 149);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(200, 24);
            this.genderComboBox.TabIndex = 6;
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(42, 152);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(60, 16);
            this.genderLabel.TabIndex = 7;
            this.genderLabel.Text = "Gender:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(136, 190);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(200, 22);
            this.addressTextBox.TabIndex = 8;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(42, 193);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(67, 16);
            this.addressLabel.TabIndex = 9;
            this.addressLabel.Text = "Address:";
            // 
            // parentNameTextBox
            // 
            this.parentNameTextBox.Location = new System.Drawing.Point(136, 231);
            this.parentNameTextBox.Name = "parentNameTextBox";
            this.parentNameTextBox.Size = new System.Drawing.Size(200, 22);
            this.parentNameTextBox.TabIndex = 10;
            // 
            // parentNameLabel
            // 
            this.parentNameLabel.AutoSize = true;
            this.parentNameLabel.Location = new System.Drawing.Point(42, 234);
            this.parentNameLabel.Name = "parentNameLabel";
            this.parentNameLabel.Size = new System.Drawing.Size(97, 16);
            this.parentNameLabel.TabIndex = 11;
            this.parentNameLabel.Text = "Parent Name:";
            // 
            // parentContactTextBox
            // 
            this.parentContactTextBox.Location = new System.Drawing.Point(136, 272);
            this.parentContactTextBox.Name = "parentContactTextBox";
            this.parentContactTextBox.Size = new System.Drawing.Size(200, 22);
            this.parentContactTextBox.TabIndex = 12;
            // 
            // parentContactLabel
            // 
            this.parentContactLabel.AutoSize = true;
            this.parentContactLabel.Location = new System.Drawing.Point(42, 275);
            this.parentContactLabel.Name = "parentContactLabel";
            this.parentContactLabel.Size = new System.Drawing.Size(112, 16);
            this.parentContactLabel.TabIndex = 13;
            this.parentContactLabel.Text = "Parent Contact:";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(136, 380);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(93, 35);
            this.updateButton.TabIndex = 14;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(247, 380);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(89, 35);
            this.cancelButton.TabIndex = 15;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // EditStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 438);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.parentContactLabel);
            this.Controls.Add(this.parentContactTextBox);
            this.Controls.Add(this.parentNameLabel);
            this.Controls.Add(this.parentNameTextBox);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.dateOfBirthLabel);
            this.Controls.Add(this.dateOfBirthDateTimePicker);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Name = "EditStudentForm";
            this.Text = "Edit Student";
            this.Load += new System.EventHandler(this.EditStudentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
    }
}