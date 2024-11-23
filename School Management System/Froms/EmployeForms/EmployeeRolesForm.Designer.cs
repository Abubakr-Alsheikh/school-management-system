namespace School_database_homework_try_2.Froms.EmployeForms {
    partial class EmployeeRolesForm {
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
        private void InitializeComponent()
        {
            this.availableRolesListBox = new System.Windows.Forms.ListBox();
            this.addRoleButton = new System.Windows.Forms.Button();
            this.deleteRoleButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.newRoleNameTextBox = new System.Windows.Forms.TextBox();
            this.newRoleNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // availableRolesListBox
            // 
            this.availableRolesListBox.FormattingEnabled = true;
            this.availableRolesListBox.ItemHeight = 16;
            this.availableRolesListBox.Location = new System.Drawing.Point(12, 12);
            this.availableRolesListBox.Name = "availableRolesListBox";
            this.availableRolesListBox.Size = new System.Drawing.Size(181, 196);
            this.availableRolesListBox.TabIndex = 0;
            // 
            // addRoleButton
            // 
            this.addRoleButton.Location = new System.Drawing.Point(25, 271);
            this.addRoleButton.Name = "addRoleButton";
            this.addRoleButton.Size = new System.Drawing.Size(67, 34);
            this.addRoleButton.TabIndex = 2;
            this.addRoleButton.Text = "Add Role";
            this.addRoleButton.UseVisualStyleBackColor = true;
            this.addRoleButton.Click += new System.EventHandler(this.addRoleButton_Click);
            // 
            // deleteRoleButton
            // 
            this.deleteRoleButton.Location = new System.Drawing.Point(98, 271);
            this.deleteRoleButton.Name = "deleteRoleButton";
            this.deleteRoleButton.Size = new System.Drawing.Size(79, 34);
            this.deleteRoleButton.TabIndex = 3;
            this.deleteRoleButton.Text = "Delete Role";
            this.deleteRoleButton.UseVisualStyleBackColor = true;
            this.deleteRoleButton.Click += new System.EventHandler(this.deleteRoleButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(25, 311);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(152, 34);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // newRoleNameTextBox
            // 
            this.newRoleNameTextBox.Location = new System.Drawing.Point(12, 241);
            this.newRoleNameTextBox.Name = "newRoleNameTextBox";
            this.newRoleNameTextBox.Size = new System.Drawing.Size(181, 24);
            this.newRoleNameTextBox.TabIndex = 2;
            // 
            // newRoleNameLabel
            // 
            this.newRoleNameLabel.AutoSize = true;
            this.newRoleNameLabel.Location = new System.Drawing.Point(12, 221);
            this.newRoleNameLabel.Name = "newRoleNameLabel";
            this.newRoleNameLabel.Size = new System.Drawing.Size(108, 17);
            this.newRoleNameLabel.TabIndex = 3;
            this.newRoleNameLabel.Text = "New Role Name:";
            // 
            // EmployeeRolesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 356);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.deleteRoleButton);
            this.Controls.Add(this.addRoleButton);
            this.Controls.Add(this.availableRolesListBox);
            this.Controls.Add(this.newRoleNameTextBox);
            this.Controls.Add(this.newRoleNameLabel);
            this.Name = "EmployeeRolesForm";
            this.Text = "Manage Employee Roles";
            this.Load += new System.EventHandler(this.EmployeeRolesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox newRoleNameTextBox;
        private System.Windows.Forms.Label newRoleNameLabel;
        private System.Windows.Forms.ListBox availableRolesListBox;
        private System.Windows.Forms.Button addRoleButton;
        private System.Windows.Forms.Button deleteRoleButton;
        private System.Windows.Forms.Button closeButton;
    }
}