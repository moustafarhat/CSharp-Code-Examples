using System;
using System.Collections.Generic;
using System.Text;
using FactoryMethodPattern.Interface;

namespace FactoryMethodPattern
{
    public static class VehicleFactory
    {
        public static IVehicle Build(int number)
        {
            switch (number)
            {
                case 1:
                    return new Car();
                case 2:
                    return new Motorbike();
                case 3:
                    return new Truck();
                case 4:
                    return new Unicycle();
                default:
                    return null;
            }
        }
    }
}
