using System.Collections.Generic;

namespace FactoryMethodPattern.FactoryMethodWithSingletonAndPrototype
{
    public static class CustomerFactory
    {
        private static IDictionary<string, ICustomer> _customersType = null;

        private static void  LoadCustomer()
        {
            _customersType = new Dictionary<string, ICustomer>()
            {
                {"Lead", new Lead()},
                {"Customer", new Customer()}
            };
        }

        public static ICustomer GenerateCustomer(string customerType)
        {
            if (_customersType==null)
                LoadCustomer();
             return _customersType?[customerType].Clone();
        }
    }
}
