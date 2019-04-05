using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyOwnNamespace.GameOfThrones;

namespace Namespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine();
            MyOwnNamespace.Animal animal = new MyOwnNamespace.Animal();
            animal.SayHi();
            //MyOwnNamespace.GameOfThrones.HouseStark.sayQuote();
            HouseStark.sayQuote();
        }
    }
}

namespace MyOwnNamespace
{
    class Animal
    {
        public string animalColor;

        public void SayHi()
        {
            Console.WriteLine("Hi from the custom namespace");
        }
    }

    class Trainers
    {
    }

    namespace GameOfThrones
    {
        class HouseStark
        {
            public static void sayQuote()
            {
                Console.WriteLine("The north remembers");
            }
        }
    }
}
