namespace Student_Study_Palnner
{
    partial class view
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(view));
            this.daterange = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.viewGrid = new System.Windows.Forms.DataGridView();
            this.filterDateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.From = new System.Windows.Forms.Label();
            this.toDate = new System.Windows.Forms.DateTimePicker();
            this.fromDate = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.viewGridPriority = new System.Windows.Forms.DataGridView();
            this.filterPriorityButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.priorityCombo = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.viewGridType = new System.Windows.Forms.DataGridView();
            this.filterTypeButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.typeCombo = new System.Windows.Forms.ComboBox();
            this.BackBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblProgramName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.daterange.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewGrid)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewGridPriority)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewGridType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // daterange
            // 
            this.daterange.Controls.Add(this.tabPage1);
            this.daterange.Controls.Add(this.tabPage2);
            this.daterange.Controls.Add(this.tabPage3);
            this.daterange.Cursor = System.Windows.Forms.Cursors.Default;
            this.daterange.Location = new System.Drawing.Point(39, 96);
            this.daterange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.daterange.Name = "daterange";
            this.daterange.SelectedIndex = 0;
            this.daterange.Size = new System.Drawing.Size(769, 355);
            this.daterange.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.viewGrid);
            this.tabPage1.Controls.Add(this.filterDateButton);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.From);
            this.tabPage1.Controls.Add(this.toDate);
            this.tabPage1.Controls.Add(this.fromDate);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(761, 329);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Date range";
            // 
            // viewGrid
            // 
            this.viewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewGrid.Location = new System.Drawing.Point(6, 51);
            this.viewGrid.Name = "viewGrid";
            this.viewGrid.RowHeadersWidth = 51;
            this.viewGrid.RowTemplate.Height = 26;
            this.viewGrid.Size = new System.Drawing.Size(753, 278);
            this.viewGrid.TabIndex = 5;
            this.viewGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewGrid_CellContentClick);
            // 
            // filterDateButton
            // 
            this.filterDateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(223)))), ((int)(((byte)(225)))));
            this.filterDateButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterDateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(70)))), ((int)(((byte)(98)))));
            this.filterDateButton.Location = new System.Drawing.Point(505, 16);
            this.filterDateButton.Name = "filterDateButton";
            this.filterDateButton.Size = new System.Drawing.Size(94, 28);
            this.filterDateButton.TabIndex = 4;
            this.filterDateButton.Text = "Filter";
            this.filterDateButton.UseVisualStyleBackColor = false;
            this.filterDateButton.Click += new System.EventHandler(this.filterDateButton_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "To";
            // 
            // From
            // 
            this.From.AutoSize = true;
            this.From.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.From.Location = new System.Drawing.Point(6, 18);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(38, 16);
            this.From.TabIndex = 2;
            this.From.Text = "From";
            this.From.Click += new System.EventHandler(this.From_Click);
            // 
            // toDate
            // 
            this.toDate.CalendarFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDate.Location = new System.Drawing.Point(300, 18);
            this.toDate.Name = "toDate";
            this.toDate.Size = new System.Drawing.Size(199, 20);
            this.toDate.TabIndex = 1;
            // 
            // fromDate
            // 
            this.fromDate.Location = new System.Drawing.Point(54, 18);
            this.fromDate.Name = "fromDate";
            this.fromDate.Size = new System.Drawing.Size(199, 20);
            this.fromDate.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.viewGridPriority);
            this.tabPage2.Controls.Add(this.filterPriorityButton);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.priorityCombo);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(761, 329);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Priority";
            // 
            // viewGridPriority
            // 
            this.viewGridPriority.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewGridPriority.Location = new System.Drawing.Point(6, 51);
            this.viewGridPriority.Name = "viewGridPriority";
            this.viewGridPriority.RowHeadersWidth = 51;
            this.viewGridPriority.RowTemplate.Height = 26;
            this.viewGridPriority.Size = new System.Drawing.Size(753, 278);
            this.viewGridPriority.TabIndex = 3;
            this.viewGridPriority.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewGridPriority_CellContentClick);
            // 
            // filterPriorityButton
            // 
            this.filterPriorityButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(223)))), ((int)(((byte)(225)))));
            this.filterPriorityButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterPriorityButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(70)))), ((int)(((byte)(98)))));
            this.filterPriorityButton.Location = new System.Drawing.Point(565, 17);
            this.filterPriorityButton.Name = "filterPriorityButton";
            this.filterPriorityButton.Size = new System.Drawing.Size(94, 28);
            this.filterPriorityButton.TabIndex = 2;
            this.filterPriorityButton.Text = "Filter";
            this.filterPriorityButton.UseVisualStyleBackColor = false;
            this.filterPriorityButton.Click += new System.EventHandler(this.filterPriorityButton_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(351, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose the priority level you want to view tasks by: ";
            // 
            // priorityCombo
            // 
            this.priorityCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.priorityCombo.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priorityCombo.FormattingEnabled = true;
            this.priorityCombo.Items.AddRange(new object[] {
            "High",
            "Medium",
            "Low"});
            this.priorityCombo.Location = new System.Drawing.Point(360, 17);
            this.priorityCombo.Name = "priorityCombo";
            this.priorityCombo.Size = new System.Drawing.Size(199, 26);
            this.priorityCombo.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Transparent;
            this.tabPage3.Controls.Add(this.viewGridType);
            this.tabPage3.Controls.Add(this.filterTypeButton);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.typeCombo);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Size = new System.Drawing.Size(761, 329);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Type";
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // viewGridType
            // 
            this.viewGridType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewGridType.Location = new System.Drawing.Point(6, 51);
            this.viewGridType.Name = "viewGridType";
            this.viewGridType.RowHeadersWidth = 51;
            this.viewGridType.RowTemplate.Height = 26;
            this.viewGridType.Size = new System.Drawing.Size(753, 278);
            this.viewGridType.TabIndex = 3;
            this.viewGridType.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewGridType_CellContentClick);
            // 
            // filterTypeButton
            // 
            this.filterTypeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(223)))), ((int)(((byte)(225)))));
            this.filterTypeButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.filterTypeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(70)))), ((int)(((byte)(98)))));
            this.filterTypeButton.Location = new System.Drawing.Point(565, 17);
            this.filterTypeButton.Name = "filterTypeButton";
            this.filterTypeButton.Size = new System.Drawing.Size(94, 28);
            this.filterTypeButton.TabIndex = 2;
            this.filterTypeButton.Text = "Filter";
            this.filterTypeButton.UseVisualStyleBackColor = false;
            this.filterTypeButton.Click += new System.EventHandler(this.filterTypeButton_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(337, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Choose the type of the tasks you want to display: ";
            // 
            // typeCombo
            // 
            this.typeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeCombo.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeCombo.FormattingEnabled = true;
            this.typeCombo.Items.AddRange(new object[] {
            "Study Session",
            "Exam",
            "Quiz",
            "Assignment"});
            this.typeCombo.Location = new System.Drawing.Point(360, 17);
            this.typeCombo.Name = "typeCombo";
            this.typeCombo.Size = new System.Drawing.Size(199, 26);
            this.typeCombo.TabIndex = 0;
            this.typeCombo.SelectedIndexChanged += new System.EventHandler(this.typeCombo_SelectedIndexChanged);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(223)))), ((int)(((byte)(225)))));
            this.BackBtn.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold);
            this.BackBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(70)))), ((int)(((byte)(98)))));
            this.BackBtn.Location = new System.Drawing.Point(39, 559);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(93, 48);
            this.BackBtn.TabIndex = 6;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(74, 77);
            this.pictureBox2.TabIndex = 17;
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
            this.lblProgramName.Size = new System.Drawing.Size(349, 42);
            this.lblProgramName.TabIndex = 16;
            this.lblProgramName.Text = "Filtering The Tasks";
            this.lblProgramName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(808, -15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(722, 730);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(809, 480);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(722, 730);
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1254, 629);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblProgramName);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.daterange);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "view";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filter";
            this.Load += new System.EventHandler(this.view_Load);
            this.daterange.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewGrid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewGridPriority)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewGridType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl daterange;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label From;
        private System.Windows.Forms.DateTimePicker toDate;
        private System.Windows.Forms.DateTimePicker fromDate;
        private System.Windows.Forms.DataGridView viewGrid;
        private System.Windows.Forms.Button filterDateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox priorityCombo;
        private System.Windows.Forms.DataGridView viewGridPriority;
        private System.Windows.Forms.Button filterPriorityButton;
        private System.Windows.Forms.ComboBox typeCombo;
        private System.Windows.Forms.Button filterTypeButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView viewGridType;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblProgramName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}