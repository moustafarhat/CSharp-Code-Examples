namespace VehicleInheritanceExercise
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            FourWheeledVehicles car = new FourWheeledVehicles();
            car.ChangeColor();

            car.StartVehicle();

            car.RunAtFullSpeed();
        }
    }
}