namespace Student_Study_Palnner
{
    partial class Summary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Summary));
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SummaryGrid = new System.Windows.Forms.DataGridView();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblProgramName = new System.Windows.Forms.Label();
            this.CompletedHourslbl = new System.Windows.Forms.Label();
            this.TotalHourslbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SummaryGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(115, 117);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(188, 28);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(364, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Subject";
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectTextBox.Location = new System.Drawing.Point(453, 116);
            this.subjectTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(213, 28);
            this.subjectTextBox.TabIndex = 2;
            this.subjectTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(223)))), ((int)(((byte)(225)))));
            this.button1.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(70)))), ((int)(((byte)(98)))));
            this.button1.Location = new System.Drawing.Point(258, 477);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 43);
            this.button1.TabIndex = 3;
            this.button1.Text = "show summary";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(47, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Month";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(223)))), ((int)(((byte)(225)))));
            this.button3.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(70)))), ((int)(((byte)(98)))));
            this.button3.Location = new System.Drawing.Point(38, 531);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 48);
            this.button3.TabIndex = 8;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // SummaryGrid
            // 
            this.SummaryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SummaryGrid.Location = new System.Drawing.Point(51, 160);
            this.SummaryGrid.Name = "SummaryGrid";
            this.SummaryGrid.Size = new System.Drawing.Size(615, 200);
            this.SummaryGrid.TabIndex = 9;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(760, 285);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(722, 730);
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(759, -210);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(722, 730);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(74, 77);
            this.pictureBox2.TabIndex = 23;
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
            this.lblProgramName.Size = new System.Drawing.Size(184, 42);
            this.lblProgramName.TabIndex = 22;
            this.lblProgramName.Text = "Summary";
            this.lblProgramName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CompletedHourslbl
            // 
            this.CompletedHourslbl.AutoSize = true;
            this.CompletedHourslbl.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.CompletedHourslbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CompletedHourslbl.Location = new System.Drawing.Point(364, 372);
            this.CompletedHourslbl.Name = "CompletedHourslbl";
            this.CompletedHourslbl.Size = new System.Drawing.Size(214, 23);
            this.CompletedHourslbl.TabIndex = 24;
            this.CompletedHourslbl.Text = "Total Completed Hours: ";
            this.CompletedHourslbl.Visible = false;
            // 
            // TotalHourslbl
            // 
            this.TotalHourslbl.AutoSize = true;
            this.TotalHourslbl.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.TotalHourslbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TotalHourslbl.Location = new System.Drawing.Point(47, 372);
            this.TotalHourslbl.Name = "TotalHourslbl";
            this.TotalHourslbl.Size = new System.Drawing.Size(186, 23);
            this.TotalHourslbl.TabIndex = 25;
            this.TotalHourslbl.Text = "Total Planned Hours:";
            this.TotalHourslbl.Visible = false;
            // 
            // Summary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1254, 629);
            this.Controls.Add(this.TotalHourslbl);
            this.Controls.Add(this.CompletedHourslbl);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblProgramName);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SummaryGrid);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.subjectTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Summary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monthly subject summary";
            this.Load += new System.EventHandler(this.Summary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SummaryGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView SummaryGrid;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblProgramName;
        private System.Windows.Forms.Label CompletedHourslbl;
        private System.Windows.Forms.Label TotalHourslbl;
    }
}