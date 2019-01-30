using System;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Client();

            Component leaf = new Leaf();

            Console.WriteLine("Client: I get a simple component:");

            client.ClientCode(leaf);

            Console.WriteLine("\n");

            var tree = new Composite();
            var branch1 = new Composite();
            branch1.Add(new Leaf());
            branch1.Add(new Leaf());
            var branch2 = new Composite();
            branch2.Add(new Leaf());
            tree.Add(branch1);
            tree.Add(branch2);
            Console.WriteLine("Client: Now I get a composite tree:");
            client.ClientCode(tree);
            Console.WriteLine("\n");

            Console.Write("Client: I can merge two components without checking their classes:\n");
            client.ClientCode2(tree, leaf);
            Console.ReadKey();
        }
    }
}
