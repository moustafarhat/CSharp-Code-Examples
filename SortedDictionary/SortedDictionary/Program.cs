using System;
using System.Collections.Generic;

namespace SortedDictionary
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            SortedDictionary<int, string> colors = new SortedDictionary<int, string>();
            colors.Add(4, "Blue");
            colors.Add(2, "Yellow");
            colors.Add(1, "Orange");
            colors.Add(5, "Black");
            colors.Add(3, "White");

            foreach (var item in colors)
            {
                Console.WriteLine(item.Value);
            }

            colors[2] = "Purple";

            foreach (var item in colors)
            {
                Console.WriteLine(item.Value);
            }

            Console.WriteLine("After Removing");
            colors.Remove(1);
            foreach (var item in colors)
            {
                Console.WriteLine(item.Value);
            }

            colors.Clear();
        }
    }
}