using System;
using System.Collections.Generic;

namespace GenericStacks
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Stack<string> Ram = new Stack<string>();

            Ram.Push("Visual Studio");
            Ram.Push("Photoshop");
            Ram.Push("Google Chrome");
            Ram.Push("NotePad");
            Ram.Push("Excel");

            Console.WriteLine("What is on the top is " + Ram.Peek());
            Ram.Pop();
            Ram.Pop();
            Console.WriteLine("What is on the top is " + Ram.Peek());
            foreach (var item in Ram)
            {
                Console.WriteLine(item);
            }
        }
    }
}