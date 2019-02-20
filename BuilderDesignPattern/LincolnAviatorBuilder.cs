using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesignPattern
{
    class LincolnAviatorBuilder : VehicleBuilder
    {
        public override void SetModel()
        {
            Vehicle.Model = "Lincoln Aviator";
        }
        public override void SetEngine()
        {
            Vehicle.Engine = "4.6 L DOHC Modular V8";
        }
        public override void SetTransmission()
        {
            Vehicle.Transmission = "5-speed automatic";
        }
        public override void SetBody()
        {
            Vehicle.Body = "SUV";
        }
        public override void SetDoors()
        {
            Vehicle.Doors = 4;
        }
        public override void SetAccessories()
        {
            Vehicle.Accessories.Add("Leather Look Seat Covers");
            Vehicle.Accessories.Add("Chequered Plate Racing Floor");
            Vehicle.Accessories.Add("4x 200 Watt Coaxial Speekers");
            Vehicle.Accessories.Add("500 Watt Bass Subwoofer");
        }
    }
}
