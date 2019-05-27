using System;

namespace functionsSchoolStuff
{
    class Student
    {
        private string name;
        private int[] grades;
        private int numOfGrades;

        public Student(string name)
        {
            if (name.Length>0)
            {
                this.name = name;
            }
            grades = new int[100];
            numOfGrades = 0;
        }

        public void AddGrade(int grade)
        {
            if (grade > 0 && grade < 100)
            {
                grades[numOfGrades] = grade;
                numOfGrades++;
            }
        }

        public double Average()
        {
            int sum = 0;
            for (int i = 0; i < numOfGrades; i++)
            {
                sum = sum + grades[i];
            }
            return sum / numOfGrades;
        }
    }
}
