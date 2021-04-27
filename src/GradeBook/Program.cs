using System;
using System.Collections.Generic;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Scott's grade book.");
            book1.AddGrade(89.1);
            book1.AddGrade(90.2);
            book1.ShowStatistics();

            Book book2 = new Book("Will's grade book.");
            book2.AddGrade(34.3);


            

        }
    }
}
;