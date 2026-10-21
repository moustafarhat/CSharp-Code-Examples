namespace DesignPatterns.Solid.InterfaceSegregation.Before;

/// <summary>
/// ❌ One fat interface forces every device to implement features it doesn't have.
/// </summary>
public interface IMultiFunctionDevice
{
    string Print(string document);

    string Scan(string document);

    string Fax(string document);
}

public sealed class BasicPrinter : IMultiFunctionDevice
{
    public string Print(string document) => $"Printed {document}";

    public string Scan(string document) => throw new NotSupportedException();

    public string Fax(string document) => throw new NotSupportedException();
}
