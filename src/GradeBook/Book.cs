
using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class NamedObject
    {
        public NamedObject(string name)
        {
            Name = name;
        }

        public string Name
        {
            get; set;
        }
    }
    public class Book : NamedObject
    {
        public Book(string name) : base(name)
        {
            grades = new List<double>();
            Name = name;
        }
        public void AddGrade(double grade) 
        {
            
            if(grade >= 0 && grade <= 100)
            {
                grades.Add(grade);
            }
            else
            {
                throw new ArgumentException($"Invalid {nameof(grade)}.");
            }
            
        }

        public Statistics GetStatistics()
        {
            
            
            var result = new Statistics();

            result.Average = 0.0;

            result.High = double.MinValue;

            result.Low = double.MaxValue;

            foreach(double grade in grades) {
                result.Low = Math.Min(grade, result.Low);
                result.High = Math.Max(grade, result.High);
                result.Average += grade;
            }

            result.Average = result.Average / grades.Count;

         

            return result;
        }

        List<double> grades;
        
     

        public const string CATEGORY = "Science";
        
        
    }
}