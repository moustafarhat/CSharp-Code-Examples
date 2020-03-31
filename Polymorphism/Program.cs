using System;

namespace Polymorphism
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Shapes[] shapes = new Shapes[4];
            shapes[0] = new Shapes();
            shapes[1] = new Circles();
            shapes[2] = new Lines();
            shapes[3] = new Triangle();

            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }
    }

    internal class Shapes
    {
        public virtual void Draw()
        {
            Console.WriteLine("I am a simple shape");
        }
    }

    internal class Circles : Shapes
    {
        public new void Draw()
        {
            Console.WriteLine("I am circle");
        }
    }

    internal class Lines : Shapes
    {
        public override void Draw()
        {
            Console.WriteLine("I am line");
        }
    }

    internal class Triangle : Shapes
    {
        public override void Draw()
        {
            Console.WriteLine("I am triangle");
        }
    }
}