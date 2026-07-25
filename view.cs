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
    public partial class view : Form
    {
        private Form parent;

        public view(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void view_Load(object sender, EventArgs e)
        {
            //load the files:
            TaskManager.Tasks.Clear();
            List<StudyTask> saved = FileStorage.LoadTasks();
            foreach (StudyTask t in saved)
                TaskManager.Tasks.Add(t);

            fromDate.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            toDate.Value = DateTime.Today;
           
            //Show the GridDataView for Type,Priority, And Date
            ShowInGrid(TaskManager.Tasks, viewGrid);
            ShowInGrid(TaskManager.Tasks, viewGridPriority);
            ShowInGrid(TaskManager.Tasks, viewGridType);
        }




        // Displays a list of tasks in the given DataGridView with formatted columns.
        private void ShowInGrid(List<StudyTask> tasks, DataGridView Grid)
        {
            if (tasks.Count == 0)
            {
                MessageBox.Show("No tasks found for this filter.", "No Results",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                Grid.DataSource = null;
                return;
            }
            List<object> display = new List<object>();


            foreach (StudyTask t in tasks)
            {
                display.Add(new
                {
                    t.Title,
                    DateDisplay = t.Date.ToString("dd/MM/yyyy"),
                    TimeDisplay = $"{t.Hours}h {t.Minutes}m",
                    t.Type,
                    t.Priority,
                    t.Subject,
                    Status = t.IsCompleted ? "✅ Done" : "⏳ Pending"
                });
            }

            Grid.DataSource = display;

            Grid.Columns["DateDisplay"].HeaderText = "Date";
            Grid.Columns["TimeDisplay"].HeaderText = "Time";
            Grid.Columns["Status"].HeaderText = "Status";
        }




        //==========Filter Priority==========
        private void filterPriorityButton_Click_1(object sender, EventArgs e)
        {
            if (priorityCombo.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a priority.", "No Selection",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedPriority = priorityCombo.SelectedItem.ToString();

            List<StudyTask> filtered = new List<StudyTask>();
            foreach (StudyTask t in TaskManager.Tasks)
            {
                if (t.Priority == selectedPriority)
                    filtered.Add(t);
            }

            ShowInGrid(filtered, viewGridPriority);
        }


        //==========Filter Date==========
        private void filterDateButton_Click_1(object sender, EventArgs e)
        {
            if (fromDate.Value.Date > toDate.Value.Date)
            {
                MessageBox.Show("'From' date cannot be after 'To' date.", "Invalid Range",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<StudyTask> filtered = new List<StudyTask>();
            foreach (StudyTask t in TaskManager.Tasks)
            {
                if (t.Date.Date >= fromDate.Value.Date && t.Date.Date <= toDate.Value.Date)
                    filtered.Add(t);
            }

            ShowInGrid(filtered, viewGrid);
        }


        //==========Filter Type==========
        private void filterTypeButton_Click_1(object sender, EventArgs e)
        {
            if (typeCombo.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a task type.", "No Selection",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedType = typeCombo.SelectedItem.ToString();

            List<StudyTask> filtered = new List<StudyTask>();
            foreach (StudyTask t in TaskManager.Tasks)
            {
                if (t.Type == selectedType)
                    filtered.Add(t);
            }

            ShowInGrid(filtered, viewGridType);
        }
        
        
        //Back button
        private void backBtn_Click(object sender, EventArgs e)
        {
            parent.Show();
            this.Close();
        }


        private void From_Click(object sender, EventArgs e)
        {

        }
        private void viewGridPriority_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
        private void viewGridType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void viewGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void typeCombo_SelectedIndexChanged(object sender, EventArgs e)    
        { 
       
        }

    }
}
