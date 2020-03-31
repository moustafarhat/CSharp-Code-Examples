using System;

namespace ExceptionExercise
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int firstNumber = 0;
            int secondNumber = 0;
            double divResult = 0;
            startAgain:
            try
            {
                Console.WriteLine("Enter the first number");
                firstNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the second number");
                secondNumber = int.Parse(Console.ReadLine());

                divResult = (double)firstNumber / (double)secondNumber;
                Console.WriteLine("Result = " + divResult);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Cannot divide by zero");
                goto startAgain;
            }
            catch (FormatException e)
            {
                Console.WriteLine("Invalid Input");
                goto startAgain;
            }
        }
    }
}