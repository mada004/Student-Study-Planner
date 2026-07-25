// ريماس - Form3.Designer.cs (معدّل)
// التعديل: أضفت editButton في نفس منطقة أزرار add/delete/mark

namespace Student_Study_Palnner
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.AddTask = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.markButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.customViewButton = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.taskGrid = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblProgramName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // AddTask
            // 
            this.AddTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(223)))), ((int)(((byte)(225)))));
            this.AddTask.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold);
            this.AddTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(70)))), ((int)(((byte)(98)))));
            this.AddTask.Location = new System.Drawing.Point(1044, 99);
            this.AddTask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddTask.Name = "AddTask";
            this.AddTask.Size = new System.Drawing.Size(111, 50);
            this.AddTask.TabIndex = 0;
            this.AddTask.Text = "Add";
            this.AddTask.UseVisualStyleBackColor = false;
            this.AddTask.Click += new System.EventHandler(this.button1_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(223)))), ((int)(((byte)(225)))));
            this.deleteButton.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold);
            this.deleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(70)))), ((int)(((byte)(98)))));
            this.deleteButton.Location = new System.Drawing.Point(1044, 229);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(111, 50);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // markButton
            // 
            this.markButton.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold);
            this.markButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(70)))), ((int)(((byte)(98)))));
            this.markButton.Location = new System.Drawing.Point(1044, 382);
            this.markButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.markButton.Name = "markButton";
            this.markButton.Size = new System.Drawing.Size(111, 35);
            this.markButton.TabIndex = 2;
            this.markButton.Text = "Mark Done";
            this.markButton.UseVisualStyleBackColor = true;
            this.markButton.Click += new System.EventHandler(this.markButton_Click_1);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(223)))), ((int)(((byte)(225)))));
            this.editButton.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold);
            this.editButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(70)))), ((int)(((byte)(98)))));
            this.editButton.Location = new System.Drawing.Point(1044, 162);
            this.editButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(111, 50);
            this.editButton.TabIndex = 9;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // customViewButton
            // 
            this.customViewButton.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold);
            this.customViewButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(70)))), ((int)(((byte)(98)))));
            this.customViewButton.Location = new System.Drawing.Point(1044, 421);
            this.customViewButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customViewButton.Name = "customViewButton";
            this.customViewButton.Size = new System.Drawing.Size(111, 31);
            this.customViewButton.TabIndex = 3;
            this.customViewButton.Text = "Filter";
            this.customViewButton.UseVisualStyleBackColor = true;
            this.customViewButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(223)))), ((int)(((byte)(225)))));
            this.button7.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold);
            this.button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(70)))), ((int)(((byte)(98)))));
            this.button7.Location = new System.Drawing.Point(39, 559);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(93, 48);
            this.button7.TabIndex = 6;
            this.button7.Text = "back";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.taskGrid);
            this.panel1.Location = new System.Drawing.Point(39, 96);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(999, 361);
            this.panel1.TabIndex = 7;
            // 
            // taskGrid
            // 
            this.taskGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.taskGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.taskGrid.Location = new System.Drawing.Point(3, 3);
            this.taskGrid.Name = "taskGrid";
            this.taskGrid.RowHeadersWidth = 51;
            this.taskGrid.RowTemplate.Height = 50;
            this.taskGrid.Size = new System.Drawing.Size(993, 355);
            this.taskGrid.TabIndex = 0;
            this.taskGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.taskGrid_CellContentClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(74, 77);
            this.pictureBox2.TabIndex = 15;
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
            this.lblProgramName.Size = new System.Drawing.Size(117, 42);
            this.lblProgramName.TabIndex = 14;
            this.lblProgramName.Text = "Tasks";
            this.lblProgramName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(59, 226);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(655, 502);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(684, 207);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(348, 384);
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(335, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(703, 251);
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1254, 629);
            this.Controls.Add(this.customViewButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblProgramName);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.markButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.AddTask);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start Planning";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.taskGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button AddTask;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button markButton;
        private System.Windows.Forms.Button editButton; // ريماس - تعريف الزر الجديد
        private System.Windows.Forms.Button customViewButton;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView taskGrid;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblProgramName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}
