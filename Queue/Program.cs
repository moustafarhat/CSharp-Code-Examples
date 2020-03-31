using System.Collections.Generic;

namespace Queue
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var queue = new Queue<string>();

            // Add an item to the queue
            queue.Enqueue("transaction1");

            // Check to see if the queue contains a given item
            var contains = queue.Contains("transaction1");

            // Remove and return the item on the front of the queue
            var front = queue.Dequeue();

            // Return the item on the front without removing it
            var top = queue.Peek();

            // Remove all items from queue
            queue.Clear();

            // Get the number of items in the queue
            var count = queue.Count;
        }
    }
}