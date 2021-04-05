using System.Collections.Generic;
namespace GradeBook
{
    class Book
    {
        // implicit constructor
        public Book()
        {
            grades = new List<double>();
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        // field definition option 1
        // List<double> grades = new List<double>();

        // field definition option 2
        List<double> grades;
    }
}