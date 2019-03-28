using System;

namespace DecoratorPattern
{


    class Program
    {

        /// <summary>   
        /// Car Base component   
        /// </summary>   
        public interface ICar
        {
            string GetDescription();
            double GetCost();
        }

        /// <summary>   
        /// Concrete Car   
        /// </summary>   
        public class EconomyCar : ICar
        {
            public string GetDescription()
            {
                return "Economy Car";
            }

            public double GetCost()
            {
                return 450000.0;
            }
        }

        /// <summary>   
        /// Concrete Car   
        /// </summary>   
        public class DeluxCar : ICar
        {
            public string GetDescription()
            {
                return "Delux Car";
            }

            public double GetCost()
            {
                return 750000.0;
            }
        }

        /// <summary>   
        /// Concrete Car   
        /// </summary>   
        public class LuxuryCar : ICar
        {
            public string GetDescription()
            {
                return "Luxury Car";
            }

            public double GetCost()
            {
                return 1000000.0;
            }
        }

        /// <summary>   
        /// Abstract Decorator   
        /// </summary>   
        public abstract class CarAccessoriesDecorator : ICar
        {

            private ICar _car;

            public CarAccessoriesDecorator(ICar aCar)
            {
                this._car = aCar;
            }
            public virtual string GetDescription()
            {
                return this._car.GetDescription();
            }

            public virtual double GetCost()
            {
                return this._car.GetCost();
            }
        }

        /// <summary>   
        /// Concrete Decorator   
        /// </summary>   
        public class BasicAccessories : CarAccessoriesDecorator
        {
            public BasicAccessories(ICar aCar)
            : base(aCar)
            {

            }

            public override string GetDescription()
            {
                return base.GetDescription() + ",Basic Accessories Package";

            }

            public override double GetCost()
            {
                return base.GetCost() + 2000.0;
            }
        }

        /// <summary>   
        /// Concrete Decorator   
        /// </summary>   
        public class AdvancedAccessories : CarAccessoriesDecorator
        {
            public AdvancedAccessories(ICar aCar)
            : base(aCar)
            {

            }

            public override string GetDescription()
            {
                return base.GetDescription() + ",Advanced Accessories Package";
            }

            public override double GetCost()
            {
                return base.GetCost() + 10000.0;
            }
        }

        /// <summary>   
        /// Concrete Decorator   
        /// </summary>   
        public class SportsAccessories : CarAccessoriesDecorator
        {
            public SportsAccessories(ICar aCar)
            : base(aCar)
            {

            }

            public override string GetDescription()
            {
                return base.GetDescription() + ",Sports Accessories Package";
            }

            public override double GetCost()
            {
                return base.GetCost() + 15000.0;
            }
        }

        public class SuperLuxury : ICar
        {
            public string GetDescription()
            {
                return "Super Luxury Car";
            }

            public double GetCost()
            {
                return 1500000;
            }
        }



    static void Main(string[] args)
        {
            //Create EcomomyCar instance.   
            ICar objCar = new EconomyCar();

            //Wrp EconomyCar instancw with BasicAccessories.   
            CarAccessoriesDecorator objAccessoriesDecorator = new BasicAccessories(objCar);

            //Wrap EconomyCar instance with AdvancedAccessories instance.   
            objAccessoriesDecorator = new AdvancedAccessories(objAccessoriesDecorator);

            Console.Write("Car Detials: " + objAccessoriesDecorator.GetDescription());
            Console.WriteLine("\n\n");
            Console.Write("Total Price: " + objAccessoriesDecorator.GetCost());

            Console.Read();
        }
    }


}
