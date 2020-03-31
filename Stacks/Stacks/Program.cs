using System;
using System.Collections;

namespace Stacks
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Creating
            Stack stack = new Stack();

            // Adding
            stack.Push("David");
            stack.Push("Emmy");
            stack.Push("Jack");
            stack.Push("Emma");

            // Removing

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }
    }
}