using System;

namespace ArithmeticOperators
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int x = 7;
            int y = 2;
            int result = 0;
            result = x % y;
            Console.WriteLine("Rem: " + result);
        }
    }
}