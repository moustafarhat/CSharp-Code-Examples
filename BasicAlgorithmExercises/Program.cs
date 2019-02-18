using System;

namespace BasicAlgorithmExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic Algorithms");


            System.Console.WriteLine("Pascal Triangle Program");

            System.Console.Write("Enter the number of rows: ");

            string input = System.Console.ReadLine();

            int n = Convert.ToInt32(input);
            PascalTriangle.Pascal(n);
        }
    }
}
