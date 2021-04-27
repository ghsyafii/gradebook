
using System;
using System.Collections.Generic;

namespace Gradebook
{
    class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }
        public void AddGrade(double grade) 
        {
            grades.Add(grade);
        }

        public void ShowStatistics()
        {
            double result = 0;

            double highestGrade = double.MinValue;

            double lowestGrade = double.MaxValue;

            foreach(double grade in grades) {
                lowestGrade = Math.Min(grade, lowestGrade);
                highestGrade = Math.Max(grade, highestGrade);
                result += grade;
            }

            double averageGrade = result/grades.Count;

            Console.WriteLine($"The highest grade is {highestGrade}.");

            Console.WriteLine($"The lowest grade is {lowestGrade}.");

            Console.WriteLine($"The average grade is {averageGrade}");
        }

        List<double> grades;
        public string name;
        
    }
}