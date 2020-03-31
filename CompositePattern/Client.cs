using System;

namespace CompositePattern
{
    public class Client
    {
        public void ClientCode(Component leaf)
        {
            Console.Write("RESULT: ");
            leaf.Operation();
        }

        public void ClientCode2(Component component1, Component component2)
        {
            if (component1.IsComposite())
            {
                component1.Add(component2);
            }
            Console.Write("RESULT: ");
            component1.Operation();

            Console.WriteLine();
        }
    }
}