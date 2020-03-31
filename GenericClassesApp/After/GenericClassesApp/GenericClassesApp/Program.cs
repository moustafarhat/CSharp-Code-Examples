using System;

namespace GenericClassesApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /*
             * Empire State : 381m, 443m, 365000t, NY
             * Burj Khalifa : 828m, 830m, 450000t, Dubai
             * Eiffel Tower : 300m, 324,  7300t  , Paris
             */
            Buildings<int> empireState = new Buildings<int>();
            empireState.Name = "Empire State";
            empireState.City = "New York";
            empireState.Height = 443;
            empireState.Weight = 365000;

            Console.WriteLine("Name " + empireState.Name);
            Console.WriteLine("City " + empireState.City);
            Console.WriteLine("Height " + empireState.Height);
            Console.WriteLine("Weight " + empireState.Weight);

            Buildings<double> burjKhalifa = new Buildings<double>();
            burjKhalifa.Name = "Burj Khalifa";
            burjKhalifa.City = "Dubai";
            burjKhalifa.Height = 830;
            burjKhalifa.Weight = 450000;

            Console.WriteLine("-------------");
            Console.WriteLine("Name " + burjKhalifa.Name);
            Console.WriteLine("City " + burjKhalifa.City);
            Console.WriteLine("Height " + burjKhalifa.Height);
            Console.WriteLine("Weight " + burjKhalifa.Weight);

            Buildings<float> eiffelTower = new Buildings<float>();
            eiffelTower.Name = "Eiffel Tower";
            eiffelTower.City = "Paris";
            eiffelTower.Height = 324;
            eiffelTower.Weight = 7300;
        }
    }

    internal class Buildings<T>
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string city;

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        private T height;

        public T Height
        {
            get { return height; }
            set { height = value; }
        }

        private T weight;

        public T Weight
        {
            get { return weight; }
            set { weight = value; }
        }
    }
}