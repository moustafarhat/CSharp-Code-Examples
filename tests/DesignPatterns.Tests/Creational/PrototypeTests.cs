using DesignPatterns.Creational.Prototype;

namespace DesignPatterns.Tests.Creational;

public class PrototypeTests
{
    private static CustomerTemplates CreateTemplates()
    {
        var templates = new CustomerTemplates();
        templates.Register(new Customer { Type = "Lead", CreditLimit = 0m, Tags = ["prospect"] });
        templates.Register(new Customer { Type = "Premium", CreditLimit = 10_000m, Tags = ["vip"] });
        return templates;
    }

    [Fact]
    public void Create_returns_a_copy_of_the_registered_template()
    {
        var customer = CreateTemplates().Create("premium");

        Assert.Equal("Premium", customer.Type);
        Assert.Equal(10_000m, customer.CreditLimit);
        Assert.Equal(["vip"], customer.Tags);
    }

    [Fact]
    public void Clones_are_deep_copies_so_templates_are_never_modified()
    {
        var templates = CreateTemplates();

        var first = templates.Create("Lead");
        first.Name = "Ada";
        first.Tags.Add("contacted");
        var second = templates.Create("Lead");

        Assert.NotSame(first, second);
        Assert.Equal(string.Empty, second.Name);
        Assert.Equal(["prospect"], second.Tags);
    }

    [Fact]
    public void Create_throws_for_an_unknown_type()
    {
        Assert.Throws<KeyNotFoundException>(() => CreateTemplates().Create("Partner"));
    }
}
