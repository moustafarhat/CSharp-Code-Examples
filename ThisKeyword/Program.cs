using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.DisplayName("James","Morrison");
        }
    }

    class Person
    {
        string firstName;
        string lastName;

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
