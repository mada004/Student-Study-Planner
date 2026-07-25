using System;
using System.Collections.Generic;


namespace Student_Study_Palnner
{
    internal class TaskManager
    {
        public static List<StudyTask> Tasks { get; } = new List<StudyTask>();

        public static void AddTask(StudyTask task)
        {
            Tasks.Add(task);
        }
        public static void DeleteTask(StudyTask task)
        {
            Tasks.Remove(task);
        }
    }
}
