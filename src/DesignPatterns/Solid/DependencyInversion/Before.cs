namespace DesignPatterns.Solid.DependencyInversion.Before;

public sealed class FileLogger
{
    private readonly string _path = "errors.log";

    public void Log(string message) => File.AppendAllText(_path, message + Environment.NewLine);
}

/// <summary>
/// ❌ The high-level service creates its own low-level logger. It can't log anywhere else,
/// and a unit test can't run it without writing to disk.
/// </summary>
public sealed class CustomerService
{
    private readonly FileLogger _logger = new();

    public void Register(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            _logger.Log("Rejected a customer with no name.");
        }
    }
}
