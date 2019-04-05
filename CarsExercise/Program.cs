using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Mercedes mer = new Mercedes();
            mer.DisplayInfo();
        }
    }

    class Cars
    {
        private decimal _price;
        protected int MaxSpeed;
        public string Color;

        protected decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public virtual void DisplayInfo()
        {
            _price = 10000;
            MaxSpeed = 300;
            Color = "Black";

            Console.WriteLine($"Default values : price is {_price}, max speed is {MaxSpeed} and the color is {Color}");
        }
    }

    class Mercedes : Cars
    {
        public override void DisplayInfo()
        {
            base.DisplayInfo();

            base.Price = 15000;
            base.Color = "blue";
            base.MaxSpeed = 200;

            Console.WriteLine($"Overriden values : price is {Price}, max speed is {MaxSpeed} and the color is {Color}");
        }
    }
}
