using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    internal class StudyTask
    {
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public string Type { get; set; }
        public string Priority { get; set; }
        public string Subject { get; set; }
        public bool IsCompleted { get; set; }
    }
}
