using System.Globalization;

namespace DesignPatterns.Solid.SingleResponsibility.After;

public sealed record InvoiceLine(string Item, decimal Price);

/// <summary>
/// ✅ Only knows how to calculate amounts.
/// </summary>
public sealed class InvoiceCalculator(decimal taxRate)
{
    public static decimal Subtotal(IEnumerable<InvoiceLine> lines) => lines.Sum(line => line.Price);

    public decimal Total(IEnumerable<InvoiceLine> lines) => Math.Round(Subtotal(lines) * (1 + taxRate), 2);
}

/// <summary>
/// ✅ Only knows how an invoice looks. It can change without touching the maths.
/// </summary>
public sealed class InvoicePrinter(InvoiceCalculator calculator)
{
    public string Print(IReadOnlyList<InvoiceLine> lines)
    {
        var body = lines.Select(line => string.Create(CultureInfo.InvariantCulture, $"{line.Item}: {line.Price:0.00}"));
        var total = string.Create(CultureInfo.InvariantCulture, $"Total: {calculator.Total(lines):0.00}");
        return string.Join('\n', body.Append(total));
    }
}
