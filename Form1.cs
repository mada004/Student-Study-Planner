using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // Exit button with confirmation dialog
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to exit?","Exit Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                Application.Exit(); // closes the entire application
            }
           
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            contextMenuStrip4.Show(button2, new Point(0, button2.Height)); // تحديد مكان ظهور القائمة تحت الزر
        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {
        }

        private void contextMenuStrip4_Opening(object sender, CancelEventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 tasks = new Form3();
            tasks.Show();
            this.Hide();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TaskManager.Tasks.Clear();
            List<StudyTask> saved = FileStorage.LoadTasks();
            foreach (StudyTask t in saved)
                TaskManager.Tasks.Add(t);


            string[] quotes = {
    " Success is built on daily effort:). ",
    "Study now, shine later!:)",
    " Small steps every day\n  lead to big results!:)",
     " Stay consistent,win tomorrow:)",
    " Believe in yourself and keep going!:) "
};

            Random rand = new Random();
            int index = rand.Next(quotes.Length);
            quoteLabel.Text = quotes[index];

            // Load and display the weekly goal
            int goal = FileStorage.LoadGoal();

            if (goal > 0)
                lblWeeklyGoal.Text = "Weekly Goal: " + goal + " hours";
            else
                lblWeeklyGoal.Text = "Weekly Goal: Not Set";

            UpdateWeeklyGoalLabel();
        }

        private void option2_Click(object sender, EventArgs e)
        {
            Summary summary_subject = new Summary();
            summary_subject.Show();
            this.Hide();
        }

        private void opti_Click(object sender, EventArgs e)
        {
            TrackProgress progress = new TrackProgress();
            progress.Show();
        }

        private void UpdateWeeklyGoalLabel()
        {
            int goal = FileStorage.LoadGoal();

            if (goal <= 0)
            {
                lblWeeklyGoal.Text = "Weekly Goal: Not Set";
                lblWeeklyGoal.ForeColor = Color.Gray;
                return;
            }

            DateTime today = DateTime.Today;
            int diff = (7 + (today.DayOfWeek - DayOfWeek.Sunday)) % 7; // days since Sunday
            DateTime weekStart = today.AddDays(-diff); // this week's Sunday
            DateTime weekEnd = weekStart.AddDays(6);   // this week's Saturday

            int totalMinutes = 0;
            foreach (StudyTask t in TaskManager.Tasks)
            {
                if (t.IsCompleted && t.Date.Date >= weekStart && t.Date.Date <= weekEnd)
                    totalMinutes += t.Hours * 60 + t.Minutes; //count the complete time
            }

            int doneHours = totalMinutes / 60;    // 150 / 60 = 2h
            int doneMinutes = totalMinutes % 60; // 150 % 60 = 30m
            int remaining = (goal * 60) - totalMinutes; // how many minutes left


            //goal Achieved
            if (remaining <= 0)
            {
                lblWeeklyGoal.Text = $"✅ Weekly Goal: {goal}h — Achieved!";
                lblWeeklyGoal.ForeColor = Color.Green;
            }
            else
            {
                //if still behind show the warning:
                int remH = remaining / 60;
                int remM = remaining % 60;
                lblWeeklyGoal.Text = $"⚠ Weekly Goal: {goal}h — {doneHours}h {doneMinutes}m done, {remH}h {remM}m left";
                lblWeeklyGoal.ForeColor = Color.OrangeRed;
            }
       
        
        }

        private void o_Click(object sender, EventArgs e)
        {
            WeeklyGoalForm goalForm = new WeeklyGoalForm();
            goalForm.ShowDialog();

            // Reload tasks before updating label
            TaskManager.Tasks.Clear();
            List<StudyTask> saved = FileStorage.LoadTasks();
            foreach (StudyTask t in saved)
                TaskManager.Tasks.Add(t);

            UpdateWeeklyGoalLabel();
        }

        private void UpdateWeeklyGoalLabel_Click(object sender, EventArgs e)
        {
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }



    }
}