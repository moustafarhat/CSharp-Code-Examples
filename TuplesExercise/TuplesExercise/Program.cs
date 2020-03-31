using System;
using System.Collections.Generic;

namespace TuplesExercise
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var employeesInformation = new List<Tuple<int, string, string, DateTime>>();
            employeesInformation.Add(new Tuple<int, string, string, DateTime>(3, "Zack", "Peter", new DateTime(2017, 11, 25)));
            employeesInformation.Add(Tuple.Create(1, "Adam", "Green", new DateTime(2015, 01, 01)));
            employeesInformation.Add(Tuple.Create(4, "John", "Smith", new DateTime(2016, 10, 25)));
            employeesInformation.Add(Tuple.Create(2, "Emma", "Watson", new DateTime(2017, 10, 25)));

            Console.WriteLine("Before sorting");
            foreach (var employee in employeesInformation)
            {
                Console.WriteLine($"{employee.Item1},{employee.Item2},{employee.Item3},{employee.Item4}");
            }

            Console.WriteLine("\nAfter sorting");
            employeesInformation.Sort();
            foreach (var employee in employeesInformation)
            {
                Console.WriteLine($"{employee.Item1},{employee.Item2},{employee.Item3},{employee.Item4}");
            }

            Console.WriteLine("\nAfter reversing");
            employeesInformation.Reverse();
            foreach (var employee in employeesInformation)
            {
                Console.WriteLine($"{employee.Item1},{employee.Item2},{employee.Item3},{employee.Item4}");
            }
        }
    }
}