using System;
using System.Collections;

namespace Queues
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Creating
            Queue queue = new Queue();
            // Adding
            queue.Enqueue("Cavin");
            queue.Enqueue("Tom");
            queue.Enqueue("Emma");

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            // Removing
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
        }
    }
}