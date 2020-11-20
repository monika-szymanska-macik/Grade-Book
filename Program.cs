using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Scott's Grade Book");
            while(true)
            {
                Console.WriteLine("Enter the grade. If you want to leave it, click on q");
                var input = Console.ReadLine();
                 if(input == "q")
                {
                    break;
                }

                try
                {
                    var grade = double.Parse(input);

                    book.AddGrade(grade);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }


            var stats = book.GetStatistics();

            book.Name = "";

            Console.WriteLine($"For thee book named {book.Name}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The average of grades is {stats.Average}");
            Console.WriteLine($"The letter is {stats.Letter}");
        }

    }
}