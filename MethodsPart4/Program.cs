using System;

namespace MethodsPart4
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string guestName = "";

            Console.WriteLine("Hello, Dear Guest, what is your name?");

            guestName = Console.ReadLine();

            if (guestName == string.Empty)
                WelcomeGuest();
            else
                WelcomeGuest(guestName);
        }

        private static void WelcomeGuest()
        {
            Console.WriteLine("Okay, we hope you enjoy staying at our hotel");
        }

        private static void WelcomeGuest(string name)
        {
            Console.WriteLine($"Thank you {name}, we hope you enjoy staying at our hotel");
        }
    }
}