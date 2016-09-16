using GradeBook2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

            GradeBook book = new GradeBook();

            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            book.WriteGrade(Console.Out);

            GradeStatistics stats = book.ComputeStatistics();
            writeResult("Average", stats.AverageGrade);
            writeResult("Higest", stats.HighestGrade);
            writeResult("Lowest", stats.LowestGrade);
            writeResult(stats.Description, stats.LetterGrade);
            Console.ReadKey();

        }

        static void writeResult(string description, float result)
        {
            Console.WriteLine($"{description}: {result:F2}");
        }

        static void writeResult(string description, String result)
        {
            Console.WriteLine($"{description}: {result}");
        }

        static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"Gradebook changing name from {args.ExistingName} to {args.NewName}");
        }


    }
}
