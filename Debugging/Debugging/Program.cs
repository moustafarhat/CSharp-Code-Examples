using System;

namespace Debugging
{
    internal class Program
    {
        private static int x = 0;
        private static int y = 0;

        private static void Main(string[] args)
        {
            x = 2;
            y = 2;
            Console.WriteLine("Inside main");
            ChangeValues();
            x = 10;
            y = 20;
            Console.WriteLine("Inside main again");
        }

        public static void ChangeValues()
        {
            x = 4;
            y = 5;
            Console.WriteLine("Inside change values");
        }
    }
}