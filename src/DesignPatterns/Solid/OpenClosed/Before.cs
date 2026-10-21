namespace DesignPatterns.Solid.OpenClosed.Before;

public enum CustomerType
{
    Regular,
    Silver,
    Gold,
}

/// <summary>
/// ❌ Adding a new customer type means editing this switch, and re-testing every existing branch.
/// </summary>
public static class DiscountCalculator
{
    public static decimal Apply(CustomerType type, decimal amount) => type switch
    {
        CustomerType.Silver => amount * 0.95m,
        CustomerType.Gold => amount * 0.90m,
        _ => amount,
    };
}
