using System;
using System.Collections.Generic;
namespace GradeBook
{
    class Book
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

        public void ShowStatistics()
        {
            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;
            foreach (double number in grades)
            {
                /* comparison operators way
                if(number > highGrade)
                {
                    highGrade = number;
                }*/
                // Math method way
                highGrade = Math.Max(number, highGrade);
                lowGrade = Math.Min(number, lowGrade);
                result += number;
            }

            result /= grades.Count;
            Console.WriteLine($"{this.name}");
            Console.WriteLine($"The average grade is {result:N1}.");
            Console.WriteLine($"The highest grade is {highGrade}.");
            Console.WriteLine($"The lowest grade is {lowGrade}.");
        }

        // field definition option 1
        // List<double> grades = new List<double>();

        // field definition option 2
        private List<double> grades;
        private string name;
    }
}