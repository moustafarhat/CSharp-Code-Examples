using System;

namespace BuilderDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var vehicleCreator = new VehicleCreator(new FordExplorerBuilder());
            vehicleCreator.CreateVehicle();
            var vehicle = vehicleCreator.GetVehicle();
            vehicle.ShowInfo();
            Console.WriteLine("---------------------------------------------");
            vehicleCreator = new VehicleCreator(new LincolnAviatorBuilder());
            vehicleCreator.CreateVehicle();
            vehicle = vehicleCreator.GetVehicle();
            vehicle.ShowInfo();
            Console.ReadKey();
        }
    }
}
