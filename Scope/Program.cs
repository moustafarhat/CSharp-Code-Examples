using System;

namespace Scope
{
    internal class Program
    {
        private static string name = "Daniel";

        private static void Main(string[] args)
        {
            SayHi();
        }

        private static void SayHi()
        {
            name = "Jon";
            Console.WriteLine("Hi, " + name);
        }
    }
}