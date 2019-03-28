using System;
using CompositePattern.Example1;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {

            var colas = new Cola(210);
            colas.Flavors.Add(new VanillaCola(215));
            colas.Flavors.Add(new CherryCola(210));

            var lemonLime = new LemonLime(185);

            var rootBeers = new RootBeer(195);
            rootBeers.Flavors.Add(new VanillaRootBeer(200));
            rootBeers.Flavors.Add(new StrawberryRootBeer(200));

            SodaWater sodaWater = new SodaWater(180);
            sodaWater.Flavors.Add(colas);
            sodaWater.Flavors.Add(lemonLime);
            sodaWater.Flavors.Add(rootBeers);

            sodaWater.DisplayCalories();

            Console.ReadKey();


            //var client = new Client();

            //Component leaf = new Leaf();

            //Console.WriteLine("Client: I get a simple component:");

            //client.ClientCode(leaf);

            //Console.WriteLine("\n");

            //var tree = new Composite();
            //var branch1 = new Composite();
            //branch1.Add(new Leaf());
            //branch1.Add(new Leaf());
            //var branch2 = new Composite();
            //branch2.Add(new Leaf());
            //tree.Add(branch1);
            //tree.Add(branch2);
            //Console.WriteLine("Client: Now I get a composite tree:");
            //client.ClientCode(tree);
            //Console.WriteLine("\n");

            //Console.Write("Client: I can merge two components without checking their classes:\n");
            //client.ClientCode2(tree, leaf);
            //Console.ReadKey();
        }
    }
}
