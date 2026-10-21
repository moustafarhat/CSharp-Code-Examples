namespace DesignPatterns.Solid.OpenClosed.After;

/// <summary>
/// ✅ New discounts are added as new classes. Existing, tested code stays closed for modification.
/// </summary>
public interface IDiscountPolicy
{
    decimal Apply(decimal amount);
}

public sealed class NoDiscount : IDiscountPolicy
{
    public decimal Apply(decimal amount) => amount;
}

public sealed class PercentageDiscount(decimal percent) : IDiscountPolicy
{
    public decimal Apply(decimal amount) => amount * (1 - (percent / 100m));
}

// Added later without changing anything above.
public sealed class FixedAmountDiscount(decimal value) : IDiscountPolicy
{
    public decimal Apply(decimal amount) => Math.Max(0m, amount - value);
}

public sealed class Checkout(IDiscountPolicy discount)
{
    public decimal Total(decimal amount) => discount.Apply(amount);
}
