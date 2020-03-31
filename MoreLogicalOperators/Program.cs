using System;

namespace MoreLogicalOperators
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            bool username = false;
            bool email = false;
            bool password = true;

            if ((username || email) && password)
                Console.WriteLine("User is valid.");
            else
                Console.WriteLine("Something went wrong");
        }
    }
}