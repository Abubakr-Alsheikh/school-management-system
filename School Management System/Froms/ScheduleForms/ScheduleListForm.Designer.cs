using System.Windows.Forms;

namespace School_database_homework_try_2.Froms.ScheduleForms {
    partial class ScheduleListForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private DataGridView scheduleDataGridView;
        private Button addButton;
        private Button editButton;
        private Button deleteButton;
        private TextBox searchTextBox;
        private Label searchLabel;

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
            this.scheduleDataGridView = new System.Windows.Forms.DataGridView();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // scheduleDataGridView
            // 
            this.scheduleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scheduleDataGridView.Location = new System.Drawing.Point(12, 66);
            this.scheduleDataGridView.Name = "scheduleDataGridView";
            this.scheduleDataGridView.RowHeadersWidth = 51;
            this.scheduleDataGridView.RowTemplate.Height = 24;
            this.scheduleDataGridView.Size = new System.Drawing.Size(776, 258);
            this.scheduleDataGridView.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 360);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(117, 46);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add Schedule";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addScheduleButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(139, 360);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(117, 46);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Edit Schedule";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editScheduleButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(266, 360);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(117, 46);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete Schedule";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteScheduleButton_Click);
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
            // ScheduleListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.scheduleDataGridView);
            this.Name = "ScheduleListForm";
            this.Text = "Schedule List";
            this.Load += new System.EventHandler(this.ScheduleListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}