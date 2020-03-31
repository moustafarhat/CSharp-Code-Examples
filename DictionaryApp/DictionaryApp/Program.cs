using System;
using System.Collections.Generic;
using System.Linq;

namespace DictionaryApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Creating
            Dictionary<string, string> capitals = new Dictionary<string, string>();

            // Creating with initialization
            Dictionary<int, string> names = new Dictionary<int, string>()
            {
                { 1,"James"},
                { 2,"Jack"},
                { 3,"Emma"},
            };
            foreach (var item in names)
            {
                Console.WriteLine(item.Value);
            }
            // Add
            capitals.Add("Russia", "Moscow");
            capitals.Add("Italy", "Rome");
            capitals.Add("England", "London");
            capitals.Add("Spain", "Madrid");
            capitals.Add("Germany", "Berlin");
            // Displaying
            //foreach (var item in capitals)
            //{
            //    Console.WriteLine(item.Key);
            //}
            for (int i = 0; i < capitals.Count; i++)
            {
                Console.WriteLine(capitals[capitals.Keys.ElementAt(i)]);
            }
            // Index
            Console.WriteLine("--------");
            capitals["Italy"] = "Venice";
            Console.WriteLine(capitals["Italy"]);

            //Capacity

            // Try get value
            capitals.TryGetValue("Russia", out string result);
            if (result != null)
                Console.WriteLine("Result is " + result);
            // Remove
            capitals.Remove("Italy");
            Console.WriteLine("--------");
            Console.WriteLine("After removing");
            for (int i = 0; i < capitals.Count; i++)
            {
                Console.WriteLine(capitals[capitals.Keys.ElementAt(i)]);
            }
            Console.WriteLine(capitals.Count);
            // Remove all
            //capitals.Clear();
            Console.WriteLine(capitals.Count);
            // Contains
            Console.WriteLine(capitals.ContainsKey("France"));
        }
    }
}