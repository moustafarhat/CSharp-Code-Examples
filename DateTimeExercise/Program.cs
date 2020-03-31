using System;

namespace DateTimeExercise
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var myDate = DateTime.Now;
            var formattedDate = "";
            // First Format : 30-09-2017 01:15:55
            formattedDate = $"{myDate:dd-MM-yyyy HH:mm:ss}";
            Console.WriteLine(formattedDate);

            // Second Format : Saturday of month September 2017
            formattedDate = $"{myDate:dddd 'of month' MMMM 'year' yyyy}";
            Console.WriteLine(formattedDate);

            /* Third Format
             * Day Saturday
             * Month September
             * Year 2017
             */
            formattedDate = $"{myDate:'Day' dddd \n'Month' MMMM \n'Year' yyyy}";
            Console.WriteLine(formattedDate);
        }
    }
}