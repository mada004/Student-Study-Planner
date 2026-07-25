using System;
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
    public partial class WeeklyGoalForm : Form
    {
        public WeeklyGoalForm()
        {
            InitializeComponent();
        }       
        
        //Back Button
        private void button3_Click(object sender, EventArgs e)
        {
            Form1 back = new Form1();
            
            this.Close();
        }
        //Save Button
        private void btnSave_Click(object sender, EventArgs e)
        {

            // Validate input
            if (!int.TryParse(txtHours.Text, out int hours)  || hours < 1 || hours > 56)
            {
                MessageBox.Show("Enter a number between 1 and 35.");
                return;
            }

            FileStorage.SaveGoal(hours);

            MessageBox.Show("Weekly goal saved!");
            this.Close();
        }


        private void txtHours_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
