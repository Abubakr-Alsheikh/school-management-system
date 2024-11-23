namespace School_database_homework_try_2.Froms {
    partial class EmployeeListForm {
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
            this.employeeDataGridView = new System.Windows.Forms.DataGridView();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.rolesDataGridView = new System.Windows.Forms.DataGridView();
            this.viewRolesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeDataGridView
            // 
            this.employeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeDataGridView.Location = new System.Drawing.Point(10, 66);
            this.employeeDataGridView.Name = "employeeDataGridView";
            this.employeeDataGridView.RowHeadersWidth = 51;
            this.employeeDataGridView.RowTemplate.Height = 24;
            this.employeeDataGridView.Size = new System.Drawing.Size(519, 324);
            this.employeeDataGridView.TabIndex = 0;
            this.employeeDataGridView.SelectionChanged += new System.EventHandler(this.employeeDataGridView_SelectionChanged);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(10, 396);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(102, 46);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add Employee";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(131, 396);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(102, 46);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Edit Employee";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(251, 396);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(102, 46);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete Employee";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(10, 28);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(225, 24);
            this.searchTextBox.TabIndex = 4;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(10, 9);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(55, 17);
            this.searchLabel.TabIndex = 5;
            this.searchLabel.Text = "Search:";
            // 
            // rolesDataGridView
            // 
            this.rolesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rolesDataGridView.Location = new System.Drawing.Point(536, 66);
            this.rolesDataGridView.Name = "rolesDataGridView";
            this.rolesDataGridView.RowHeadersWidth = 51;
            this.rolesDataGridView.RowTemplate.Height = 24;
            this.rolesDataGridView.Size = new System.Drawing.Size(152, 324);
            this.rolesDataGridView.TabIndex = 6;
            // 
            // viewRolesButton
            // 
            this.viewRolesButton.Location = new System.Drawing.Point(372, 396);
            this.viewRolesButton.Name = "viewRolesButton";
            this.viewRolesButton.Size = new System.Drawing.Size(102, 46);
            this.viewRolesButton.TabIndex = 7;
            this.viewRolesButton.Text = "Manage Roles";
            this.viewRolesButton.UseVisualStyleBackColor = true;
            this.viewRolesButton.Click += new System.EventHandler(this.viewRolesButton_Click);
            // 
            // EmployeeListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.viewRolesButton);
            this.Controls.Add(this.rolesDataGridView);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.employeeDataGridView);
            this.Name = "EmployeeListForm";
            this.Text = "Employee List";
            this.Load += new System.EventHandler(this.EmployeeListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView employeeDataGridView;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.DataGridView rolesDataGridView;
        private System.Windows.Forms.Button viewRolesButton;
    }
}