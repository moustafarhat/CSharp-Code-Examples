using AbstractFactoryPattern.Example1.interfaces;

namespace AbstractFactoryPattern.Example1.Nokia
{
    /// <summary>  
    /// The 'ConcreteFactory1' class.  
    /// </summary>  
    class Nokia : IMobilePhone
    {
        public ISmartPhone GetSmartPhone()
        {
            return new NokiaPixel();
        }

        public INormalPhone GetNormalPhone()
        {
            return new Nokia1600();
        }
    }
}
