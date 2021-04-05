using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Jarvis' Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);

            var grades = new List<double>() { 12.7, 10.3, 6.11, 4.1 };
            grades.Add(56.1);
            
            var result = 0.0;
            var highGrade = double.MinValue;
            foreach (double number in grades)
            {
                /* comparison operators way
                if(number > highGrade)
                {
                    highGrade = number;
                }*/
                // Math method way
                highGrade = Math.Max(number, highGrade);

                result += number;
            }
            Console.WriteLine($"Sum of grades: {result}");

            Console.WriteLine($"How many numbers are in grades? {grades.Count}");
            var average = 0.0;
            average = result / grades.Count;
            Console.WriteLine($"The average grade is {average:N1}.");
            System.Console.WriteLine($"The highest grade is {highGrade}.");
        }
    }
}
