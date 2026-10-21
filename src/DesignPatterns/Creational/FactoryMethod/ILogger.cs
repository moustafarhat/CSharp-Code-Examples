namespace DesignPatterns.Creational.FactoryMethod;

public interface ILogger
{
    string Log(string message);
}

public sealed class FileLogger : ILogger
{
    public string Log(string message) => $"[file] {message}";
}

public sealed class DatabaseLogger : ILogger
{
    public string Log(string message) => $"[database] {message}";
}

public sealed class ConsoleLogger : ILogger
{
    public string Log(string message) => $"[console] {message}";
}
