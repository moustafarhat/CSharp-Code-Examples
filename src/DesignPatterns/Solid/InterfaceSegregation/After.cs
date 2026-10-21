namespace DesignPatterns.Solid.InterfaceSegregation.After;

/// <summary>
/// ✅ Small, focused interfaces. Each device implements only what it supports.
/// </summary>
public interface IPrinter
{
    string Print(string document);
}

public interface IScanner
{
    string Scan(string document);
}

public interface IFax
{
    string Fax(string document);
}

public sealed class BasicPrinter : IPrinter
{
    public string Print(string document) => $"Printed {document}";
}

public sealed class OfficeMachine : IPrinter, IScanner, IFax
{
    public string Print(string document) => $"Printed {document}";

    public string Scan(string document) => $"Scanned {document}";

    public string Fax(string document) => $"Faxed {document}";
}
