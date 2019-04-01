using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;

            x = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            if (x % 2 == 0)
                Console.WriteLine(x + " is an even number");
            else
                Console.WriteLine(x + " is an odd number");
        }
    }
}
