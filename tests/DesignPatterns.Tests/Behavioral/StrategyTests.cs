using DesignPatterns.Behavioral.Strategy;

namespace DesignPatterns.Tests.Behavioral;

public class StrategyTests
{
    public static TheoryData<IOperation, decimal> Operations => new()
    {
        { new Addition(), 7m },
        { new Subtraction(), -1m },
        { new Multiplication(), 12m },
        { new Division(), 0.75m },
    };

    [Theory]
    [MemberData(nameof(Operations))]
    public void Calculator_delegates_to_its_strategy(IOperation operation, decimal expected)
    {
        Assert.Equal(expected, new Calculator(operation).Calculate(3, 4));
    }

    [Fact]
    public void Strategy_can_be_swapped_at_runtime()
    {
        var calculator = new Calculator(new Addition());
        Assert.Equal("6 + 2 = 8", calculator.Describe(6, 2));

        calculator.Operation = new Division();

        Assert.Equal("6 / 2 = 3", calculator.Describe(6, 2));
    }

    [Fact]
    public void Division_by_zero_throws()
    {
        var calculator = new Calculator(new Division());

        Assert.Throws<DivideByZeroException>(() => calculator.Calculate(1, 0));
    }
}
