using System;
using System.Collections.Generic;
using System.IO;

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
    // Handles all file operations: saving and loading tasks (CSV) and weekly goal (TXT)
    internal class FileStorage
    {
        // Path to the CSV file where tasks are stored
        private static string filePath = "tasks.csv";

        // Saves all tasks to the CSV file, one task per line
        public static void SaveTasks(List<StudyTask> tasks)
        {
            List<string> lines = new List<string>();

            // Convert each task object into a comma-separated string
            foreach (StudyTask t in tasks)
            {
                string line = t.Title + "," +
                              t.Date.ToString("yyyy-MM-dd") + "," +
                              t.Hours + "," +
                              t.Minutes + "," +
                              t.Type + "," +
                              t.Priority + "," +
                              t.Subject + "," +
                              t.IsCompleted;
                lines.Add(line);
            }

            // Write all lines to the CSV file (overwrites existing data)
            File.WriteAllLines(filePath, lines);
        }

        // Loads all tasks from the CSV file and returns them as a list
        public static List<StudyTask> LoadTasks()
        {
            List<StudyTask> tasks = new List<StudyTask>();

            // If the file doesn't exist yet, return an empty list
            if (!File.Exists(filePath))
                return tasks;

            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');

                // Skip any corrupted or incomplete lines (must have exactly 8 fields)
                if (parts.Length != 8)
                    continue;

                // Reconstruct a StudyTask object from the CSV fields
                StudyTask t = new StudyTask();
                t.Title = parts[0];
                t.Date = DateTime.ParseExact(parts[1], "yyyy-MM-dd",
                                   System.Globalization.CultureInfo.InvariantCulture);
                t.Hours = int.Parse(parts[2]);
                t.Minutes = int.Parse(parts[3]);
                t.Type = parts[4];
                t.Priority = parts[5];
                t.Subject = parts[6];
                t.IsCompleted = bool.Parse(parts[7]);

                tasks.Add(t);
            }

            return tasks;
        }

        // Path to the text file where the weekly goal (in hours) is stored

        private static string goalPath = "goal.txt";

        // Saves the user's weekly study goal to a text file
        public static void SaveGoal(int hours)
        {
            File.WriteAllText(goalPath, hours.ToString());
        }

        // Loads the weekly study goal from the text file

        // Returns 0 if no goal has been set yet
        public static int LoadGoal()
        {
            if (!File.Exists(goalPath))
                return 0;

            return int.Parse(File.ReadAllText(goalPath));
        }
    }
}