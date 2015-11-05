using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class Student
    {
        private int studentID;
        private String name;
        private Dictionary<String, int> testScores;

        // When a Student is created, the id and name are given,
        // and will not change.
        public Student(int id, String name)
        {
            this.name = name;
            this.studentID = id;
            testScores = new Dictionary<string, int>();
        }

        public int GetID()
        {
            return studentID;
        }

        public String GetName()
        {
            return name;
        }

        // Insert a single test result
        public void AddTestResult(String courseName, int score)
        {
            testScores.Add(courseName, score);
        }

        // Find the average of the test scores for the student.
        // If no scores are present, an average of 0 (zero) is returned.
        public int GetScoreAverage()
        {
            if (testScores.Count == 0)
            {
                return 0;
            }
            else
            {
                int sum = 0;

                foreach (KeyValuePair<String, int> kvp in testScores)
                {
                    sum = sum + kvp.Value;
                }

                return (sum / testScores.Count);
            }
        }
    }
}
