using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Scott's grade book.");
            book1.AddGrade(89.1);
            book1.AddGrade(90.2);
            book1.GetStatistics();

            var stats = book1.GetStatistics();

            Console.WriteLine($"The highest grade is {stats.High}.");

            Console.WriteLine($"The lowest grade is {stats.Low}.");

            Console.WriteLine($"The average grade is {stats.Average}");




        }
    }
}
;