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
    // Form that displays a monthly subject summary:
    // shows total planned hours and completed hours for a chosen subject and month
    public partial class Summary : Form
    {
        public Summary()
        {
            InitializeComponent();
        }

        // Loads saved tasks from CSV file into TaskManager when the form opens
        private void Summary_Load(object sender, EventArgs e)
        {
            TaskManager.Tasks.Clear();
            List<StudyTask> saved = FileStorage.LoadTasks();
            foreach (StudyTask t in saved)
                TaskManager.Tasks.Add(t);
        }

        // Triggered when "Show Summary" button is clicked
        // Filters tasks by subject and month, then displays hours and task list
        private void button1_Click(object sender, EventArgs e)
        {
            string subject = subjectTextBox.Text.Trim();

            // Validate: subject must not be empty and must have at least 3 characters
            if (string.IsNullOrWhiteSpace(subject) || subject.Length < 3)
            {
                MessageBox.Show(
                    "Please enter at least 3 letters for the subject.",
                    "Invalid Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            int monthNumber = (int)numericUpDown1.Value;

            // Accumulators for total and completed time
            int completedHours = 0, completedMinutes = 0;
            int totalHours = 0, totalMinutes = 0;

            // Filter tasks matching the selected subject and month
            List<StudyTask> filtered = new List<StudyTask>();
            foreach (StudyTask t in TaskManager.Tasks)
            {
                if (t.Date.Month == monthNumber &&
                    t.Subject.Trim().ToLower() == subject.ToLower())
                {
                    filtered.Add(t);

                    // Add to total planned time
                    totalHours += t.Hours;
                    totalMinutes += t.Minutes;

                    // Add to completed time only if task is marked done
                    if (t.IsCompleted)
                    {
                        completedHours += t.Hours;
                        completedMinutes += t.Minutes;
                    }
                }
            }

            //  convert excess minutes into hours
            totalHours += totalMinutes / 60;
            totalMinutes = totalMinutes % 60;
            completedHours += completedMinutes / 60;
            completedMinutes = completedMinutes % 60;

            // Show message if no tasks found for this subject/month combination
            if (filtered.Count == 0)
            {
                SummaryGrid.DataSource = null;
                string monthName = new DateTime(2024, monthNumber, 1).ToString("MMMM");
                MessageBox.Show(
                    "No tasks found for subject '" + subject + "' in " + monthName + ".",
                    "No Results",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }
            else
            {
                // Display the calculated totals in the labels
                TotalHourslbl.Text = $"Total Hours: {totalHours}h {totalMinutes}m";
                CompletedHourslbl.Text = $"Completed Hours: {completedHours}h {completedMinutes}m";

                CompletedHourslbl.Visible = true;
                TotalHourslbl.Visible = true;
            }

            // Build an anonymous object list for clean DataGridView display
            List<object> display = new List<object>();
            foreach (StudyTask t in filtered)
            {
                display.Add(new
                {
                    t.Title,
                    DateDisplay = t.Date.ToString("dd/MM/yyyy"),
                    TimeDisplay = $"{t.Hours}h {t.Minutes}m",
                    t.Type,
                    t.Priority,
                    t.Subject,
                    Status = t.IsCompleted ? "Done" : "Pending"
                });
            }

            // Bind filtered data to the grid and configure display settings
            SummaryGrid.DataSource = display;

            SummaryGrid.Columns["DateDisplay"].HeaderText = "Date";
            SummaryGrid.Columns["TimeDisplay"].HeaderText = "Time";
            SummaryGrid.Columns["Status"].HeaderText = "Status";

            SummaryGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SummaryGrid.ReadOnly = true;
            SummaryGrid.AllowUserToAddRows = false;
            SummaryGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SummaryGrid.RowHeadersVisible = false;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e) { }

        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void errorLabel_Click(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e) { }

        // Navigates back to the main form (Form1)
        private void button3_Click(object sender, EventArgs e)
        {
            Form1 mainForm = new Form1();
            mainForm.Show();
            this.Hide();
        }
    }
}