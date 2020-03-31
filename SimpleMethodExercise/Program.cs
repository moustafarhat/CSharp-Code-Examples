using System;

namespace SimpleMethodExercise
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            GetName();
        }

        private static void GetName()
        {
            string name;
            name = Console.ReadLine();
            SayHi(name);
        }

        private static void SayHi(string name)
        {
            Console.WriteLine($"Welcome back, {name}");
        }
    }
}