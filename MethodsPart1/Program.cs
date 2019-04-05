using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsPart1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            int addResult = 0;

            a = 5;
            b = 3;
            addResult = a + b;
            Console.WriteLine($" {a} + {b} = {addResult}");
            DisplayMessage();

            c = 15;
            d = 10;
            addResult = c + d;
            Console.WriteLine($" {c} + {d} = {addResult}");
            DisplayMessage();

        }

        static void DisplayMessage()
        {
            Console.WriteLine("Process is done");
            Console.WriteLine("This process is run by ahmad");
            Console.WriteLine("Finished on time : "+DateTime.Now.ToShortTimeString());
        }
    }
}
