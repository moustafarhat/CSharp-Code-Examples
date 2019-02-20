using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesignPattern
{
    public abstract class VehicleBuilder
    {
        protected Vehicle Vehicle;
        public Vehicle GetVehicle()
        {
            return Vehicle;
        }
        public void CreateVehicle()
        {
            Vehicle = new Vehicle();
        }
        public abstract void SetModel();
        public abstract void SetEngine();
        public abstract void SetTransmission();
        public abstract void SetBody();
        public abstract void SetDoors();
        public abstract void SetAccessories();
    }
}
