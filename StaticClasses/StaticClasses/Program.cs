using System;

namespace StaticClasses
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Animal.GetAge();
        }
    }

    internal static class Animal
    {
        static public string name;

        static public void GetAge()
        {
            Console.WriteLine(DateTime.Now.Year - DateTime.Now.AddYears(-4).Year);
        }
    }
}