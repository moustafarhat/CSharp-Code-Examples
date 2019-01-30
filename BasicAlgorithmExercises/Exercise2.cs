using System;
using System.Collections.Generic;
using System.Text;

namespace BasicAlgorithmExercises
{
    public class Exercise2
    {
        //Write a C# Sharp program to get the absolute difference between n and 51. If n is greater than 51 return triple the absolute difference.
        public static int Test(int n)
        {
            const int x = 51;
            if (n > x)
            {
                return (n - x) * 3;
            }
            return x - n;
        }
    }
}
