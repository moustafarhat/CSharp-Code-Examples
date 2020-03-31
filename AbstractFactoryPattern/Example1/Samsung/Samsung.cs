using AbstractFactoryPattern.Example1.interfaces;

namespace AbstractFactoryPattern.Example1.Samsung
{
    /// <summary>
    /// The 'ConcreteFactory2' class.
    /// </summary>
    internal class Samsung : IMobilePhone
    {
        public ISmartPhone GetSmartPhone()
        {
            return new SamsungGalaxy();
        }

        public INormalPhone GetNormalPhone()
        {
            return new SamsungGuru();
        }
    }
}