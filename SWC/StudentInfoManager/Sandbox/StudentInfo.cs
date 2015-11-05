using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class StudentInfo
    {
        private Dictionary<int, Student> students;

        public StudentInfo()
        {
            students = new Dictionary<int, Student>();
        }

        // Return the number of students in the group of students
        public int GetStudentCount()
        {
            // The below must be changed

            return students.Count;


        }

        // Add a single student to the group of students
        public void AddStudent(int id, Student aStudent)
        {
            students.Add(id, aStudent);
        }

        // Given an id, return the student with that id.
        // If no student exists with the given id, return null
        public Student GetStudent(int id)
        {
            Student student = students[id];
            return student;
        }

        // Given an id, return the score average for the student with that id.
        // If no student exists with the given id, return 0 (zero).
        public int GetAverageForStudent(int id)
        {
            int average = students[id].GetScoreAverage();
            return average;
        }

        // Calculate the total test score average for ALL students
        // in the group of students.
        // TIP: Use the method GetAllStudentId and a loop...
        public int GetTotalAverage()
        {
            int totalAverage = 0;

            List<int>studentIDs = GetAllStudentId();

            foreach (int id in studentIDs)
            {
                Student student = students[id];
                int average = student.GetScoreAverage();
                totalAverage += average;
            }

            totalAverage = totalAverage/studentIDs.Count;

            return totalAverage;
        }

        // Returns a list of all ids of the students in the group of students
        // (leave this method as it is)
        public List<int> GetAllStudentId()
        {
            // A little bit of black magic...
            return (new List<int>(students.Keys.ToArray()));
        }
    }
}
