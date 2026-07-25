using System;
using System.Collections.Generic;
using System.Drawing;
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
    // Form3: Main task management screen
    // Displays all tasks in a grid and provides Add, Edit, Delete, and Mark as Done actions
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        // Opens the View Tasks form to filter and browse tasks
        private void button4_Click(object sender, EventArgs e)
        {
            view customView = new view(this);
            customView.Show();
            this.Hide();
        }

        // Opens the Add Task dialog, then refreshes the grid after closing
        private void button1_Click(object sender, EventArgs e)
        {
            AddTask add_task = new AddTask();
            add_task.ShowDialog();
            LoadTasks();
        }

        // Navigates back to the main menu (Form1)
        private void button7_Click(object sender, EventArgs e)
        {
            Form1 back = new Form1();
            back.Show();
            this.Close();
        }

        // Runs when the form first loads:
        // clears memory, loads saved tasks from CSV, sets up the grid, and shows deadline alerts
        private void Form3_Load(object sender, EventArgs e)
        {
            TaskManager.Tasks.Clear();

            List<StudyTask> saved = FileStorage.LoadTasks();
            foreach (StudyTask t in saved)
                TaskManager.Tasks.Add(t);

            SetupGrid();
            LoadTasks();
            ShowUpcomingDeadlinesAlert();
        }

        // Configures the DataGridView columns, layout, and selection style
        private void SetupGrid()
        {
            taskGrid.Columns.Clear();
            taskGrid.AutoGenerateColumns = false;
            taskGrid.ReadOnly = true;
            taskGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            taskGrid.AllowUserToAddRows = false;
            taskGrid.AllowUserToDeleteRows = false;

            // Remove the default blue highlight on selected rows for cleaner look
            taskGrid.DefaultCellStyle.SelectionBackColor = taskGrid.DefaultCellStyle.BackColor;
            taskGrid.DefaultCellStyle.SelectionForeColor = taskGrid.DefaultCellStyle.ForeColor;

            // Define each column and map it to the corresponding task property
            taskGrid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Title", DataPropertyName = "Title", Width = 130 });
            taskGrid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Date", DataPropertyName = "DateDisplay", Width = 100 });
            taskGrid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Time", DataPropertyName = "TimeDisplay", Width = 80 });
            taskGrid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Type", DataPropertyName = "Type", Width = 80 });
            taskGrid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Priority", DataPropertyName = "Priority", Width = 80 });
            taskGrid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Subject", DataPropertyName = "Subject", Width = 100 });
            taskGrid.Columns.Add(new DataGridViewCheckBoxColumn { HeaderText = "Done", DataPropertyName = "IsCompleted", Width = 50 });
        }

        // Populates the grid with all current tasks and applies color coding:
        // Green = completed, Light Orange = due within 3 days, White = normal
        private void LoadTasks()
        {
            var display = new List<object>();

            foreach (var t in TaskManager.Tasks)
            {
                display.Add(new
                {
                    t.Title,
                    DateDisplay = t.Date.ToString("dd/MM/yyyy"),
                    TimeDisplay = $"{t.Hours}h {t.Minutes}m",
                    t.Type,
                    t.Priority,
                    t.Subject,
                    t.IsCompleted
                });
            }

            taskGrid.DataSource = display;

            // Apply row colors based on task status and deadline proximity
            for (int i = 0; i < taskGrid.Rows.Count; i++)
            {
                bool isDone = TaskManager.Tasks[i].IsCompleted;
                taskGrid.Rows[i].DefaultCellStyle.BackColor = isDone ? Color.LightGreen : Color.White;

                // Highlight incomplete tasks due within the next 3 days in Light/orange
                if (!isDone)
                {
                    int daysLeft = (TaskManager.Tasks[i].Date.Date - DateTime.Today).Days;
                    if (daysLeft >= 0 && daysLeft <= 3)
                        taskGrid.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
                }
            }
        }

        // Shows a popup alert listing all incomplete tasks due within the next 3 days
        // Tasks are sorted by date using Selection Sort before display
        private void ShowUpcomingDeadlinesAlert()
        {
            List<StudyTask> upcoming = new List<StudyTask>();

            // Collect tasks that are incomplete and due within 3 days from today
            foreach (StudyTask t in TaskManager.Tasks)
            {
                if (!t.IsCompleted &&
                    t.Date.Date >= DateTime.Today &&
                    t.Date.Date <= DateTime.Today.AddDays(3))
                {
                    upcoming.Add(t);
                }
            }

            // Sort upcoming tasks by date using Selection Sort
            for (int i = 0; i < upcoming.Count - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < upcoming.Count; j++)
                {
                    if (upcoming[j].Date < upcoming[minIndex].Date)
                        minIndex = j;
                }
                StudyTask temp = upcoming[minIndex];
                upcoming[minIndex] = upcoming[i];
                upcoming[i] = temp;
            }

            // No upcoming deadlines — nothing to show
            if (upcoming.Count == 0)
                return;

            string message = "⚠ You have upcoming deadlines in the next 3 days:\n\n";

            foreach (StudyTask t in upcoming)
            {
                int daysLeft = (t.Date.Date - DateTime.Today).Days;

                // Human-friendly time label for urgency
                string timeLeft;
                if (daysLeft == 0) timeLeft = "TODAY!";
                else if (daysLeft == 1) timeLeft = "Tomorrow";
                else timeLeft = $"In {daysLeft} days";

                message += $"• [{t.Priority}] {t.Title} - {t.Subject} ({timeLeft})\n";
            }

            message += "\nMake sure to prepare on time! ";

            MessageBox.Show(message, "⏰ Upcoming Deadlines Alert",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // Deletes the selected task after a confirmation prompt, then saves and refreshes
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (taskGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a task to delete.", "No Selection",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int index = taskGrid.SelectedRows[0].Index;
            var confirm = MessageBox.Show("Are you sure you want to delete this task?",
                                          "Confirm Delete",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                TaskManager.DeleteTask(TaskManager.Tasks[index]);
                FileStorage.SaveTasks(TaskManager.Tasks);
                LoadTasks();
            }
        }

        // Marks the selected task as completed, saves, and refreshes the grid
        private void markButton_Click_1(object sender, EventArgs e)
        {
            if (taskGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a task first!", "No Selection",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int index = taskGrid.SelectedRows[0].Index;

            // Prevent marking an already completed task
            if (TaskManager.Tasks[index].IsCompleted)
            {
                MessageBox.Show("This task is already completed!", "Already Done",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            TaskManager.Tasks[index].IsCompleted = true;
            FileStorage.SaveTasks(TaskManager.Tasks);

            MessageBox.Show("🎉 Great job! Keep up the good work!", "Task Completed",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadTasks();
        }

        // Secondary delete button: confirms with task title before deleting
        private void button2_Click(object sender, EventArgs e)
        {
            if (taskGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a task to delete.", "No Selection",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int index = taskGrid.SelectedRows[0].Index;
            var confirm = MessageBox.Show(
                $"Are you sure you want to delete '{TaskManager.Tasks[index].Title}'?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                TaskManager.DeleteTask(TaskManager.Tasks[index]);
                FileStorage.SaveTasks(TaskManager.Tasks);
                LoadTasks();
            }
        }

        // Placeholder for an unused button event
        private void button6_Click(object sender, EventArgs e) { }

        // Opens the Edit Task dialog for the selected task, then refreshes the grid
        private void editButton_Click(object sender, EventArgs e)
        {
            if (taskGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a task to edit.", "No Selection",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int index = taskGrid.SelectedRows[0].Index;
            EditTask editForm = new EditTask(index);
            editForm.ShowDialog();

            // Refresh the grid to reflect any edits made
            LoadTasks();
        }

        private void pictureBox3_Click(object sender, EventArgs e) { }


        private void taskGrid_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}