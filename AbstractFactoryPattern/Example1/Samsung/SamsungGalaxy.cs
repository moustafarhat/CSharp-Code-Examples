using AbstractFactoryPattern.Example1.interfaces;

namespace AbstractFactoryPattern.Example1.Samsung
{
    /// <summary>  
    /// The 'ProductA2' class  
    /// </summary>  
    class SamsungGalaxy : ISmartPhone
    {
        public string GetModelDetails()
        {
            return "Model: Samsung Galaxy\nRAM: 2GB\nCamera: 13MP\n";
        }
    }
}
