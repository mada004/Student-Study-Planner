// ريماس - EditTask.Designer.cs
// هذا الملف يحدد شكل وترتيب جميع عناصر فورم التعديل
// مبني بنفس أسلوب AddTask.Designer.cs للتناسق

namespace Student_Study_Palnner
{
    partial class EditTask
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTask));
            this.label1 = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.radioHigh = new System.Windows.Forms.RadioButton();
            this.radioMedium = new System.Windows.Forms.RadioButton();
            this.radioLow = new System.Windows.Forms.RadioButton();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.hoursNumeric = new System.Windows.Forms.NumericUpDown();
            this.minutesNumeric = new System.Windows.Forms.NumericUpDown();
            this.cancelButton = new System.Windows.Forms.Button();
            this.lblTitleError = new System.Windows.Forms.Label();
            this.lblSubjectError = new System.Windows.Forms.Label();
            this.lblDateError = new System.Windows.Forms.Label();
            this.lblHoursError = new System.Windows.Forms.Label();
            this.lblTypeError = new System.Windows.Forms.Label();
            this.lblPriorityError = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblProgramName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hoursNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.label1.Location = new System.Drawing.Point(175, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.titleTextBox.Location = new System.Drawing.Point(273, 116);
            this.titleTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(206, 26);
            this.titleTextBox.TabIndex = 1;
            this.titleTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.titleTextBox_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.label2.Location = new System.Drawing.Point(173, 246);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date Due";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.label3.Location = new System.Drawing.Point(180, 358);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hours";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.label4.Location = new System.Drawing.Point(173, 201);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.label5.Location = new System.Drawing.Point(173, 296);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Priority";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.label6.Location = new System.Drawing.Point(175, 151);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "Subject";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.label7.Location = new System.Drawing.Point(326, 358);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 23);
            this.label7.TabIndex = 18;
            this.label7.Text = "Minutes";
            // 
            // datePicker
            // 
            this.datePicker.CalendarFont = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(273, 244);
            this.datePicker.Margin = new System.Windows.Forms.Padding(2);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(206, 26);
            this.datePicker.TabIndex = 4;
            this.datePicker.Value = new System.DateTime(2026, 3, 5, 0, 0, 0, 0);
            // 
            // typeComboBox
            // 
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Exam",
            "Assignment",
            "Quiz",
            "Study Session"});
            this.typeComboBox.Location = new System.Drawing.Point(273, 193);
            this.typeComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(206, 26);
            this.typeComboBox.TabIndex = 3;
            // 
            // radioHigh
            // 
            this.radioHigh.AutoSize = true;
            this.radioHigh.Font = new System.Drawing.Font("Tahoma", 12F);
            this.radioHigh.Location = new System.Drawing.Point(273, 297);
            this.radioHigh.Margin = new System.Windows.Forms.Padding(2);
            this.radioHigh.Name = "radioHigh";
            this.radioHigh.Size = new System.Drawing.Size(60, 23);
            this.radioHigh.TabIndex = 7;
            this.radioHigh.Text = "High";
            // 
            // radioMedium
            // 
            this.radioMedium.AutoSize = true;
            this.radioMedium.Font = new System.Drawing.Font("Tahoma", 12F);
            this.radioMedium.Location = new System.Drawing.Point(333, 297);
            this.radioMedium.Margin = new System.Windows.Forms.Padding(2);
            this.radioMedium.Name = "radioMedium";
            this.radioMedium.Size = new System.Drawing.Size(83, 23);
            this.radioMedium.TabIndex = 8;
            this.radioMedium.Text = "Medium";
            // 
            // radioLow
            // 
            this.radioLow.AutoSize = true;
            this.radioLow.Font = new System.Drawing.Font("Tahoma", 12F);
            this.radioLow.Location = new System.Drawing.Point(420, 297);
            this.radioLow.Margin = new System.Windows.Forms.Padding(2);
            this.radioLow.Name = "radioLow";
            this.radioLow.Size = new System.Drawing.Size(56, 23);
            this.radioLow.TabIndex = 9;
            this.radioLow.Text = "Low";
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.subjectTextBox.Location = new System.Drawing.Point(273, 151);
            this.subjectTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(206, 26);
            this.subjectTextBox.TabIndex = 2;
            this.subjectTextBox.TextChanged += new System.EventHandler(this.subjectTextBox_TextChanged);
            this.subjectTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.subjectTextBox_Validating);
            // 
            // hoursNumeric
            // 
            this.hoursNumeric.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.hoursNumeric.Location = new System.Drawing.Point(243, 360);
            this.hoursNumeric.Margin = new System.Windows.Forms.Padding(2);
            this.hoursNumeric.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.hoursNumeric.Name = "hoursNumeric";
            this.hoursNumeric.Size = new System.Drawing.Size(71, 26);
            this.hoursNumeric.TabIndex = 5;
            // 
            // minutesNumeric
            // 
            this.minutesNumeric.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.minutesNumeric.Location = new System.Drawing.Point(405, 360);
            this.minutesNumeric.Margin = new System.Windows.Forms.Padding(2);
            this.minutesNumeric.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minutesNumeric.Name = "minutesNumeric";
            this.minutesNumeric.Size = new System.Drawing.Size(71, 26);
            this.minutesNumeric.TabIndex = 6;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(223)))), ((int)(((byte)(225)))));
            this.cancelButton.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold);
            this.cancelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(70)))), ((int)(((byte)(98)))));
            this.cancelButton.Location = new System.Drawing.Point(23, 412);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(93, 48);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // lblTitleError
            // 
            this.lblTitleError.AutoSize = true;
            this.lblTitleError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleError.ForeColor = System.Drawing.Color.Red;
            this.lblTitleError.Location = new System.Drawing.Point(483, 121);
            this.lblTitleError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitleError.Name = "lblTitleError";
            this.lblTitleError.Size = new System.Drawing.Size(151, 13);
            this.lblTitleError.TabIndex = 20;
            this.lblTitleError.Text = "⚠ Title cannot be empty!";
            this.lblTitleError.Visible = false;
            // 
            // lblSubjectError
            // 
            this.lblSubjectError.AutoSize = true;
            this.lblSubjectError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubjectError.ForeColor = System.Drawing.Color.Red;
            this.lblSubjectError.Location = new System.Drawing.Point(483, 161);
            this.lblSubjectError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubjectError.Name = "lblSubjectError";
            this.lblSubjectError.Size = new System.Drawing.Size(169, 13);
            this.lblSubjectError.TabIndex = 21;
            this.lblSubjectError.Text = "⚠ Subject cannot be empty!";
            this.lblSubjectError.Visible = false;
            // 
            // lblDateError
            // 
            this.lblDateError.AutoSize = true;
            this.lblDateError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateError.ForeColor = System.Drawing.Color.Red;
            this.lblDateError.Location = new System.Drawing.Point(483, 246);
            this.lblDateError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateError.Name = "lblDateError";
            this.lblDateError.Size = new System.Drawing.Size(180, 13);
            this.lblDateError.TabIndex = 22;
            this.lblDateError.Text = "⚠ Date cannot be in the past!";
            this.lblDateError.Visible = false;
            // 
            // lblHoursError
            // 
            this.lblHoursError.AutoSize = true;
            this.lblHoursError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoursError.ForeColor = System.Drawing.Color.Red;
            this.lblHoursError.Location = new System.Drawing.Point(483, 366);
            this.lblHoursError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoursError.Name = "lblHoursError";
            this.lblHoursError.Size = new System.Drawing.Size(144, 13);
            this.lblHoursError.TabIndex = 23;
            this.lblHoursError.Text = "⚠ Time cannot be zero!";
            this.lblHoursError.Visible = false;
            // 
            // lblTypeError
            // 
            this.lblTypeError.AutoSize = true;
            this.lblTypeError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeError.ForeColor = System.Drawing.Color.Red;
            this.lblTypeError.Location = new System.Drawing.Point(483, 200);
            this.lblTypeError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTypeError.Name = "lblTypeError";
            this.lblTypeError.Size = new System.Drawing.Size(143, 13);
            this.lblTypeError.TabIndex = 24;
            this.lblTypeError.Text = "⚠ Please select a type!";
            this.lblTypeError.Visible = false;
            // 
            // lblPriorityError
            // 
            this.lblPriorityError.AutoSize = true;
            this.lblPriorityError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriorityError.ForeColor = System.Drawing.Color.Red;
            this.lblPriorityError.Location = new System.Drawing.Point(481, 304);
            this.lblPriorityError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPriorityError.Name = "lblPriorityError";
            this.lblPriorityError.Size = new System.Drawing.Size(157, 13);
            this.lblPriorityError.TabIndex = 25;
            this.lblPriorityError.Text = "⚠ Please select a priority!";
            this.lblPriorityError.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(74, 77);
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // lblProgramName
            // 
            this.lblProgramName.AutoSize = true;
            this.lblProgramName.BackColor = System.Drawing.Color.Transparent;
            this.lblProgramName.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgramName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(70)))), ((int)(((byte)(98)))));
            this.lblProgramName.Location = new System.Drawing.Point(79, 31);
            this.lblProgramName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProgramName.Name = "lblProgramName";
            this.lblProgramName.Size = new System.Drawing.Size(179, 42);
            this.lblProgramName.TabIndex = 33;
            this.lblProgramName.Text = "Edit Task";
            this.lblProgramName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(223)))), ((int)(((byte)(225)))));
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(70)))), ((int)(((byte)(98)))));
            this.btnSave.Location = new System.Drawing.Point(601, 412);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 48);
            this.btnSave.TabIndex = 35;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // EditTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(735, 490);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblProgramName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.subjectTextBox);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.hoursNumeric);
            this.Controls.Add(this.minutesNumeric);
            this.Controls.Add(this.radioHigh);
            this.Controls.Add(this.radioMedium);
            this.Controls.Add(this.radioLow);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.lblTitleError);
            this.Controls.Add(this.lblSubjectError);
            this.Controls.Add(this.lblDateError);
            this.Controls.Add(this.lblHoursError);
            this.Controls.Add(this.lblTypeError);
            this.Controls.Add(this.lblPriorityError);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EditTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Task";
            this.Load += new System.EventHandler(this.EditTask_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hoursNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1, label2, label3, label4, label5, label6, label7;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.RadioButton radioHigh, radioMedium, radioLow;
        private System.Windows.Forms.NumericUpDown hoursNumeric, minutesNumeric;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label lblTitleError, lblSubjectError, lblDateError;
        private System.Windows.Forms.Label lblHoursError, lblTypeError, lblPriorityError;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblProgramName;
        private System.Windows.Forms.Button btnSave;
    }
}
