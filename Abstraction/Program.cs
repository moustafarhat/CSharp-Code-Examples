using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Lines line = new Lines();
            line.SayHi(); line.Draw();
        }
    }

    abstract class Shapes
    {
        public abstract void Draw();
        public void SayHi()
        {
            Console.WriteLine("Hi from the abstact class");
        }
    }

    class Lines : Shapes
    {
        public override void Draw()
        {
            Console.WriteLine("Hi I am a line");
        }
    }
}
