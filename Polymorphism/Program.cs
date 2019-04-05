using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
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

    class Shapes
    {
        public virtual void Draw()
        {
            Console.WriteLine("I am a simple shape");
        }
    }

    class Circles : Shapes
    {
        public new void Draw()
        {
            Console.WriteLine("I am circle");
        }
    }

    class Lines : Shapes
    {
        public override void Draw()
        {
            Console.WriteLine("I am line");
        }
    }

    class Triangle : Shapes
    {
        public override void Draw()
        {
            Console.WriteLine("I am triangle");
        }
    }
}
