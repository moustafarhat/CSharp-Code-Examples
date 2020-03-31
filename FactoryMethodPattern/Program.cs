using FactoryMethodPattern.FactoryMethodWithSingletonAndPrototype;

namespace FactoryMethodPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //var item=VehicleFactory.Build(3);
            //Console.WriteLine("Hello World!");
            var leadCustomer = CustomerFactory.GenerateCustomer("Lead");
            leadCustomer.Address = "Germany";
        }
    }
}