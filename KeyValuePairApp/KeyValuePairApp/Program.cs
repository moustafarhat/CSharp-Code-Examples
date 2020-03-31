using System;
using System.Collections.Generic;

namespace KeyValuePairApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var capitals = new List<KeyValuePair<string, string>>();

            capitals.Add(new KeyValuePair<string, string>("Russia", "Moscow"));
            capitals.Add(new KeyValuePair<string, string>("Sweden", "Stockholm"));
            capitals.Add(new KeyValuePair<string, string>("Portual", "Lisbon"));
            capitals.Add(new KeyValuePair<string, string>("Japan", "Tokoyo"));

            capitals.RemoveAt(1);

            foreach (var item in capitals)
            {
                Console.WriteLine(item.Key);
            }

            Console.WriteLine(GetFirstAndLastName().Value);
        }

        public static KeyValuePair<string, string> GetFirstAndLastName()
        {
            string firstName = "Tony";
            string lastName = "Stark";

            return new KeyValuePair<string, string>(firstName, lastName);
        }
    }
}