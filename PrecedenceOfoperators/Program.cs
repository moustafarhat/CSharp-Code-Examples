using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrecedenceOfoperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            x = (2 + 3) * 2 - 4 + 2;
            Console.WriteLine(x);
        }
    }
}
