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

            Book book2 = new Book("Will's grade book.");
            book2.AddGrade(34.3);


            

        }
    }
}
;