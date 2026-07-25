using System;
using System.ComponentModel;
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
    public partial class AddTask : Form
    {
        private Form parent;

        public AddTask(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }
        public AddTask()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 back1 = new Form3();          
            this.Close();
        }

      

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

      


        private void button2_Click(object sender, EventArgs e)
        {

            // Clear previous errors
           lblDateError.Visible = false;
           lblHoursError.Visible = false;
           lblPriorityError.Visible = false;
           lblSubjectError.Visible = false;
           lblTypeError.Visible = false;
            
            // Validate title
            string title = titleTextBox.Text.Trim();    
            if (string.IsNullOrEmpty(title))
            {
                TitleError.Visible = true;
                MessageBox.Show("⚠ Title cannot be empty!", "Invalid Title",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            int letterCount = 0;
            foreach (char c in title)
            {
                if (char.IsLetter(c)) letterCount++;
                else break;
            }
            if (letterCount < 3)
            {
                MessageBox.Show("⚠ Title must start with at least 3 letters!", "Invalid Title", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            TitleError.Visible = false;

            // Validate time
            int h = (int)hoursNumeric.Value;
            int m = (int)minutesNumeric.Value;
            if (h == 0 && m == 0)//its lowkey impossible to have hours = 0 .. so no need to do this step?
            {
                MessageBox.Show("⚠ Time cannot be zero!", "Invalid Time", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblHoursError.Visible = true;
                return;
            }
            

            // Validate date
            if (datePicker.Value.Date < DateTime.Today)
            {
                MessageBox.Show("⚠ Date cannot be in the past!", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblDateError.Visible = true;
                return;
            }


            // Validate subject
            string subject = subjectTextBox.Text.Trim();
            if (string.IsNullOrEmpty(subject))
            {
                MessageBox.Show("⚠ Subject cannot be empty!", "Invalid Subject", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblSubjectError.Visible = true;
                return;
            }
            int subjectLetterCount = 0;
            foreach (char c in subject)
            {
                if (char.IsLetter(c)) subjectLetterCount++;
                else break;
            }
            if (subjectLetterCount < 3)
            {
                MessageBox.Show("⚠ Subject must start with at least 3 letters!", "Invalid Subject", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblSubjectError.Visible = true;
                return;
            }


            // Validate type
            if (typeComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("⚠ Please select a task type!", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               lblTypeError.Visible = true;
                return;
            }

            // Validate priority
            string priority = "";
            if (radioHigh.Checked) priority = "High";
            else if (radioMedium.Checked) priority = "Medium";
            else if (radioLow.Checked) priority = "Low";
            else
            {
                MessageBox.Show("Please select a priority.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblPriorityError.Visible = true;

                return;
            }


            //save the task
            StudyTask newTask = new StudyTask();
            newTask.Title = title;
            newTask.Date = datePicker.Value;
            newTask.Hours = h;
            newTask.Minutes = m;
            newTask.Type = typeComboBox.SelectedItem.ToString();
            newTask.Priority = priority;
            newTask.Subject = subject;
            TaskManager.AddTask(newTask);


            //save the task in CSV Format
            FileStorage.SaveTasks(TaskManager.Tasks);
            MessageBox.Show("✅ Task added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
       
        
        private void AddTask_Load(object sender, EventArgs e)
        {

        }

        private void errorLabel1_Click(object sender, EventArgs e)
        {

        }

        private void errorLabel_Subject_Click(object sender, EventArgs e)
        {

        }
        //----------------------------------------titleTextBox_Validating--------------
        private void titleTextBox_Validating(object sender, CancelEventArgs e)
        {
            string title = titleTextBox.Text.Trim();
            lblTitleValidation.Visible = false;

            if (string.IsNullOrEmpty(title))
            {
                lblTitleValidation.Text = "⚠ Title cannot be empty!";
                lblTitleValidation.Visible = true;
                return;
            }

            int letterCount = 0;
            foreach (char c in title)
            {
                if (char.IsLetter(c)) letterCount++;
                else break;
            }

            if (letterCount < 3)
            {
                lblTitleValidation.Text = "⚠ Title must start with at least 3 letters!";
                lblTitleValidation.Visible = true;
                return;
            }

            lblTitleValidation.Visible = false;
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void hoursNumeric_ValueChanged(object sender, EventArgs e)
        {

        }

        private void minutesNumeric_ValueChanged(object sender, EventArgs e)
        {

        }
        //
        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioMedium_CheckedChanged(object sender, EventArgs e)
        {

        }
        //
        private void subjectTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void subjectTextBox_Validating(object sender, CancelEventArgs e)
        {
            string subject = subjectTextBox.Text.Trim();

            if (string.IsNullOrEmpty(subject))
            {
                lblSubjectValidation.Text = "⚠ Subject cannot be empty!";
                lblSubjectValidation.Visible = true;
                return;
            }

            lblSubjectValidation.Visible = false;
        }
    }
    }

