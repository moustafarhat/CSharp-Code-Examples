using System;

namespace VehicleInheritanceExercise
{
    internal class Vehicle
    {
    }

    internal class WheeledVehicles : Vehicle
    {
        private string color;
        private decimal price;

        public string Color { get; set; }
        public decimal Price { get; set; }

        public void ChangeColor()
        {
            Console.WriteLine("Color is changing.\n Color has changed");
        }
    }

    internal class FourWheeledVehicles : WheeledVehicles
    {
        private string brandName;
        private int capacity;

        public string BrandName { get; set; }
        public int Capacity { get; set; }

        public void StartVehicle()
        {
            Console.WriteLine("Car has started");
        }

        public void RunAtFullSpeed()
        {
            Console.WriteLine("Car is running on full speed");
        }

        public FourWheeledVehicles()
        {
        }
    }
}