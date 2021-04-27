using System;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0) 
            {
                Console.WriteLine($"Hello, {args[1]}!");
            } 
            else 
            {
                Console.WriteLine("No name given.");
                Console.WriteLine("Please provide name");
            }
        }
    }
}
;