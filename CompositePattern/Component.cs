namespace CompositePattern
{
    public abstract class Component
    {
        protected Component()
        {
        }

        public abstract void Operation();

        public abstract void Add(Component c);

        public abstract void Remove(Component c);

        public abstract bool IsComposite();
    }
}