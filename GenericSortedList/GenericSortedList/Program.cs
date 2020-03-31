using System;
using System.Collections;
using System.Collections.Generic;

namespace GenericSortedList
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Creating
            SortedList list = new SortedList(); // non generic sortedlist
            SortedList<string, string> phoneBook = new SortedList<string, string>(); // generic sortedlist

            // Adding
            phoneBook.Add("Jack", "823456789");
            phoneBook.Add("Willy", "944556789");
            phoneBook.Add("Charles", "123456744");
            phoneBook.Add("Jennifer", "623456784");
            phoneBook.Add("James", "010101023");

            // Displaying
            foreach (var item in phoneBook)
            {
                Console.WriteLine(item.Key + ", the mobile no is " + item.Value);
            }

            // Index
            phoneBook["Jack"] = "123456789";
            Console.WriteLine(phoneBook["Jack"]);
            // TryGetValue
            phoneBook.TryGetValue("James", out string number);
            Console.WriteLine(number);
            // Remove
            Console.WriteLine("------------");
            Console.WriteLine("After Removing");
            phoneBook.Remove("Willy");
            phoneBook.RemoveAt(1);
            foreach (var item in phoneBook)
            {
                Console.WriteLine(item.Key);
            }
            // Remove all
            Console.WriteLine(phoneBook.Count);
            //phoneBook.Clear();
            //Console.WriteLine(phoneBook.Count);
            // Contains
            Console.WriteLine(phoneBook.ContainsValue("010101024"));
        }
    }
}