namespace DesignPatterns.Structural.Decorator;

public interface ICar
{
    string Description { get; }

    decimal Price { get; }
}

public sealed class EconomyCar : ICar
{
    public string Description => "Economy car";

    public decimal Price => 18_000m;
}

public sealed class LuxuryCar : ICar
{
    public string Description => "Luxury car";

    public decimal Price => 55_000m;
}

/// <summary>
/// Wraps any <see cref="ICar"/> and adds to it, so packages can be stacked in any order
/// without a subclass for every combination.
/// </summary>
public abstract class CarDecorator(ICar car) : ICar
{
    public virtual string Description => car.Description;

    public virtual decimal Price => car.Price;
}

public sealed class SportsPackage(ICar car) : CarDecorator(car)
{
    public override string Description => $"{base.Description}, sports package";

    public override decimal Price => base.Price + 3_500m;
}

public sealed class WinterPackage(ICar car) : CarDecorator(car)
{
    public override string Description => $"{base.Description}, winter package";

    public override decimal Price => base.Price + 1_200m;
}

public sealed class NavigationPackage(ICar car) : CarDecorator(car)
{
    public override string Description => $"{base.Description}, navigation";

    public override decimal Price => base.Price + 800m;
}
