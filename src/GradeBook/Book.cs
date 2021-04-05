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

        // field definition option 1
        // List<double> grades = new List<double>();

        // field definition option 2
        private List<double> grades;
        private string name;
    }
}