using System.Windows.Forms;

namespace School_database_homework_try_2.Froms {
    partial class SectionForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Label sectionNameLabel;
        private ComboBox classComboBox;
        private Label classLabel;
        private Button addButton;
        private Button deleteButton;
        private Button updateButton;
        private DataGridView sectionDataGridView;
        private TextBox sectionNameTextBox;

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
            this.sectionDataGridView = new System.Windows.Forms.DataGridView();
            this.sectionNameTextBox = new System.Windows.Forms.TextBox();
            this.sectionNameLabel = new System.Windows.Forms.Label();
            this.classComboBox = new System.Windows.Forms.ComboBox();
            this.classLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sectionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // sectionDataGridView
            // 
            this.sectionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sectionDataGridView.Location = new System.Drawing.Point(12, 99);
            this.sectionDataGridView.Name = "sectionDataGridView";
            this.sectionDataGridView.RowHeadersWidth = 51;
            this.sectionDataGridView.RowTemplate.Height = 24;
            this.sectionDataGridView.Size = new System.Drawing.Size(776, 258);
            this.sectionDataGridView.TabIndex = 0;
            this.sectionDataGridView.SelectionChanged += new System.EventHandler(this.sectionDataGridView_SelectionChanged);
            // 
            // sectionNameTextBox
            // 
            this.sectionNameTextBox.Location = new System.Drawing.Point(136, 12);
            this.sectionNameTextBox.Name = "sectionNameTextBox";
            this.sectionNameTextBox.Size = new System.Drawing.Size(200, 22);
            this.sectionNameTextBox.TabIndex = 1;
            // 
            // sectionNameLabel
            // 
            this.sectionNameLabel.AutoSize = true;
            this.sectionNameLabel.Location = new System.Drawing.Point(42, 15);
            this.sectionNameLabel.Name = "sectionNameLabel";
            this.sectionNameLabel.Size = new System.Drawing.Size(99, 16);
            this.sectionNameLabel.TabIndex = 2;
            this.sectionNameLabel.Text = "Section Name:";
            // 
            // classComboBox
            // 
            this.classComboBox.FormattingEnabled = true;
            this.classComboBox.Location = new System.Drawing.Point(136, 50);
            this.classComboBox.Name = "classComboBox";
            this.classComboBox.Size = new System.Drawing.Size(200, 24);
            this.classComboBox.TabIndex = 3;
            // 
            // classLabel
            // 
            this.classLabel.AutoSize = true;
            this.classLabel.Location = new System.Drawing.Point(42, 53);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(49, 16);
            this.classLabel.TabIndex = 4;
            this.classLabel.Text = "Class:";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 383);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(117, 46);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add Section";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(287, 383);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(117, 46);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Delete Section";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(150, 383);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(117, 46);
            this.updateButton.TabIndex = 7;
            this.updateButton.Text = "Update Section";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // SectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.classLabel);
            this.Controls.Add(this.classComboBox);
            this.Controls.Add(this.sectionNameLabel);
            this.Controls.Add(this.sectionNameTextBox);
            this.Controls.Add(this.sectionDataGridView);
            this.Name = "SectionForm";
            this.Text = "SectionForm";
            this.Load += new System.EventHandler(this.SectionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sectionDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}