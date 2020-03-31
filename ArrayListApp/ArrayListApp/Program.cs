using System;
using System.Collections;

namespace ArrayListApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Creating
            ArrayList array = new ArrayList();
            // Adding
            array.Add("James");
            array.Add("David");
            array.Add("Charles");
            array.Add("Ahmad");

            Console.WriteLine("At first");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------");
            Console.WriteLine("After insertion");
            Console.WriteLine("Count is " + array.Count);
            array.Insert(2, "Tim");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            // Index
            Console.WriteLine("---------");
            Console.WriteLine(array[2].ToString());
            // Capacity
            Console.WriteLine("---------");
            Console.WriteLine("Count is " + array.Count);
            // Sorting
            Console.WriteLine("---------");
            array.Sort();
            Console.WriteLine("After Sorting");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            // Reversing
            Console.WriteLine("---------");
            array.Reverse();
            Console.WriteLine("After Reversing");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            // Removing
            Console.WriteLine("---------");
            Console.WriteLine("After Removing");
            //array.Remove("James");
            //array.RemoveAt(2);
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            // Remove all
            Console.WriteLine("---------");
            Console.WriteLine("After Removing some");
            //array.RemoveRange(1, 2);
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            // Contains
            Console.WriteLine("---------");
            Console.WriteLine("After Asking if contains");
            Console.WriteLine(array.Contains("James"));
            // GetRange
            ArrayList names = new ArrayList();
            names = array.GetRange(0, 2);

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}