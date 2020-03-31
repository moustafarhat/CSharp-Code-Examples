using System;

namespace NestedTuples
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /*
             * 1.int    : employee number
             * 2.string : first name
             * 3.string : last name
             * 4.string : address
             * 5.string : city
             * 6.string : job title
             * 7.string : nationality
             * 8.tuple  : last 5 salaries
             */

            var employeeInfo = new Tuple<int, string, string, string, string, string, string, Tuple<decimal, decimal, decimal, decimal, decimal>>
                (105, "James", "Watson", "", "", "", "", Tuple.Create(8000m, 3000m, 4000m, 5000m, 5000m));

            Console.WriteLine("Employee name is " + employeeInfo.Item2);
            Console.WriteLine("Last 5 salaries");
            Console.WriteLine(employeeInfo.Rest.Item1);
            Console.WriteLine(employeeInfo.Rest.Item2);
            Console.WriteLine(employeeInfo.Rest.Item3);
            Console.WriteLine(employeeInfo.Rest.Item4);
            Console.WriteLine(employeeInfo.Rest.Item5);
        }
    }
}