using AbstractFactoryPattern.Example1.interfaces;

namespace AbstractFactoryPattern.Example1.Nokia
{
    /// <summary>
    /// The 'ProductA1' class
    /// </summary>
    internal class NokiaPixel : ISmartPhone
    {
        public string GetModelDetails()
        {
            return "Model: Nokia Pixel\nRAM: 3GB\nCamera: 8MP\n";
        }
    }
}