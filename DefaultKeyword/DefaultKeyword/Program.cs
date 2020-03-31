using System;

namespace DefaultKeyword
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            long longVar = default;
            string stringVar = default;
            DateTime dateVar = default;
            int intVar = default;

            Console.WriteLine(dateVar);
        }
    }
}