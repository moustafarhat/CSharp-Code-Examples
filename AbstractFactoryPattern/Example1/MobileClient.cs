using AbstractFactoryPattern.Example1.interfaces;

namespace AbstractFactoryPattern.Example1
{
    /// <summary>
    /// The 'Client' class
    /// </summary>
    internal class MobileClient
    {
        private readonly ISmartPhone _smartPhone;
        private readonly INormalPhone _normalPhone;

        public MobileClient(IMobilePhone factory)
        {
            _smartPhone = factory.GetSmartPhone();
            _normalPhone = factory.GetNormalPhone();
        }

        public string GetSmartPhoneModelDetails()
        {
            return _smartPhone.GetModelDetails();
        }

        public string GetNormalPhoneModelDetails()
        {
            return _normalPhone.GetModelDetails();
        }
    }
}