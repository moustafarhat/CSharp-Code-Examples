namespace DesignPatterns.Behavioral.Strategy;

public interface IOperation
{
    string Symbol { get; }

    decimal Apply(decimal left, decimal right);
}

public sealed class Addition : IOperation
{
    public string Symbol => "+";

    public decimal Apply(decimal left, decimal right) => left + right;
}

public sealed class Subtraction : IOperation
{
    public string Symbol => "-";

    public decimal Apply(decimal left, decimal right) => left - right;
}

public sealed class Multiplication : IOperation
{
    public string Symbol => "*";

    public decimal Apply(decimal left, decimal right) => left * right;
}

public sealed class Division : IOperation
{
    public string Symbol => "/";

    // decimal division keeps the fraction (3 / 4 = 0.75) and throws DivideByZeroException for 0.
    public decimal Apply(decimal left, decimal right) => left / right;
}

/// <summary>
/// The context: it runs whichever strategy it was given and can swap it at runtime.
/// </summary>
public sealed class Calculator(IOperation operation)
{
    public IOperation Operation { get; set; } = operation;

    public decimal Calculate(decimal left, decimal right) => Operation.Apply(left, right);

    public string Describe(decimal left, decimal right) =>
        $"{left} {Operation.Symbol} {right} = {Calculate(left, right)}";
}
