using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 7;
            int y = 2;
            int result = 0;
            result = x % y;
            Console.WriteLine("Rem: " + result);
        }
    }
}
