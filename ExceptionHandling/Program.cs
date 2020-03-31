using System;

namespace ExceptionHandling
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int x = 0;
            int y = 9;
            double div = 0;

            try
            {
                div = y / x;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error is :" + e.Message);
            }
            finally
            {
                Console.WriteLine("Result is : " + div);
            }
        }
    }
}