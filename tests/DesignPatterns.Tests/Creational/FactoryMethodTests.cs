using DesignPatterns.Creational.FactoryMethod;

namespace DesignPatterns.Tests.Creational;

public class FactoryMethodTests
{
    public static TheoryData<LoggerCreator, string> Creators => new()
    {
        { new FileLoggerCreator(), "[file] disk almost full" },
        { new DatabaseLoggerCreator(), "[database] disk almost full" },
        { new ConsoleLoggerCreator(), "[console] disk almost full" },
    };

    [Theory]
    [MemberData(nameof(Creators))]
    public void Each_creator_uses_the_logger_its_factory_method_creates(LoggerCreator creator, string expected)
    {
        Assert.Equal(expected, creator.Write("  disk almost full  "));
    }
}
