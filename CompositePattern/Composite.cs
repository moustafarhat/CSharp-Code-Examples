using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    internal class Composite :Component
    {
        readonly List<Component> _children = new List<Component>();

        public Composite()
        {

        }

        public override void Add(Component component)
        {
            _children.Add(component);
        }

        public override void Remove(Component component)
        {
            _children.Remove(component);
        }

        public override bool IsComposite()
        {
            return true;
        }

        public override void Operation()
        {
            var i = 0;

            Console.Write("Branch(");
            foreach (var component in _children)
            {
                component.Operation();
                if (i != _children.Count - 1)
                {
                    Console.Write("+");
                }
                i++;
            }
            Console.Write(")");
        }
    }
}
