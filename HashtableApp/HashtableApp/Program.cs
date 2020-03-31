using System;
using System.Collections;

namespace HashtableApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Creating
            Hashtable hash = new Hashtable();

            // Adding
            hash.Add("Microsoft", "USA");
            hash.Add("Sony", "Japan");
            hash.Add("IKEA", "Sweden");
            hash.Add("Mercedes", "Germany");

            // Displaying

            foreach (DictionaryEntry item in hash)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
            // Capacity

            Console.WriteLine("Count is " + hash.Count);

            // Remove
            Console.WriteLine("------------");
            Console.WriteLine("After Removing");
            //hash.Remove("IKEA");
            foreach (DictionaryEntry item in hash)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
            // Contains
            Console.WriteLine("------------");
            Console.WriteLine("Contains condition");
            if (hash.ContainsValue("China"))
            {
                Console.WriteLine("Yes Japan is included");
            }
            else
            {
                Console.WriteLine("No it is not");
            }
            // Copy to ArrayList
            Console.WriteLine("------------");
            Console.WriteLine("After copying");
            ArrayList array = new ArrayList(hash.Keys);
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}