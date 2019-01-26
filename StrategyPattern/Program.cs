using System;
using StrategyPattern.Operations;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sum Operation
            var add= new Context(new SumOperation());
            Console.WriteLine(add.ExecuteOperation(3,4));

            //Sub Operation
            var sub = new Context(new SubOperation());
            Console.WriteLine(sub.ExecuteOperation(3, 4));

            //Mul Operation
            var mul = new Context(new MulOperation());
            Console.WriteLine(mul.ExecuteOperation(3, 4));

            //Div Operation
            var div = new Context(new DivOperation());
            Console.WriteLine(div.ExecuteOperation(3, 4));
            Console.ReadKey();
        }
    }
}
