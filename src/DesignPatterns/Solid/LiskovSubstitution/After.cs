namespace DesignPatterns.Solid.LiskovSubstitution.After;

/// <summary>
/// ✅ Capabilities are split, so a type only promises what it can actually do.
/// </summary>
public interface IDiscountable
{
    decimal Discount(decimal amount);
}

public interface IPersistable
{
    string Save();
}

public class Customer : IDiscountable, IPersistable
{
    public virtual decimal Discount(decimal amount) => amount * 0.05m;

    public string Save() => $"{GetType().Name} saved";
}

public sealed class GoldCustomer : Customer
{
    public override decimal Discount(decimal amount) => amount * 0.10m;
}

// An enquiry can be offered a discount, but never claims it can be saved.
public sealed class Enquiry : IDiscountable
{
    public decimal Discount(decimal amount) => amount * 0.05m;
}

public static class CustomerRepository
{
    // Every IPersistable can be saved: the compiler won't let an Enquiry in here.
    public static IReadOnlyList<string> SaveAll(IEnumerable<IPersistable> items) =>
        items.Select(item => item.Save()).ToList();
}
