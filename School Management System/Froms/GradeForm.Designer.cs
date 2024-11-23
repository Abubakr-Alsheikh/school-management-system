namespace School_database_homework_try_2.Froms {
    partial class GradeForm {
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
            this.gradeDataGridView = new System.Windows.Forms.DataGridView();
            this.gradeNameTextBox = new System.Windows.Forms.TextBox();
            this.gradeNameLabel = new System.Windows.Forms.Label();
            this.addGradeButton = new System.Windows.Forms.Button();
            this.deleteGradeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gradeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // gradeDataGridView
            // 
            this.gradeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gradeDataGridView.Location = new System.Drawing.Point(12, 66);
            this.gradeDataGridView.Name = "gradeDataGridView";
            this.gradeDataGridView.RowHeadersWidth = 51;
            this.gradeDataGridView.RowTemplate.Height = 24;
            this.gradeDataGridView.Size = new System.Drawing.Size(776, 258);
            this.gradeDataGridView.TabIndex = 0;
            // 
            // gradeNameTextBox
            // 
            this.gradeNameTextBox.Location = new System.Drawing.Point(12, 28);
            this.gradeNameTextBox.Name = "gradeNameTextBox";
            this.gradeNameTextBox.Size = new System.Drawing.Size(150, 22);
            this.gradeNameTextBox.TabIndex = 1;
            // 
            // gradeNameLabel
            // 
            this.gradeNameLabel.AutoSize = true;
            this.gradeNameLabel.Location = new System.Drawing.Point(12, 9);
            this.gradeNameLabel.Name = "gradeNameLabel";
            this.gradeNameLabel.Size = new System.Drawing.Size(86, 16);
            this.gradeNameLabel.TabIndex = 2;
            this.gradeNameLabel.Text = "Grade Name:";
            // 
            // addGradeButton
            // 
            this.addGradeButton.Location = new System.Drawing.Point(168, 28);
            this.addGradeButton.Name = "addGradeButton";
            this.addGradeButton.Size = new System.Drawing.Size(93, 23);
            this.addGradeButton.TabIndex = 3;
            this.addGradeButton.Text = "Add Grade";
            this.addGradeButton.UseVisualStyleBackColor = true;
            this.addGradeButton.Click += new System.EventHandler(this.addGradeButton_Click);
            // 
            // deleteGradeButton
            // 
            this.deleteGradeButton.Location = new System.Drawing.Point(12, 360);
            this.deleteGradeButton.Name = "deleteGradeButton";
            this.deleteGradeButton.Size = new System.Drawing.Size(117, 46);
            this.deleteGradeButton.TabIndex = 4;
            this.deleteGradeButton.Text = "Delete Grade";
            this.deleteGradeButton.UseVisualStyleBackColor = true;
            this.deleteGradeButton.Click += new System.EventHandler(this.deleteGradeButton_Click);
            // 
            // GradeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteGradeButton);
            this.Controls.Add(this.addGradeButton);
            this.Controls.Add(this.gradeNameLabel);
            this.Controls.Add(this.gradeNameTextBox);
            this.Controls.Add(this.gradeDataGridView);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Name = "GradeForm";
            this.Text = "GradeForm";
            this.Load += new System.EventHandler(this.GradeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gradeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gradeDataGridView;
        private System.Windows.Forms.TextBox gradeNameTextBox;
        private System.Windows.Forms.Label gradeNameLabel;
        private System.Windows.Forms.Button addGradeButton;
        private System.Windows.Forms.Button deleteGradeButton;
    }

}
