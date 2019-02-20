using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesignPattern
{
    class FordExplorerBuilder : VehicleBuilder
    {
        public override void SetModel()
        {
            Vehicle.Model = "Ford Explorer";
        }
        public override void SetEngine()
        {
            Vehicle.Engine = "4.0 L Cologne V6";
        }
        public override void SetTransmission()
        {
            Vehicle.Transmission = "5-speed M5OD-R1 manual";
        }
        public override void SetBody()
        {
            Vehicle.Body = "SUV";
        }
        public override void SetDoors()
        {
            Vehicle.Doors = 5;
        }
        public override void SetAccessories()
        {
            Vehicle.Accessories.Add("Car Cover");
            Vehicle.Accessories.Add("Sun Shade");
        }
    }
}
