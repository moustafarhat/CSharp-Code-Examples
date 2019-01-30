using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    class Leaf :Component
    {
        public Leaf()
        {

        }

        public override void Operation()
        {
            Console.Write("LEAF");
        }

        public override void Add(Component component)
        {
            throw new NotImplementedException();
        }

        public override void Remove(Component component)
        {
            throw new NotImplementedException();
        }

        public override bool IsComposite()
        {
            return false;
        }
    }
}
