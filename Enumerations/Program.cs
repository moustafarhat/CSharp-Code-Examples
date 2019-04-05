using System;

namespace Enumerations
{
    class Program
    {
        static void Main(string[] args)
        {
            string weekDayName = WeekDay.Monday.ToString();
            WeekDay day = WeekDay.Sunday;

            Console.WriteLine((int)day);
        }

    }

    internal enum WeekDay
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday = 40,
        Saturday = 50,
        Sunday = 60
    }
}
