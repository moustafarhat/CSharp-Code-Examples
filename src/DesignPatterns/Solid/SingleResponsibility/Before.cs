namespace DesignPatterns.Solid.SingleResponsibility.Before;

/// <summary>
/// ❌ Calculates the total AND decides how the invoice looks. A change to the layout
/// and a change to the tax rules both land in this one class.
/// </summary>
public sealed class Invoice(IReadOnlyList<(string Item, decimal Price)> lines)
{
    public string Print()
    {
        var subtotal = lines.Sum(line => line.Price);
        var total = subtotal * 1.19m;
        var body = string.Join(Environment.NewLine, lines.Select(line => $"{line.Item}: {line.Price:0.00}"));
        return $"{body}{Environment.NewLine}Total: {total:0.00}";
    }
}
