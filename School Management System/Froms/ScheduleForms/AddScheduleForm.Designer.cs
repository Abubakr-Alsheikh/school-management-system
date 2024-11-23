using System.Windows.Forms;

namespace School_database_homework_try_2.Froms.ScheduleForms {
    partial class AddScheduleForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Label classLabel;
        private ComboBox classComboBox;
        private Label classroomLabel;
        private ComboBox classroomComboBox;
        private Label classSessionLabel;
        private ComboBox classSessionComboBox;
        private Label dayOfWeekLabel;
        private ComboBox dayOfWeekComboBox;
        private Label startTimeLabel;
        private DateTimePicker startTimePicker;
        private Label endTimeLabel;
        private DateTimePicker endTimePicker;
        private Button saveScheduleButton;
        private Button cancelScheduleButton;

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
            this.classLabel = new System.Windows.Forms.Label();
            this.classComboBox = new System.Windows.Forms.ComboBox();
            this.classroomLabel = new System.Windows.Forms.Label();
            this.classroomComboBox = new System.Windows.Forms.ComboBox();
            this.classSessionLabel = new System.Windows.Forms.Label();
            this.classSessionComboBox = new System.Windows.Forms.ComboBox();
            this.dayOfWeekLabel = new System.Windows.Forms.Label();
            this.dayOfWeekComboBox = new System.Windows.Forms.ComboBox();
            this.startTimeLabel = new System.Windows.Forms.Label();
            this.startTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endTimeLabel = new System.Windows.Forms.Label();
            this.endTimePicker = new System.Windows.Forms.DateTimePicker();
            this.saveScheduleButton = new System.Windows.Forms.Button();
            this.cancelScheduleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // classLabel
            // 
            this.classLabel.AutoSize = true;
            this.classLabel.Location = new System.Drawing.Point(40, 30);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(43, 17);
            this.classLabel.TabIndex = 0;
            this.classLabel.Text = "Class:";
            // 
            // classComboBox
            // 
            this.classComboBox.FormattingEnabled = true;
            this.classComboBox.Location = new System.Drawing.Point(110, 27);
            this.classComboBox.Name = "classComboBox";
            this.classComboBox.Size = new System.Drawing.Size(200, 24);
            this.classComboBox.TabIndex = 1;
            // 
            // classroomLabel
            // 
            this.classroomLabel.AutoSize = true;
            this.classroomLabel.Location = new System.Drawing.Point(40, 70);
            this.classroomLabel.Name = "classroomLabel";
            this.classroomLabel.Size = new System.Drawing.Size(76, 17);
            this.classroomLabel.TabIndex = 2;
            this.classroomLabel.Text = "Classroom:";
            // 
            // classroomComboBox
            // 
            this.classroomComboBox.FormattingEnabled = true;
            this.classroomComboBox.Location = new System.Drawing.Point(110, 67);
            this.classroomComboBox.Name = "classroomComboBox";
            this.classroomComboBox.Size = new System.Drawing.Size(200, 24);
            this.classroomComboBox.TabIndex = 3;
            // 
            // classSessionLabel
            // 
            this.classSessionLabel.AutoSize = true;
            this.classSessionLabel.Location = new System.Drawing.Point(40, 110);
            this.classSessionLabel.Name = "classSessionLabel";
            this.classSessionLabel.Size = new System.Drawing.Size(92, 17);
            this.classSessionLabel.TabIndex = 4;
            this.classSessionLabel.Text = "Class Session:";
            // 
            // classSessionComboBox
            // 
            this.classSessionComboBox.FormattingEnabled = true;
            this.classSessionComboBox.Location = new System.Drawing.Point(110, 107);
            this.classSessionComboBox.Name = "classSessionComboBox";
            this.classSessionComboBox.Size = new System.Drawing.Size(200, 24);
            this.classSessionComboBox.TabIndex = 5;
            // 
            // dayOfWeekLabel
            // 
            this.dayOfWeekLabel.AutoSize = true;
            this.dayOfWeekLabel.Location = new System.Drawing.Point(40, 150);
            this.dayOfWeekLabel.Name = "dayOfWeekLabel";
            this.dayOfWeekLabel.Size = new System.Drawing.Size(93, 17);
            this.dayOfWeekLabel.TabIndex = 6;
            this.dayOfWeekLabel.Text = "Day of Week:";
            // 
            // dayOfWeekComboBox
            // 
            this.dayOfWeekComboBox.FormattingEnabled = true;
            this.dayOfWeekComboBox.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.dayOfWeekComboBox.Location = new System.Drawing.Point(110, 147);
            this.dayOfWeekComboBox.Name = "dayOfWeekComboBox";
            this.dayOfWeekComboBox.Size = new System.Drawing.Size(200, 24);
            this.dayOfWeekComboBox.TabIndex = 7;
            // 
            // startTimeLabel
            // 
            this.startTimeLabel.AutoSize = true;
            this.startTimeLabel.Location = new System.Drawing.Point(40, 190);
            this.startTimeLabel.Name = "startTimeLabel";
            this.startTimeLabel.Size = new System.Drawing.Size(76, 17);
            this.startTimeLabel.TabIndex = 8;
            this.startTimeLabel.Text = "Start Time:";
            // 
            // startTimePicker
            // 
            this.startTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.startTimePicker.Location = new System.Drawing.Point(110, 187);
            this.startTimePicker.Name = "startTimePicker";
            this.startTimePicker.ShowUpDown = true;
            this.startTimePicker.Size = new System.Drawing.Size(200, 24);
            this.startTimePicker.TabIndex = 9;
            // 
            // endTimeLabel
            // 
            this.endTimeLabel.AutoSize = true;
            this.endTimeLabel.Location = new System.Drawing.Point(40, 230);
            this.endTimeLabel.Name = "endTimeLabel";
            this.endTimeLabel.Size = new System.Drawing.Size(70, 17);
            this.endTimeLabel.TabIndex = 10;
            this.endTimeLabel.Text = "End Time:";
            // 
            // endTimePicker
            // 
            this.endTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.endTimePicker.Location = new System.Drawing.Point(110, 227);
            this.endTimePicker.Name = "endTimePicker";
            this.endTimePicker.ShowUpDown = true;
            this.endTimePicker.Size = new System.Drawing.Size(200, 24);
            this.endTimePicker.TabIndex = 11;
            // 
            // saveScheduleButton
            // 
            this.saveScheduleButton.Location = new System.Drawing.Point(110, 287);
            this.saveScheduleButton.Name = "saveScheduleButton";
            this.saveScheduleButton.Size = new System.Drawing.Size(93, 35);
            this.saveScheduleButton.TabIndex = 12;
            this.saveScheduleButton.Text = "Save";
            this.saveScheduleButton.UseVisualStyleBackColor = true;
            this.saveScheduleButton.Click += new System.EventHandler(this.saveScheduleButton_Click);
            // 
            // cancelScheduleButton
            // 
            this.cancelScheduleButton.Location = new System.Drawing.Point(219, 287);
            this.cancelScheduleButton.Name = "cancelScheduleButton";
            this.cancelScheduleButton.Size = new System.Drawing.Size(89, 35);
            this.cancelScheduleButton.TabIndex = 13;
            this.cancelScheduleButton.Text = "Cancel";
            this.cancelScheduleButton.UseVisualStyleBackColor = true;
            this.cancelScheduleButton.Click += new System.EventHandler(this.cancelScheduleButton_Click);
            // 
            // AddScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 450);
            this.Controls.Add(this.cancelScheduleButton);
            this.Controls.Add(this.saveScheduleButton);
            this.Controls.Add(this.endTimePicker);
            this.Controls.Add(this.endTimeLabel);
            this.Controls.Add(this.startTimePicker);
            this.Controls.Add(this.startTimeLabel);
            this.Controls.Add(this.dayOfWeekComboBox);
            this.Controls.Add(this.dayOfWeekLabel);
            this.Controls.Add(this.classSessionComboBox);
            this.Controls.Add(this.classSessionLabel);
            this.Controls.Add(this.classroomComboBox);
            this.Controls.Add(this.classroomLabel);
            this.Controls.Add(this.classComboBox);
            this.Controls.Add(this.classLabel);
            this.Name = "AddScheduleForm";
            this.Text = "Add Schedule";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}