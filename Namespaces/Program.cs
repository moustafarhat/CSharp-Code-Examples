using MyOwnNamespace.GameOfThrones;
using System;

namespace Namespaces
{
    internal class Program
    {
        private static void Main(string[] args)
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
    internal class Animal
    {
        public string animalColor;

        public void SayHi()
        {
            Console.WriteLine("Hi from the custom namespace");
        }
    }

    internal class Trainers
    {
    }

    namespace GameOfThrones
    {
        internal class HouseStark
        {
            public static void sayQuote()
            {
                Console.WriteLine("The north remembers");
            }
        }
    }
}