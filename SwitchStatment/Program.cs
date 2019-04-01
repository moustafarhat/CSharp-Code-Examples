using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Are you enjoying C#? (Yes or No)");

            var input = Console.ReadLine();

            switch (input)
            {
                case "Yes": Console.WriteLine("This is very good"); break;
                case "No": Console.WriteLine("So sorry that you are not enjoying");break;
                default: Console.WriteLine("This is not a correct answer");break;
            }
        }
    }
}
