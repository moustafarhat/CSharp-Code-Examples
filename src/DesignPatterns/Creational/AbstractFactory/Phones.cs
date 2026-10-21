namespace DesignPatterns.Creational.AbstractFactory;

public interface ISmartPhone
{
    string Model { get; }

    int RamInGigabytes { get; }
}

public interface IFeaturePhone
{
    string Model { get; }
}

/// <summary>
/// Creates a family of related products. A client that receives one factory
/// can never mix a Nokia smartphone with a Samsung feature phone.
/// </summary>
public interface IPhoneFactory
{
    ISmartPhone CreateSmartPhone();

    IFeaturePhone CreateFeaturePhone();
}

public sealed class NokiaFactory : IPhoneFactory
{
    public ISmartPhone CreateSmartPhone() => new NokiaSmartPhone();

    public IFeaturePhone CreateFeaturePhone() => new NokiaFeaturePhone();

    private sealed record NokiaSmartPhone() : ISmartPhone
    {
        public string Model => "Nokia X30";

        public int RamInGigabytes => 6;
    }

    private sealed record NokiaFeaturePhone() : IFeaturePhone
    {
        public string Model => "Nokia 105";
    }
}

public sealed class SamsungFactory : IPhoneFactory
{
    public ISmartPhone CreateSmartPhone() => new SamsungSmartPhone();

    public IFeaturePhone CreateFeaturePhone() => new SamsungFeaturePhone();

    private sealed record SamsungSmartPhone() : ISmartPhone
    {
        public string Model => "Samsung Galaxy S24";

        public int RamInGigabytes => 8;
    }

    private sealed record SamsungFeaturePhone() : IFeaturePhone
    {
        public string Model => "Samsung Guru";
    }
}

/// <summary>
/// Depends only on the abstract factory and product interfaces.
/// </summary>
public sealed class PhoneShop(IPhoneFactory factory)
{
    public IReadOnlyList<string> Catalogue() =>
    [
        factory.CreateSmartPhone().Model,
        factory.CreateFeaturePhone().Model,
    ];
}
