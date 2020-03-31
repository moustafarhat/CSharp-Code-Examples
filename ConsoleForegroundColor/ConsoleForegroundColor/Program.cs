using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForegroundColor
{
    class Program
    {
        static void Main(string[] args)
        {
            string greenMessage = "This is the GREEN message";
            string blueMessage = "This is the BLUE message";
            string redMessage = "This is the RED message";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(greenMessage);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(blueMessage);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(redMessage);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
