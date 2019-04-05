using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsPart4
{
    class Program
    {
        static void Main(string[] args)
        {
            string guestName = "";

            Console.WriteLine("Hello, Dear Guest, what is your name?");

            guestName = Console.ReadLine();

            if (guestName == string.Empty)
                WelcomeGuest();
            else
                WelcomeGuest(guestName);

        }

        static void WelcomeGuest()
        {
            Console.WriteLine("Okay, we hope you enjoy staying at our hotel");
        }

        static void WelcomeGuest(string name)
        {
            Console.WriteLine($"Thank you {name}, we hope you enjoy staying at our hotel");
        }
    }
}
