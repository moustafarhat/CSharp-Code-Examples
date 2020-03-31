namespace BuilderDesignPattern
{
    internal class VehicleCreator
    {
        private readonly VehicleBuilder _builder;

        public VehicleCreator(VehicleBuilder builder)
        {
            _builder = builder;
        }

        public void CreateVehicle()
        {
            _builder.CreateVehicle();
            _builder.SetModel();
            _builder.SetEngine();
            _builder.SetBody();
            _builder.SetDoors();
            _builder.SetTransmission();
            _builder.SetAccessories();
        }

        public Vehicle GetVehicle()
        {
            return _builder.GetVehicle();
        }
    }
}