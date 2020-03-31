using System;

namespace DataTypesInDepth
{
    internal class Program
    {
        private static void Main(string[] args)
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