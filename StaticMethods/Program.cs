using System;

namespace StaticMethods
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Person person = new Person();
            person.SayHi();
            SayHi();
        }

        private static void SayHi()
        {
            Console.WriteLine("Hi!, from the static method");
        }
    }

    internal class Person
    {
        public void SayHi()
        {
            Console.WriteLine("Hi! from the non static method");
        }
    }
}