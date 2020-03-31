using System;

namespace FactoryMethodPattern.FactoryMethodWithSingletonAndPrototype
{
    public interface ICustomer
    {
        string CustomerName { get; set; }
        string PhoneNumber { get; set; }
        decimal BillAmount { get; set; }
        DateTime BillDate { get; set; }
        string Address { get; set; }

        void Validate();

        ICustomer Clone(); // Added an extra method clone
    }
}