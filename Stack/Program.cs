using System.Collections.Generic;

namespace Stack
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var stack = new Stack<string>();

            // Push items in a stack
            stack.Push("http://www.google.com");

            // Check to see if the stack contains a given item
            var contains = stack.Contains("http://www.google.com");

            // Remove and return the item on the top of the stack
            var top = stack.Pop();

            // Return the item on the top of the stack without removing it
            var top2 = stack.Peek();

            // Get the number of items in stack
            var count = stack.Count;

            // Remove all items from stack
            stack.Clear();
        }
    }
}