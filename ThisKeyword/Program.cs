using System;

namespace ThisKeyword
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Person person = new Person();
            person.DisplayName("James", "Morrison");
        }
    }

    internal class Person
    {
        private string firstName;
        private string lastName;

        public void DisplayName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }

        public void DisplayName(string firstName, string lastName)
        {
            Console.WriteLine(firstName + " " + lastName);
            Console.WriteLine(this.firstName + " " + this.lastName);
        }

        public Person()
        {
            firstName = "David";
            lastName = "Smith";
        }
    }
}