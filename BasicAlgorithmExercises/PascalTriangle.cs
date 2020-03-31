using System;

namespace BasicAlgorithmExercises
{
    public class PascalTriangle
    {
        public static void Pascal(int rows)
        {
            for (var y = 0; y < rows; y++)
            {
                var c = 1;

                for (var q = 0; q < rows - y; q++)
                {
                    Console.Write("   ");
                }
                for (var x = 0; x <= y; x++)
                {
                    Console.Write("   {0:D} ", c);
                    c = c * (y - x) / (x + 1);
                }
                Console.WriteLine();
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}