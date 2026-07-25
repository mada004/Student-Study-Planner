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
    public partial class EditTask : Form
    {
        private int taskIndex;

        public EditTask(int index)
        {
            InitializeComponent();
            taskIndex = index;
        }
        //It retrieves the task details using the task index
        private void EditTask_Load(object sender, EventArgs e)
        {
            StudyTask task = TaskManager.Tasks[taskIndex];
            titleTextBox.Text = task.Title;
            subjectTextBox.Text = task.Subject;
            datePicker.Value = task.Date;
            hoursNumeric.Value = task.Hours;
            minutesNumeric.Value = task.Minutes;


            typeComboBox.SelectedItem = task.Type;


            if (task.Priority == "High") radioHigh.Checked = true;
            else if (task.Priority == "Medium") radioMedium.Checked = true;
            else if (task.Priority == "Low") radioLow.Checked = true;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // It checks if the title is empty or has fewer than 3 letters 
        private void titleTextBox_Validating(object sender, CancelEventArgs e)
        {
            string title = titleTextBox.Text.Trim();
            if (string.IsNullOrEmpty(title))
            {
                lblTitleError.Text = "⚠ Title cannot be empty!";
                lblTitleError.Visible = true;
            }
            else
            {
                lblTitleError.Visible = false;
            }
        }

        // It checks if the subject is empty
        private void subjectTextBox_Validating(object sender, CancelEventArgs e)
        {
            string subject = subjectTextBox.Text.Trim();
            if (string.IsNullOrEmpty(subject))
            {
                lblSubjectError.Text = "⚠ Subject cannot be empty!";
                lblSubjectError.Visible = true;
            }
            else
            {
                lblSubjectError.Visible = false;
            }
        }
        // It validates the input fields and updates the task if all validations pass.
        private void btnSave_Click(object sender, EventArgs e)
        {
            lblTitleError.Visible = false;
            lblSubjectError.Visible = false;
            lblDateError.Visible = false;
            lblHoursError.Visible = false;
            lblTypeError.Visible = false;
            lblPriorityError.Visible = false;

            // Validate the title input
            string title = titleTextBox.Text.Trim();
            if (string.IsNullOrEmpty(title))
            {
                lblTitleError.Visible = true;
                MessageBox.Show("⚠ Title cannot be empty!", "Invalid Title",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ensure that title starts with at least 3 letters
            int letterCount = 0;
            foreach (char c in title)
            {
                if (char.IsLetter(c)) letterCount++;
                else break;
            }
            if (letterCount < 3)
            {
                lblTitleError.Visible = true;
                MessageBox.Show("⚠ Title must start with at least 3 letters!", "Invalid Title",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // Validate date to ensure it's not in the past
            if (datePicker.Value.Date < DateTime.Today)
            {
                lblDateError.Visible = true;
                MessageBox.Show("⚠ Date cannot be in the past!", "Invalid Date",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            int h = (int)hoursNumeric.Value;
            int m = (int)minutesNumeric.Value;
            if (h == 0 && m == 0)
            {
                lblHoursError.Visible = true;
                MessageBox.Show("⚠ Study time cannot be zero!", "Invalid Time",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // Validate the subject input
            string subject = subjectTextBox.Text.Trim();
            if (string.IsNullOrEmpty(subject))
            {
                lblSubjectError.Visible = true;
                MessageBox.Show("⚠ Subject cannot be empty!", "Invalid Subject",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            // Ensure that subject starts with at least 3 letters
            int subjectLetterCount = 0;
            foreach (char c in subject)
            {
                if (char.IsLetter(c)) subjectLetterCount++;
                else break;
            }
            if (subjectLetterCount < 3)
            {
                lblSubjectError.Visible = true;
                MessageBox.Show("⚠ Subject must start with at least 3 letters!", "Invalid Subject",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (typeComboBox.SelectedIndex == -1)
            {
                lblTypeError.Visible = true;
                MessageBox.Show("⚠ Please select a task type!", "Missing Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string priority = "";
            if (radioHigh.Checked) priority = "High";
            else if (radioMedium.Checked) priority = "Medium";
            else if (radioLow.Checked) priority = "Low";
            else
            {
                lblPriorityError.Visible = true;
                MessageBox.Show("⚠ Please select a priority!", "Missing Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            StudyTask task = TaskManager.Tasks[taskIndex];
            task.Title = title;
            task.Date = datePicker.Value;
            task.Hours = h;
            task.Minutes = m;
            task.Type = typeComboBox.SelectedItem.ToString();
            task.Priority = priority;
            task.Subject = subject;


            FileStorage.SaveTasks(TaskManager.Tasks);

            MessageBox.Show("✅ Task updated successfully!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }


        // Validates the subject field as the text changes.
        private void subjectTextBox_TextChanged(object sender, EventArgs e)
        {
            string subject = subjectTextBox.Text.Trim();
            if (string.IsNullOrEmpty(subject))
            {
                lblSubjectError.Text = "⚠ Subject cannot be empty!";
                lblSubjectError.Visible = true;
            }
            else
            {
                int letterCount = 0;
                foreach (char c in subject)
                {
                    if (char.IsLetter(c)) letterCount++;
                    else break;
                }
                if (letterCount < 3)
                {
                    lblSubjectError.Text = "⚠ Subject must start with at least 3 letters!";
                    lblSubjectError.Visible = true;
                }
                else
                {
                    lblSubjectError.Visible = false;

                }
            }
        }



    }
}