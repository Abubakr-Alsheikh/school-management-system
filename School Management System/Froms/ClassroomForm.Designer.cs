namespace School_database_homework_try_2.Froms {
    partial class ClassroomForm {
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
            this.classroomDataGridView = new System.Windows.Forms.DataGridView();
            this.roomNumberTextBox = new System.Windows.Forms.TextBox();
            this.roomNumberLabel = new System.Windows.Forms.Label();
            this.capacityTextBox = new System.Windows.Forms.TextBox();
            this.capacityLabel = new System.Windows.Forms.Label();
            this.addClassroomButton = new System.Windows.Forms.Button();
            this.deleteClassroomButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.classroomDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // classroomDataGridView
            // 
            this.classroomDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.classroomDataGridView.Location = new System.Drawing.Point(12, 66);
            this.classroomDataGridView.Name = "classroomDataGridView";
            this.classroomDataGridView.RowHeadersWidth = 51;
            this.classroomDataGridView.RowTemplate.Height = 24;
            this.classroomDataGridView.Size = new System.Drawing.Size(776, 258);
            this.classroomDataGridView.TabIndex = 0;
            // 
            // roomNumberTextBox
            // 
            this.roomNumberTextBox.Location = new System.Drawing.Point(12, 28);
            this.roomNumberTextBox.Name = "roomNumberTextBox";
            this.roomNumberTextBox.Size = new System.Drawing.Size(100, 22);
            this.roomNumberTextBox.TabIndex = 1;
            // 
            // roomNumberLabel
            // 
            this.roomNumberLabel.AutoSize = true;
            this.roomNumberLabel.Location = new System.Drawing.Point(12, 9);
            this.roomNumberLabel.Name = "roomNumberLabel";
            this.roomNumberLabel.Size = new System.Drawing.Size(105, 16);
            this.roomNumberLabel.TabIndex = 2;
            this.roomNumberLabel.Text = "Room Number:";
            // 
            // capacityTextBox
            // 
            this.capacityTextBox.Location = new System.Drawing.Point(138, 28);
            this.capacityTextBox.Name = "capacityTextBox";
            this.capacityTextBox.Size = new System.Drawing.Size(100, 22);
            this.capacityTextBox.TabIndex = 3;
            // 
            // capacityLabel
            // 
            this.capacityLabel.AutoSize = true;
            this.capacityLabel.Location = new System.Drawing.Point(138, 9);
            this.capacityLabel.Name = "capacityLabel";
            this.capacityLabel.Size = new System.Drawing.Size(69, 16);
            this.capacityLabel.TabIndex = 4;
            this.capacityLabel.Text = "Capacity:";
            // 
            // addClassroomButton
            // 
            this.addClassroomButton.Location = new System.Drawing.Point(264, 28);
            this.addClassroomButton.Name = "addClassroomButton";
            this.addClassroomButton.Size = new System.Drawing.Size(93, 23);
            this.addClassroomButton.TabIndex = 5;
            this.addClassroomButton.Text = "Add Classroom";
            this.addClassroomButton.UseVisualStyleBackColor = true;
            this.addClassroomButton.Click += new System.EventHandler(this.addClassroomButton_Click);
            // 
            // deleteClassroomButton
            // 
            this.deleteClassroomButton.Location = new System.Drawing.Point(12, 360);
            this.deleteClassroomButton.Name = "deleteClassroomButton";
            this.deleteClassroomButton.Size = new System.Drawing.Size(117, 46);
            this.deleteClassroomButton.TabIndex = 6;
            this.deleteClassroomButton.Text = "Delete Classroom";
            this.deleteClassroomButton.UseVisualStyleBackColor = true;
            this.deleteClassroomButton.Click += new System.EventHandler(this.deleteClassroomButton_Click);
            // 
            // ClassroomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteClassroomButton);
            this.Controls.Add(this.addClassroomButton);
            this.Controls.Add(this.capacityLabel);
            this.Controls.Add(this.capacityTextBox);
            this.Controls.Add(this.roomNumberLabel);
            this.Controls.Add(this.roomNumberTextBox);
            this.Controls.Add(this.classroomDataGridView);
            this.Name = "ClassroomForm";
            this.Text = "ClassroomForm";
            ((System.ComponentModel.ISupportInitialize)(this.classroomDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView classroomDataGridView;
        private System.Windows.Forms.TextBox roomNumberTextBox;
        private System.Windows.Forms.Label roomNumberLabel;
        private System.Windows.Forms.TextBox capacityTextBox;
        private System.Windows.Forms.Label capacityLabel;
        private System.Windows.Forms.Button addClassroomButton;
        private System.Windows.Forms.Button deleteClassroomButton;
    }
}
