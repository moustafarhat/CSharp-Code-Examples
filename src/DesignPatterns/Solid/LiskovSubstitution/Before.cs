namespace DesignPatterns.Solid.LiskovSubstitution.Before;

public class Customer
{
    public virtual decimal Discount(decimal amount) => amount * 0.05m;

    public virtual string Save() => $"{GetType().Name} saved";
}

public sealed class GoldCustomer : Customer
{
    public override decimal Discount(decimal amount) => amount * 0.10m;
}

/// <summary>
/// ❌ An enquiry is "a customer" that can't be saved. Code written against
/// <see cref="Customer"/> now breaks when it receives one.
/// </summary>
public sealed class Enquiry : Customer
{
    public override string Save() => throw new NotSupportedException("Enquiries cannot be saved.");
}

public static class CustomerRepository
{
    public static IReadOnlyList<string> SaveAll(IEnumerable<Customer> customers) =>
        customers.Select(customer => customer.Save()).ToList();
}
