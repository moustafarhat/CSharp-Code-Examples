namespace DesignPatterns.Solid.DependencyInversion.After;

/// <summary>
/// ✅ The abstraction is owned by the high-level code; details depend on it, not the other way round.
/// </summary>
public interface ILogger
{
    void Log(string message);
}

public sealed class FileLogger(string path) : ILogger
{
    public void Log(string message) => File.AppendAllText(path, message + Environment.NewLine);
}

public sealed class InMemoryLogger : ILogger
{
    private readonly List<string> _messages = [];

    public IReadOnlyList<string> Messages => _messages;

    public void Log(string message) => _messages.Add(message);
}

/// <summary>
/// Receives its dependency through the constructor, which is what lets a DI container
/// (or a test) decide which logger it gets.
/// </summary>
public sealed class CustomerService(ILogger logger)
{
    public bool Register(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            logger.Log("Rejected a customer with no name.");
            return false;
        }

        logger.Log($"Registered {name}.");
        return true;
    }
}
