namespace Student_Study_Palnner
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.StudyPlannerLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.contextMenuStrip4 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.option2 = new System.Windows.Forms.ToolStripMenuItem();
            this.opti = new System.Windows.Forms.ToolStripMenuItem();
            this.o = new System.Windows.Forms.ToolStripMenuItem();
            this.button3 = new System.Windows.Forms.Button();
            this.quoteLabel = new System.Windows.Forms.Label();
            this.lblWeeklyGoal = new System.Windows.Forms.Label();
            this.lblProgramName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // StudyPlannerLabel
            // 
            this.StudyPlannerLabel.AutoSize = true;
            this.StudyPlannerLabel.Font = new System.Drawing.Font("Tahoma", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudyPlannerLabel.ForeColor = System.Drawing.Color.White;
            this.StudyPlannerLabel.Location = new System.Drawing.Point(231, 50);
            this.StudyPlannerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StudyPlannerLabel.Name = "StudyPlannerLabel";
            this.StudyPlannerLabel.Size = new System.Drawing.Size(127, 23);
            this.StudyPlannerLabel.TabIndex = 0;
            this.StudyPlannerLabel.Text = "Study Planner";
            this.StudyPlannerLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(223)))), ((int)(((byte)(225)))));
            this.exitButton.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(70)))), ((int)(((byte)(98)))));
            this.exitButton.Location = new System.Drawing.Point(128, 302);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(99, 40);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(223)))), ((int)(((byte)(225)))));
            this.button2.ContextMenuStrip = this.contextMenuStrip4;
            this.button2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(70)))), ((int)(((byte)(98)))));
            this.button2.Location = new System.Drawing.Point(86, 246);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 41);
            this.button2.TabIndex = 6;
            this.button2.Text = "Settings";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // contextMenuStrip4
            // 
            this.contextMenuStrip4.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.option2,
            this.opti,
            this.o});
            this.contextMenuStrip4.Name = "contextMenuStrip4";
            this.contextMenuStrip4.Size = new System.Drawing.Size(214, 70);
            this.contextMenuStrip4.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip4_Opening);
            // 
            // option2
            // 
            this.option2.Name = "option2";
            this.option2.Size = new System.Drawing.Size(213, 22);
            this.option2.Text = "Monthly subject summary";
            this.option2.Click += new System.EventHandler(this.option2_Click);
            // 
            // opti
            // 
            this.opti.Name = "opti";
            this.opti.Size = new System.Drawing.Size(213, 22);
            this.opti.Text = "Tracking progress";
            this.opti.Click += new System.EventHandler(this.opti_Click);
            // 
            // o
            // 
            this.o.Name = "o";
            this.o.Size = new System.Drawing.Size(213, 22);
            this.o.Text = "Set weakly goal";
            this.o.Click += new System.EventHandler(this.o_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(223)))), ((int)(((byte)(225)))));
            this.button3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(70)))), ((int)(((byte)(98)))));
            this.button3.Location = new System.Drawing.Point(86, 188);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(183, 44);
            this.button3.TabIndex = 8;
            this.button3.Text = "Start Planning";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // quoteLabel
            // 
            this.quoteLabel.AutoSize = true;
            this.quoteLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.quoteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quoteLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(150)))), ((int)(((byte)(171)))));
            this.quoteLabel.Location = new System.Drawing.Point(75, 83);
            this.quoteLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.quoteLabel.Name = "quoteLabel";
            this.quoteLabel.Size = new System.Drawing.Size(268, 20);
            this.quoteLabel.TabIndex = 10;
            this.quoteLabel.Text = "\"Success is built on daily effort.\"";
            this.quoteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.quoteLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblWeeklyGoal
            // 
            this.lblWeeklyGoal.AutoSize = true;
            this.lblWeeklyGoal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.lblWeeklyGoal.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeeklyGoal.ForeColor = System.Drawing.Color.Crimson;
            this.lblWeeklyGoal.Location = new System.Drawing.Point(12, 419);
            this.lblWeeklyGoal.Name = "lblWeeklyGoal";
            this.lblWeeklyGoal.Size = new System.Drawing.Size(39, 14);
            this.lblWeeklyGoal.TabIndex = 10;
            this.lblWeeklyGoal.Text = "Goals";
            this.lblWeeklyGoal.Click += new System.EventHandler(this.UpdateWeeklyGoalLabel_Click);
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
            this.lblProgramName.Size = new System.Drawing.Size(264, 42);
            this.lblProgramName.TabIndex = 11;
            this.lblProgramName.Text = "Study Planner\r\n";
            this.lblProgramName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(363, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(722, 730);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(74, 77);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(830, 497);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblProgramName);
            this.Controls.Add(this.quoteLabel);
            this.Controls.Add(this.lblWeeklyGoal);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.StudyPlannerLabel);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Planner Program";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StudyPlannerLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip4;
        private System.Windows.Forms.ToolStripMenuItem option2;
        private System.Windows.Forms.ToolStripMenuItem opti;
        private System.Windows.Forms.ToolStripMenuItem o;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label quoteLabel;
        private System.Windows.Forms.Label lblWeeklyGoal;
        private System.Windows.Forms.Label lblProgramName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

