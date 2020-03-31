using System;

namespace EvenOrOdd
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int x = 0;

            x = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            if (x % 2 == 0)
                Console.WriteLine(x + " is an even number");
            else
                Console.WriteLine(x + " is an odd number");
        }
    }
}