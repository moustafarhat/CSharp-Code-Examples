using DesignPatterns.Creational.AbstractFactory;

namespace DesignPatterns.Tests.Creational;

public class AbstractFactoryTests
{
    [Fact]
    public void Nokia_factory_only_produces_nokia_phones()
    {
        var catalogue = new PhoneShop(new NokiaFactory()).Catalogue();

        Assert.All(catalogue, model => Assert.StartsWith("Nokia", model, StringComparison.Ordinal));
    }

    [Fact]
    public void Samsung_factory_only_produces_samsung_phones()
    {
        var catalogue = new PhoneShop(new SamsungFactory()).Catalogue();

        Assert.All(catalogue, model => Assert.StartsWith("Samsung", model, StringComparison.Ordinal));
    }

    [Fact]
    public void Products_are_exposed_only_through_their_interfaces()
    {
        ISmartPhone phone = new SamsungFactory().CreateSmartPhone();

        Assert.Equal(8, phone.RamInGigabytes);
        Assert.False(phone.GetType().IsPublic);
    }
}
