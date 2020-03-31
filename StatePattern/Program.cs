using StatePattern.States;
using System;

namespace StatePattern
{
    internal class Program
    {
        private static void Main(string[] args)
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