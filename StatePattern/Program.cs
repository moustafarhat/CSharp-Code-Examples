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
            startState.Handle(context);

            Console.WriteLine(context.GetState().ToString());

            var stopState = new StopState();
            stopState.Handle(context);

            Console.WriteLine(context.GetState().ToString());

            Console.ReadKey();
        }
    }
}
