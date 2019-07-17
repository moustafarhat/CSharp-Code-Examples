using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>();

            // Creating a list with an initial size
            var list2 = new List<int>(10000);

            // Add an item at the end of the list
            list.Add(4);

            // Add an item at index 0
            list.Insert(4, 0);

            // Remove an item from list
            list.Remove(1);

            // Remove the item at index 0
            list.RemoveAt(0);

            // Return the item at index 0
            var first = list[0];

            // Return the index of an item
            var index = list.IndexOf(4);

            // Check to see if the list contains an item
            var contains = list.Contains(4);

            // Return the number of items in the list 
            var count = list.Count;

            // Iterate over all objects in a list
            foreach (var item in list)
                Console.WriteLine(item);

        }
    }
}
