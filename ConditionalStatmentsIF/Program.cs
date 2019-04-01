using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatmentsIF
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 5;
            var y = 7;

            x = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            y = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            if (x > y)
            {
                Console.WriteLine("Number one is greater than number two");
            }
            else if (x < y)
            {
                Console.WriteLine("Number one is less than number two");
            }
            else 
            {
                Console.WriteLine("They matches!!");
            }
         }
    }
}
