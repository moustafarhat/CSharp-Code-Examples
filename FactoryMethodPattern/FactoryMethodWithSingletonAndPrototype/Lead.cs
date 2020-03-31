using System;

namespace FactoryMethodPattern.FactoryMethodWithSingletonAndPrototype
{
    public class Lead : ICustomer
    {
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public decimal BillAmount { get; set; }
        public DateTime BillDate { get; set; }
        public string Address { get; set; }

        public void Validate()
        {
            throw new NotImplementedException();
        }

        public ICustomer Clone()
        {
            return (ICustomer)MemberwiseClone();
        }
    }
}