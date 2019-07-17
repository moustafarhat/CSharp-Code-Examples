using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<int, Customer>();
            var m= new Customer();
            dictionary.Add(1,m);

            // Return the customer with ID 1234 
            var customer = dictionary[1];

            // Removing an object by its key
            dictionary.Remove(1);

            // Removing all objects
            dictionary.Clear();

            var count = dictionary.Count;

            var containsKey = dictionary.ContainsKey(1);

            var containsValue = dictionary.ContainsValue(m);

            // Iterate over keys 
            foreach (var key in dictionary.Keys)
                Console.WriteLine(dictionary[key]);

            // Iterate over values
            foreach (var value in dictionary.Values)
                Console.WriteLine(value);

            // Iterate over dictionary
            foreach (var keyValuePair in dictionary)
            {
                Console.WriteLine(keyValuePair.Key);
                Console.WriteLine(keyValuePair.Value);
            }
        }
    }
}
