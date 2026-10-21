namespace DesignPatterns.Creational.FactoryMethod;

/// <summary>
/// The creator contains the logic that uses a logger, but leaves the choice of
/// which logger to create to its subclasses through <see cref="CreateLogger"/>.
/// </summary>
public abstract class LoggerCreator
{
    public string Write(string message)
    {
        var logger = CreateLogger();
        return logger.Log(message.Trim());
    }

    protected abstract ILogger CreateLogger();
}

public sealed class FileLoggerCreator : LoggerCreator
{
    protected override ILogger CreateLogger() => new FileLogger();
}

public sealed class DatabaseLoggerCreator : LoggerCreator
{
    protected override ILogger CreateLogger() => new DatabaseLogger();
}

public sealed class ConsoleLoggerCreator : LoggerCreator
{
    protected override ILogger CreateLogger() => new ConsoleLogger();
}
