using System;
using System.Collections.Generic;

namespace GradeBook
{

    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Eli's Grade Book");  
            while (true)
            {
                System.Console.WriteLine("Eneter a grade or 'q' to quit");
                var input = Console.ReadLine();
                if (input == "q")
                {
                    break;
                }
                try
                {
                var grade = Double.Parse(input);
                book.AddGrade(grade);
                }
                catch (ArgumentException ex)
                {
                    System.Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    System.Console.WriteLine(ex.Message);
                }
                finally
                {
                    // do something even after exception was thrown
                }

            }


            var stats = book.GetStats();
            System.Console.WriteLine(Book.CONSTANT);   // accessing a constant; pay attention to uppercase "Book"
            Console.WriteLine($"The average grade is {stats.Average:N1}");
            System.Console.WriteLine($"The highest grade is {stats.High:N1}");
            System.Console.WriteLine($"The lowest grade is {stats.Low:N1}");
        }
    }
}
