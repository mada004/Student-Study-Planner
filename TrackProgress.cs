using System;
using System.Collections.Generic;
using System.Windows.Forms;
/*
Project Title: Student Study Planner
Course: COCS 308 - Programming III Lab
Instructor: Maryam Alsulami

Team Name: Enlighters

Team Members:
1. Rahaf  Alsubhi - 2308562 
2. Mayar Alknaidiri  - 2305503 
3. Ryof Almutairi  - 2305880 
4. Reemas Alharthi - 2305968  
5. Mada Alhussaini   - 2307751  
6. Shaden Almohammadi  - 2406130  

Project Description:
This Windows Forms application helps students plan and organize their study sessions,
keep track of upcoming deadlines, and monitor their academic progress over time.
It allows students to add, edit, and delete tasks, filter them by date, type, and priority,
and receive automatic alerts for upcoming deadlines.
Progress is visually tracked through a progress bar, making it easier for students
to stay on top of their workload and achieve their academic goals.
*/
namespace Student_Study_Palnner
{
    public partial class TrackProgress : Form
    {

        // Constructor: initializes form components

        public TrackProgress()
        {
            InitializeComponent();
        }

    
        // Filters tasks between two selected dates, sorts them by date using Selection Sort,
        // displays them in the grid, and calculates/shows completion percentage in the progress bar

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime from = dateTimePicker1.Value.Date;
            DateTime to = dateTimePicker2.Value.Date;

            // Check date range
            if (from > to)
            {
                MessageBox.Show("Invalid date range. Please select correct dates.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            // Filter tasks 
            List<StudyTask> filteredTasks = new List<StudyTask>();
            foreach (StudyTask t in TaskManager.Tasks)
            {
                if (t.Date.Date >= from && t.Date.Date <= to)
                    filteredTasks.Add(t);
            }

            // Selection Sort by date
            for (int i = 0; i < filteredTasks.Count - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < filteredTasks.Count; j++)
                {
                    if (filteredTasks[j].Date < filteredTasks[minIndex].Date)
                        minIndex = j;
                }
                StudyTask temp = filteredTasks[minIndex];
                filteredTasks[minIndex] = filteredTasks[i];
                filteredTasks[i] = temp;
            }


            if (filteredTasks.Count == 0)
            {
                MessageBox.Show("No tasks found between selected dates.",
                                "No Data",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                viewGrid.DataSource = null;
                progressBar1.Value = 0;
                label4.Visible = true;
                label4.Text = "0% Completed";
                label3.Text = "Stay consistent and keep working toward your goals!";
                return;
            }


            viewGrid.DataSource = null;
            viewGrid.DataSource = filteredTasks;


            viewGrid.Columns["Hours"].Visible = false;
            viewGrid.Columns["Minutes"].Visible = false;
            viewGrid.Columns["IsCompleted"].Visible = false;


            viewGrid.Columns["Title"].HeaderText = "Title";
            viewGrid.Columns["Date"].HeaderText = "Date";
            viewGrid.Columns["Type"].HeaderText = "Type";
            viewGrid.Columns["Priority"].HeaderText = "Priority";
            viewGrid.Columns["Subject"].HeaderText = "Subject";


            if (viewGrid.Columns.Contains("Time"))
                viewGrid.Columns.Remove("Time");

            DataGridViewTextBoxColumn timeColumn = new DataGridViewTextBoxColumn();
            timeColumn.Name = "Time";
            timeColumn.HeaderText = "Time";
            viewGrid.Columns.Insert(1, timeColumn);


            for (int i = 0; i < filteredTasks.Count; i++)
            {
                string time = filteredTasks[i].Hours.ToString("00") + ":" +
                              filteredTasks[i].Minutes.ToString("00");
                viewGrid.Rows[i].Cells["Time"].Value = time;
            }


            viewGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            viewGrid.ReadOnly = true;
            viewGrid.AllowUserToAddRows = false;
            viewGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            viewGrid.RowHeadersVisible = false;


            viewGrid.DefaultCellStyle.SelectionBackColor = viewGrid.DefaultCellStyle.BackColor;
            viewGrid.DefaultCellStyle.SelectionForeColor = viewGrid.DefaultCellStyle.ForeColor;

            // Calculate progress
            int totalTasks = filteredTasks.Count;
            int completedTasks = 0;
            foreach (StudyTask t in filteredTasks)
            {
                if (t.IsCompleted)
                    completedTasks++;
            }
            int percentage = (int)((double)completedTasks / totalTasks * 100);

            progressBar1.Value = percentage;
            label4.Text = percentage + "% Completed";
            label4.Visible = true;

            label3.Visible = false;


            if (percentage == 100)
                label3.Text = "Excellent work! You achieved your weekly goal!";
            else if (percentage >= 70)
                label3.Text = "Great job! You're almost there!";
            else if (percentage >= 40)
                label3.Text = "Good progress! Keep pushing!";
            else
                label3.Text = "Stay focused! You can do it!";

            label3.Visible = true;
        }

        // Hides the current form to return to the previous screen (main form).
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 mainForm = new Form1();
            this.Hide();
        }

        // Loads saved tasks from file into TaskManager when the form opens
        private void TrackProgress_Load(object sender, EventArgs e)
        {
            TaskManager.Tasks.Clear();
            List<StudyTask> saved = FileStorage.LoadTasks();
            foreach (StudyTask t in saved)
                TaskManager.Tasks.Add(t);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void viewGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

    }
}
