namespace Student_Study_Palnner
{
    partial class AddTask
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTask));
            this.label1 = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.radioHigh = new System.Windows.Forms.RadioButton();
            this.radioMedium = new System.Windows.Forms.RadioButton();
            this.radioLow = new System.Windows.Forms.RadioButton();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.addButton_Click = new System.Windows.Forms.Button();
            this.hoursNumeric = new System.Windows.Forms.NumericUpDown();
            this.minutesNumeric = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.lblHoursError = new System.Windows.Forms.Label();
            this.TitleError = new System.Windows.Forms.Label();
            this.lblSubjectError = new System.Windows.Forms.Label();
            this.lblTypeError = new System.Windows.Forms.Label();
            this.lblPriorityError = new System.Windows.Forms.Label();
            this.lblDateError = new System.Windows.Forms.Label();
            this.lblTitleValidation = new System.Windows.Forms.Label();
            this.lblSubjectValidation = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblProgramName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hoursNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTextBox.Location = new System.Drawing.Point(296, 112);
            this.titleTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(206, 26);
            this.titleTextBox.TabIndex = 1;
            this.titleTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.titleTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.titleTextBox_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(203, 233);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date Due";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(203, 342);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hours";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(203, 185);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Type";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(203, 278);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Priority";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(203, 150);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "Subject";
            // 
            // datePicker
            // 
            this.datePicker.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(296, 233);
            this.datePicker.Margin = new System.Windows.Forms.Padding(2);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(206, 26);
            this.datePicker.TabIndex = 8;
            this.datePicker.ValueChanged += new System.EventHandler(this.datePicker_ValueChanged);
            // 
            // typeComboBox
            // 
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Exam",
            "Assignment",
            "Quiz",
            "Study Session"});
            this.typeComboBox.Location = new System.Drawing.Point(296, 189);
            this.typeComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(206, 26);
            this.typeComboBox.TabIndex = 9;
            this.typeComboBox.SelectedIndexChanged += new System.EventHandler(this.typeComboBox_SelectedIndexChanged);
            // 
            // radioHigh
            // 
            this.radioHigh.AutoSize = true;
            this.radioHigh.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioHigh.Location = new System.Drawing.Point(296, 279);
            this.radioHigh.Margin = new System.Windows.Forms.Padding(2);
            this.radioHigh.Name = "radioHigh";
            this.radioHigh.Size = new System.Drawing.Size(60, 23);
            this.radioHigh.TabIndex = 10;
            this.radioHigh.TabStop = true;
            this.radioHigh.Text = "High";
            this.radioHigh.UseVisualStyleBackColor = true;
            // 
            // radioMedium
            // 
            this.radioMedium.AutoSize = true;
            this.radioMedium.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMedium.Location = new System.Drawing.Point(359, 279);
            this.radioMedium.Margin = new System.Windows.Forms.Padding(2);
            this.radioMedium.Name = "radioMedium";
            this.radioMedium.Size = new System.Drawing.Size(83, 23);
            this.radioMedium.TabIndex = 11;
            this.radioMedium.TabStop = true;
            this.radioMedium.Text = "Medium";
            this.radioMedium.UseVisualStyleBackColor = true;
            this.radioMedium.CheckedChanged += new System.EventHandler(this.radioMedium_CheckedChanged);
            // 
            // radioLow
            // 
            this.radioLow.AutoSize = true;
            this.radioLow.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioLow.Location = new System.Drawing.Point(446, 279);
            this.radioLow.Margin = new System.Windows.Forms.Padding(2);
            this.radioLow.Name = "radioLow";
            this.radioLow.Size = new System.Drawing.Size(56, 23);
            this.radioLow.TabIndex = 12;
            this.radioLow.TabStop = true;
            this.radioLow.Text = "Low";
            this.radioLow.UseVisualStyleBackColor = true;
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectTextBox.Location = new System.Drawing.Point(296, 150);
            this.subjectTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(206, 26);
            this.subjectTextBox.TabIndex = 13;
            this.subjectTextBox.TextChanged += new System.EventHandler(this.subjectTextBox_TextChanged);
            this.subjectTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.subjectTextBox_Validating);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(223)))), ((int)(((byte)(225)))));
            this.button1.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(70)))), ((int)(((byte)(98)))));
            this.button1.Location = new System.Drawing.Point(23, 412);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 48);
            this.button1.TabIndex = 14;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addButton_Click
            // 
            this.addButton_Click.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(223)))), ((int)(((byte)(225)))));
            this.addButton_Click.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold);
            this.addButton_Click.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(70)))), ((int)(((byte)(98)))));
            this.addButton_Click.Location = new System.Drawing.Point(601, 412);
            this.addButton_Click.Margin = new System.Windows.Forms.Padding(2);
            this.addButton_Click.Name = "addButton_Click";
            this.addButton_Click.Size = new System.Drawing.Size(93, 48);
            this.addButton_Click.TabIndex = 15;
            this.addButton_Click.Text = "Add";
            this.addButton_Click.UseVisualStyleBackColor = false;
            this.addButton_Click.Click += new System.EventHandler(this.button2_Click);
            // 
            // hoursNumeric
            // 
            this.hoursNumeric.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.hoursNumeric.Location = new System.Drawing.Point(266, 342);
            this.hoursNumeric.Margin = new System.Windows.Forms.Padding(2);
            this.hoursNumeric.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.hoursNumeric.Name = "hoursNumeric";
            this.hoursNumeric.Size = new System.Drawing.Size(71, 26);
            this.hoursNumeric.TabIndex = 16;
            this.hoursNumeric.ValueChanged += new System.EventHandler(this.hoursNumeric_ValueChanged);
            // 
            // minutesNumeric
            // 
            this.minutesNumeric.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.minutesNumeric.Location = new System.Drawing.Point(420, 342);
            this.minutesNumeric.Margin = new System.Windows.Forms.Padding(2);
            this.minutesNumeric.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minutesNumeric.Name = "minutesNumeric";
            this.minutesNumeric.Size = new System.Drawing.Size(71, 26);
            this.minutesNumeric.TabIndex = 17;
            this.minutesNumeric.ValueChanged += new System.EventHandler(this.minutesNumeric_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.label7.Location = new System.Drawing.Point(341, 342);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 23);
            this.label7.TabIndex = 18;
            this.label7.Text = "Minutes";
            // 
            // lblHoursError
            // 
            this.lblHoursError.AutoSize = true;
            this.lblHoursError.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoursError.ForeColor = System.Drawing.Color.Red;
            this.lblHoursError.Location = new System.Drawing.Point(173, 340);
            this.lblHoursError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoursError.Name = "lblHoursError";
            this.lblHoursError.Size = new System.Drawing.Size(30, 23);
            this.lblHoursError.TabIndex = 20;
            this.lblHoursError.Text = "**";
            this.lblHoursError.Visible = false;
            // 
            // TitleError
            // 
            this.TitleError.AutoSize = true;
            this.TitleError.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleError.ForeColor = System.Drawing.Color.Red;
            this.TitleError.Location = new System.Drawing.Point(173, 112);
            this.TitleError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TitleError.Name = "TitleError";
            this.TitleError.Size = new System.Drawing.Size(30, 23);
            this.TitleError.TabIndex = 21;
            this.TitleError.Text = "**";
            this.TitleError.Visible = false;
            this.TitleError.Click += new System.EventHandler(this.errorLabel1_Click);
            // 
            // lblSubjectError
            // 
            this.lblSubjectError.AutoSize = true;
            this.lblSubjectError.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubjectError.ForeColor = System.Drawing.Color.Red;
            this.lblSubjectError.Location = new System.Drawing.Point(173, 149);
            this.lblSubjectError.Name = "lblSubjectError";
            this.lblSubjectError.Size = new System.Drawing.Size(30, 23);
            this.lblSubjectError.TabIndex = 23;
            this.lblSubjectError.Text = "**";
            this.lblSubjectError.Visible = false;
            this.lblSubjectError.Click += new System.EventHandler(this.errorLabel_Subject_Click);
            // 
            // lblTypeError
            // 
            this.lblTypeError.AutoSize = true;
            this.lblTypeError.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeError.ForeColor = System.Drawing.Color.Red;
            this.lblTypeError.Location = new System.Drawing.Point(173, 188);
            this.lblTypeError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTypeError.Name = "lblTypeError";
            this.lblTypeError.Size = new System.Drawing.Size(30, 23);
            this.lblTypeError.TabIndex = 24;
            this.lblTypeError.Text = "**";
            this.lblTypeError.Visible = false;
            // 
            // lblPriorityError
            // 
            this.lblPriorityError.AutoSize = true;
            this.lblPriorityError.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriorityError.ForeColor = System.Drawing.Color.Red;
            this.lblPriorityError.Location = new System.Drawing.Point(173, 278);
            this.lblPriorityError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPriorityError.Name = "lblPriorityError";
            this.lblPriorityError.Size = new System.Drawing.Size(30, 23);
            this.lblPriorityError.TabIndex = 25;
            this.lblPriorityError.Text = "**";
            this.lblPriorityError.Visible = false;
            // 
            // lblDateError
            // 
            this.lblDateError.AutoSize = true;
            this.lblDateError.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateError.ForeColor = System.Drawing.Color.Red;
            this.lblDateError.Location = new System.Drawing.Point(173, 233);
            this.lblDateError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateError.Name = "lblDateError";
            this.lblDateError.Size = new System.Drawing.Size(30, 23);
            this.lblDateError.TabIndex = 26;
            this.lblDateError.Text = "**";
            this.lblDateError.Visible = false;
            // 
            // lblTitleValidation
            // 
            this.lblTitleValidation.AutoSize = true;
            this.lblTitleValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleValidation.ForeColor = System.Drawing.Color.Red;
            this.lblTitleValidation.Location = new System.Drawing.Point(521, 117);
            this.lblTitleValidation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitleValidation.Name = "lblTitleValidation";
            this.lblTitleValidation.Size = new System.Drawing.Size(25, 15);
            this.lblTitleValidation.TabIndex = 27;
            this.lblTitleValidation.Text = "XX";
            this.lblTitleValidation.Visible = false;
            // 
            // lblSubjectValidation
            // 
            this.lblSubjectValidation.AutoSize = true;
            this.lblSubjectValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubjectValidation.ForeColor = System.Drawing.Color.Red;
            this.lblSubjectValidation.Location = new System.Drawing.Point(521, 161);
            this.lblSubjectValidation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubjectValidation.Name = "lblSubjectValidation";
            this.lblSubjectValidation.Size = new System.Drawing.Size(25, 15);
            this.lblSubjectValidation.TabIndex = 30;
            this.lblSubjectValidation.Text = "XX";
            this.lblSubjectValidation.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(74, 77);
            this.pictureBox2.TabIndex = 32;
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
            this.lblProgramName.Size = new System.Drawing.Size(177, 42);
            this.lblProgramName.TabIndex = 31;
            this.lblProgramName.Text = "Add Task";
            this.lblProgramName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(735, 490);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblProgramName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSubjectValidation);
            this.Controls.Add(this.lblTitleValidation);
            this.Controls.Add(this.lblDateError);
            this.Controls.Add(this.lblPriorityError);
            this.Controls.Add(this.lblTypeError);
            this.Controls.Add(this.lblSubjectError);
            this.Controls.Add(this.lblHoursError);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.minutesNumeric);
            this.Controls.Add(this.hoursNumeric);
            this.Controls.Add(this.addButton_Click);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.subjectTextBox);
            this.Controls.Add(this.radioLow);
            this.Controls.Add(this.radioMedium);
            this.Controls.Add(this.radioHigh);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.TitleError);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddTask";
            this.Load += new System.EventHandler(this.AddTask_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hoursNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.RadioButton radioHigh;
        private System.Windows.Forms.RadioButton radioMedium;
        private System.Windows.Forms.RadioButton radioLow;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button addButton_Click;
        private System.Windows.Forms.NumericUpDown hoursNumeric;
        private System.Windows.Forms.NumericUpDown minutesNumeric;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblHoursError;
        private System.Windows.Forms.Label TitleError;
        private System.Windows.Forms.Label lblSubjectError;
        private System.Windows.Forms.Label lblTypeError;
        private System.Windows.Forms.Label lblPriorityError;
        private System.Windows.Forms.Label lblDateError;
        private System.Windows.Forms.Label lblTitleValidation;
        private System.Windows.Forms.Label lblSubjectValidation;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblProgramName;
    }
}