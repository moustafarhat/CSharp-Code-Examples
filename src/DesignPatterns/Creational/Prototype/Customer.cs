namespace DesignPatterns.Creational.Prototype;

public interface IPrototype<out T>
{
    T Clone();
}

public sealed class Customer : IPrototype<Customer>
{
    public required string Type { get; init; }

    public string Name { get; set; } = string.Empty;

    public decimal CreditLimit { get; set; }

    public List<string> Tags { get; init; } = [];

    /// <summary>
    /// Deep copy: the clone gets its own <see cref="Tags"/> list, so changing it
    /// never leaks back into the template it was cloned from.
    /// </summary>
    public Customer Clone() => new()
    {
        Type = Type,
        Name = Name,
        CreditLimit = CreditLimit,
        Tags = [.. Tags],
    };
}
