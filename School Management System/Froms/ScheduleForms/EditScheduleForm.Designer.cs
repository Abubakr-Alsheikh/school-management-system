using System.Windows.Forms;

namespace School_database_homework_try_2.Froms.ScheduleForms {
    partial class EditScheduleForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Label classLabel;
        private Label classroomLabel;
        private Label teacherLabel;
        private Label dayOfWeekLabel;
        private Label startTimeLabel;
        private Label endTimeLabel;
        private ComboBox classComboBox;
        private ComboBox classroomComboBox;
        private ComboBox classSessionComboBox;
        private ComboBox dayOfWeekComboBox;
        private DateTimePicker startTimePicker;
        private DateTimePicker endTimePicker;
        private Button updateScheduleButton;
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
            this.classroomLabel = new System.Windows.Forms.Label();
            this.teacherLabel = new System.Windows.Forms.Label();
            this.dayOfWeekLabel = new System.Windows.Forms.Label();
            this.startTimeLabel = new System.Windows.Forms.Label();
            this.endTimeLabel = new System.Windows.Forms.Label();
            this.classComboBox = new System.Windows.Forms.ComboBox();
            this.classroomComboBox = new System.Windows.Forms.ComboBox();
            this.classSessionComboBox = new System.Windows.Forms.ComboBox();
            this.dayOfWeekComboBox = new System.Windows.Forms.ComboBox();
            this.startTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endTimePicker = new System.Windows.Forms.DateTimePicker();
            this.updateScheduleButton = new System.Windows.Forms.Button();
            this.cancelScheduleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // classLabel
            // 
            this.classLabel.AutoSize = true;
            this.classLabel.Location = new System.Drawing.Point(34, 34);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(43, 17);
            this.classLabel.TabIndex = 0;
            this.classLabel.Text = "Class:";
            // 
            // classroomLabel
            // 
            this.classroomLabel.AutoSize = true;
            this.classroomLabel.Location = new System.Drawing.Point(34, 81);
            this.classroomLabel.Name = "classroomLabel";
            this.classroomLabel.Size = new System.Drawing.Size(76, 17);
            this.classroomLabel.TabIndex = 1;
            this.classroomLabel.Text = "Classroom:";
            // 
            // teacherLabel
            // 
            this.teacherLabel.AutoSize = true;
            this.teacherLabel.Location = new System.Drawing.Point(34, 128);
            this.teacherLabel.Name = "teacherLabel";
            this.teacherLabel.Size = new System.Drawing.Size(62, 17);
            this.teacherLabel.TabIndex = 2;
            this.teacherLabel.Text = "Teacher:";
            // 
            // dayOfWeekLabel
            // 
            this.dayOfWeekLabel.AutoSize = true;
            this.dayOfWeekLabel.Location = new System.Drawing.Point(34, 175);
            this.dayOfWeekLabel.Name = "dayOfWeekLabel";
            this.dayOfWeekLabel.Size = new System.Drawing.Size(93, 17);
            this.dayOfWeekLabel.TabIndex = 3;
            this.dayOfWeekLabel.Text = "Day of Week:";
            // 
            // startTimeLabel
            // 
            this.startTimeLabel.AutoSize = true;
            this.startTimeLabel.Location = new System.Drawing.Point(34, 222);
            this.startTimeLabel.Name = "startTimeLabel";
            this.startTimeLabel.Size = new System.Drawing.Size(76, 17);
            this.startTimeLabel.TabIndex = 4;
            this.startTimeLabel.Text = "Start Time:";
            // 
            // endTimeLabel
            // 
            this.endTimeLabel.AutoSize = true;
            this.endTimeLabel.Location = new System.Drawing.Point(34, 269);
            this.endTimeLabel.Name = "endTimeLabel";
            this.endTimeLabel.Size = new System.Drawing.Size(70, 17);
            this.endTimeLabel.TabIndex = 5;
            this.endTimeLabel.Text = "End Time:";
            // 
            // classComboBox
            // 
            this.classComboBox.FormattingEnabled = true;
            this.classComboBox.Location = new System.Drawing.Point(131, 31);
            this.classComboBox.Name = "classComboBox";
            this.classComboBox.Size = new System.Drawing.Size(200, 24);
            this.classComboBox.TabIndex = 6;
            // 
            // classroomComboBox
            // 
            this.classroomComboBox.FormattingEnabled = true;
            this.classroomComboBox.Location = new System.Drawing.Point(131, 78);
            this.classroomComboBox.Name = "classroomComboBox";
            this.classroomComboBox.Size = new System.Drawing.Size(200, 24);
            this.classroomComboBox.TabIndex = 7;
            // 
            // classSessionComboBox
            // 
            this.classSessionComboBox.FormattingEnabled = true;
            this.classSessionComboBox.Location = new System.Drawing.Point(131, 125);
            this.classSessionComboBox.Name = "classSessionComboBox";
            this.classSessionComboBox.Size = new System.Drawing.Size(200, 24);
            this.classSessionComboBox.TabIndex = 8;
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
            this.dayOfWeekComboBox.Location = new System.Drawing.Point(131, 172);
            this.dayOfWeekComboBox.Name = "dayOfWeekComboBox";
            this.dayOfWeekComboBox.Size = new System.Drawing.Size(200, 24);
            this.dayOfWeekComboBox.TabIndex = 9;
            // 
            // startTimePicker
            // 
            this.startTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.startTimePicker.Location = new System.Drawing.Point(131, 219);
            this.startTimePicker.Name = "startTimePicker";
            this.startTimePicker.ShowUpDown = true;
            this.startTimePicker.Size = new System.Drawing.Size(200, 24);
            this.startTimePicker.TabIndex = 10;
            // 
            // endTimePicker
            // 
            this.endTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.endTimePicker.Location = new System.Drawing.Point(131, 266);
            this.endTimePicker.Name = "endTimePicker";
            this.endTimePicker.ShowUpDown = true;
            this.endTimePicker.Size = new System.Drawing.Size(200, 24);
            this.endTimePicker.TabIndex = 11;
            // 
            // updateScheduleButton
            // 
            this.updateScheduleButton.Location = new System.Drawing.Point(131, 334);
            this.updateScheduleButton.Name = "updateScheduleButton";
            this.updateScheduleButton.Size = new System.Drawing.Size(100, 35);
            this.updateScheduleButton.TabIndex = 12;
            this.updateScheduleButton.Text = "Update";
            this.updateScheduleButton.UseVisualStyleBackColor = true;
            this.updateScheduleButton.Click += new System.EventHandler(this.updateScheduleButton_Click);
            // 
            // cancelScheduleButton
            // 
            this.cancelScheduleButton.Location = new System.Drawing.Point(237, 334);
            this.cancelScheduleButton.Name = "cancelScheduleButton";
            this.cancelScheduleButton.Size = new System.Drawing.Size(94, 35);
            this.cancelScheduleButton.TabIndex = 13;
            this.cancelScheduleButton.Text = "Cancel";
            this.cancelScheduleButton.UseVisualStyleBackColor = true;
            this.cancelScheduleButton.Click += new System.EventHandler(this.cancelScheduleButton_Click);
            // 
            // EditScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 450);
            this.Controls.Add(this.cancelScheduleButton);
            this.Controls.Add(this.updateScheduleButton);
            this.Controls.Add(this.endTimePicker);
            this.Controls.Add(this.startTimePicker);
            this.Controls.Add(this.dayOfWeekComboBox);
            this.Controls.Add(this.classSessionComboBox);
            this.Controls.Add(this.classroomComboBox);
            this.Controls.Add(this.classComboBox);
            this.Controls.Add(this.endTimeLabel);
            this.Controls.Add(this.startTimeLabel);
            this.Controls.Add(this.dayOfWeekLabel);
            this.Controls.Add(this.teacherLabel);
            this.Controls.Add(this.classroomLabel);
            this.Controls.Add(this.classLabel);
            this.Name = "EditScheduleForm";
            this.Text = "Edit Schedule";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}