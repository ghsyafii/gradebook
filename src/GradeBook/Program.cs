using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Scott's grade book.");
            EnterGrades(book1);

            var stats = book1.GetStatistics();

            Console.WriteLine($"For the book named {book1.Name}.");

            Console.WriteLine($"The highest grade is {stats.High}.");

            Console.WriteLine($"The lowest grade is {stats.Low}.");

            Console.WriteLine($"The average grade is {stats.Average}");




        }

        private static void EnterGrades(Book book1)
        {
            while (true)
            {
                Console.WriteLine("Enter a grade or 'q' to quit.");
                var input = Console.ReadLine();

                if (input == "q")
                {
                    break;
                }

                try
                {
                    var grade = double.Parse(input);
                    book1.AddGrade(grade);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }


            }
        }
    }
}
;