using System;

namespace ComparisonOperators
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var x = 0;
            var y = 0;

            x = 9; y = 9;

            if (x == y)
                Console.WriteLine("X is equal to y");
            else if (x != y)
            {
                //nested if
                if (x > y)
                    Console.WriteLine("X is greater than y");
                else if (x < y)
                    Console.WriteLine("X is less than y");
            }
        }
    }
}