using System;

namespace PrecedenceOfoperators
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int x = 0;
            x = (2 + 3) * 2 - 4 + 2;
            Console.WriteLine(x);
        }
    }
}