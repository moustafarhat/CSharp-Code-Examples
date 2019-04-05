using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleInheritanceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            FourWheeledVehicles car = new FourWheeledVehicles();
            car.ChangeColor();

            car.StartVehicle();

            car.RunAtFullSpeed();
        }
    }
}
