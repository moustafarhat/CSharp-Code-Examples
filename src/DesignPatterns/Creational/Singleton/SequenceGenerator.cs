namespace DesignPatterns.Creational.Singleton;

/// <summary>
/// Hands out unique, increasing numbers across the whole application.
/// There must be exactly one instance, otherwise two generators could issue the same number.
/// </summary>
public sealed class SequenceGenerator
{
    // Lazy<T> is thread-safe by default: the instance is created once, on first use.
    private static readonly Lazy<SequenceGenerator> LazyInstance = new(() => new SequenceGenerator());

    private long _current;

    private SequenceGenerator()
    {
    }

    public static SequenceGenerator Instance => LazyInstance.Value;

    public long Next() => Interlocked.Increment(ref _current);
}
