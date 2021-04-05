using System;
using System.Collections.Generic;
namespace GradeBook
{
    public class Book
    {
        // implicit constructor
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }

        // this is an instance member/method of class Book
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;
            foreach (double grade in grades)
            {
                /* comparison operators way
                if(number > highGrade)
                {
                    highGrade = number;
                }*/
                // Math method way
                result.High = Math.Max(grade, result.High);
                result.Low = Math.Min(grade, result.Low);
                result.Average += grade;
            }

            result.Average /= grades.Count;

            return result;
        }

        // field definition option 1
        // List<double> grades = new List<double>();

        // field definition option 2
        private List<double> grades;
        public string name;
    }
}