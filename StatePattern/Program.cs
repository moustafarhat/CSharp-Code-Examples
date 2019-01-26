using System;
using StatePattern.States;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new Context();
            var startState = new StartState();
            startState.DoAction(context);

            Console.WriteLine(context.ToString());

            var stopState = new StopState();
            stopState.DoAction(context);

            Console.WriteLine(context.ToString());

            Console.ReadKey();
        }
    }
}
