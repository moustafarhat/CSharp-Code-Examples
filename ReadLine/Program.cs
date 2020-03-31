using System;

namespace ReadLine
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");

            string name = Console.ReadLine();

            Console.WriteLine("Welcome " + name + ", welcome back!");
        }
    }
}