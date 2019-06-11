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
            if (name.Length > 0)
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

        public double NiceAverage()
        {
            int sumWithoutLowest = 0;
            for (int i = 0; i < numOfGrades; i++)
            {
                sumWithoutLowest = sumWithoutLowest + grades[i];
            }
            sumWithoutLowest = sumWithoutLowest - GetMinGrade();
            return sumWithoutLowest / (numOfGrades - 1);
        }

        public int GetMinGrade()
        {
            int min = 101;
            for (int i = 0; i < numOfGrades; i++)
            {
                if (grades[i] < min)
                {
                    min = grades[i];
                }
            }
            return min;
        }

        public int GetMaxGrade()
        {
            int max = -1;
            for (int i = 0; i < numOfGrades; i++)
            {
                if (grades[i] > max)
                {
                    max = grades[i];
                }
            }
            return max;
        }
    }
}
