using System;
using System.Collections.Specialized;

namespace NameValueCollectionApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Creating
            NameValueCollection cities = new NameValueCollection();
            // Adding
            cities.Add("Germany", "Berlin");
            cities.Add("Germany", "Hamburg");
            cities.Add("Germany", "Frankfurt");
            cities.Add("Italy", "Rome");
            cities.Add("Italy", "Milan");
            // Displaying
            foreach (string item in cities)
            {
                Console.Write(item + ": ");
                Console.WriteLine(cities[item]);
            }
            // Set
            cities.Set("Italy", "Venice");
            foreach (string item in cities)
            {
                Console.Write(item + ": ");
                Console.WriteLine(cities[item]);
            }
            // Contains
            //cities.Clear();
            //Console.WriteLine(cities.HasKeys());
            // Remove
            cities.Remove("Italy");
            foreach (string item in cities)
            {
                Console.Write(item + ": ");
                Console.WriteLine(cities[item]);
            }
            // Remove all
        }
    }
}