using System;

namespace Abstraction
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Lines line = new Lines();
            line.SayHi(); line.Draw();
        }
    }

    internal abstract class Shapes
    {
        public abstract void Draw();

        public void SayHi()
        {
            Console.WriteLine("Hi from the abstact class");
        }
    }

    internal class Lines : Shapes
    {
        public override void Draw()
        {
            Console.WriteLine("Hi I am a line");
        }
    }
}