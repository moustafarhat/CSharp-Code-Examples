using System;
using System.Collections.Generic;
using System.Text;

namespace BasicAlgorithmExercises
{
    public class Exercise1
    {
        //Exercise-1 with Solution
        //Write a C# Sharp program to compute the sum of the two given integer values.
        //If the two values are the same, then return triple their sum.

        public static int Sum(int x, int y)
        {
            return x == y ? (x + y) * 3 : x + y;
        }
    }
}
