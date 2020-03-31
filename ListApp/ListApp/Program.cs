using System;
using System.Collections.Generic;

namespace ListApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Creating
            List<string> firstList = new List<string>();
            IList<string> secondList = new List<string>();
            // Adding
            firstList.Add("England");
            firstList.Add("Hungary");
            firstList.Add("China");
            firstList.Add("Germany");
            firstList.Add("Egypt");
            // Displaying
            foreach (var item in firstList)
            {
                Console.WriteLine(item);
            }
            // Index
            firstList[2] = "South Korea";
            //Console.WriteLine(firstList[2]);
            foreach (var item in firstList)
            {
                Console.WriteLine(item);
            }
            // Capacity
            Console.WriteLine("Count is " + firstList.Count);
            // Sorting
            Console.WriteLine("After Sorting...");
            firstList.Sort();
            foreach (var item in firstList)
            {
                Console.WriteLine(item);
            }
            // Reversing
            //Console.WriteLine("After Reversing...");
            firstList.Reverse();
            //foreach (var item in firstList)
            //{
            //    Console.WriteLine(item);
            //}
            // Removing
            Console.WriteLine("------------");
            Console.WriteLine("After Removing...");
            firstList.Remove("Germany");
            firstList.RemoveAt(0);
            foreach (var item in firstList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Count now is " + firstList.Count);
            // Remove all
            //firstList.Clear();
            // Contains
            Console.WriteLine("------------");
            Console.WriteLine(firstList.Contains("Egypt"));
            // GetRange
            secondList = firstList.GetRange(0, 3);
            Console.WriteLine("Now we are in the second list");
            foreach (var item in secondList)
            {
                Console.WriteLine(item);
            }
        }
    }
}