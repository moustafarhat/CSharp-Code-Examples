using System;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var item=VehicleFactory.Build(3);
            Console.WriteLine("Hello World!");
        }
    }
}
