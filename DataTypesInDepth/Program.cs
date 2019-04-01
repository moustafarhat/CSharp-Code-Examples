using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesInDepth
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 0;

            x = int.MinValue;

            Console.WriteLine(x);

            uint y = uint.MinValue;

            Console.WriteLine(y);

            Console.WriteLine(typeof(string).IsPrimitive);
        }
    }
}
