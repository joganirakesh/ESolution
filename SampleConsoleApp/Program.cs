using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTimeUtils dateTimeUtils = new DateTimeUtils();

            Console.WriteLine("Enter a date (yyyy-MM-dd):");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter number of days to add:");
            int daysToAdd = int.Parse(Console.ReadLine());

            DateTime newDate = dateTimeUtils.AddDays(date, daysToAdd);
            Console.WriteLine($"New date: {newDate:yyyy-MM-dd}");

            Console.WriteLine("Enter number of days to subtract:");
            int daysToSubtract = int.Parse(Console.ReadLine());

            newDate = dateTimeUtils.SubtractDays(date, daysToSubtract);
            Console.WriteLine($"New date: {newDate:yyyy-MM-dd}");

            Console.WriteLine("Enter start date (yyyy-MM-dd):");
            DateTime startDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter end date (yyyy-MM-dd):");
            DateTime endDate = DateTime.Parse(Console.ReadLine());

            int daysBetween = dateTimeUtils.DaysBetween(startDate, endDate);
            Console.WriteLine($"Days between: {daysBetween}");
        }
    }
}
