using DesignPatterns.Structural.Decorator;

namespace DesignPatterns.Tests.Structural;

public class DecoratorTests
{
    [Fact]
    public void A_plain_car_is_unchanged()
    {
        ICar car = new EconomyCar();

        Assert.Equal("Economy car", car.Description);
        Assert.Equal(18_000m, car.Price);
    }

    [Fact]
    public void Decorators_stack_their_description_and_price()
    {
        ICar car = new NavigationPackage(new SportsPackage(new LuxuryCar()));

        Assert.Equal("Luxury car, sports package, navigation", car.Description);
        Assert.Equal(55_000m + 3_500m + 800m, car.Price);
    }

    [Fact]
    public void The_same_decorator_can_be_applied_to_any_car()
    {
        ICar economy = new WinterPackage(new EconomyCar());
        ICar luxury = new WinterPackage(new LuxuryCar());

        Assert.Equal(1_200m, economy.Price - new EconomyCar().Price);
        Assert.Equal(1_200m, luxury.Price - new LuxuryCar().Price);
    }
}
