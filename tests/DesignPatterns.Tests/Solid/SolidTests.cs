using DesignPatterns.Solid.DependencyInversion.After;
using DesignPatterns.Solid.InterfaceSegregation.After;
using DesignPatterns.Solid.OpenClosed.After;
using DesignPatterns.Solid.SingleResponsibility.After;

using Microsoft.Extensions.DependencyInjection;

using LspAfter = DesignPatterns.Solid.LiskovSubstitution.After;
using LspBefore = DesignPatterns.Solid.LiskovSubstitution.Before;

namespace DesignPatterns.Tests.Solid;

public class SingleResponsibilityTests
{
    private static readonly InvoiceLine[] Lines = [new("Keyboard", 50m), new("Mouse", 25m)];

    [Fact]
    public void Calculator_can_be_tested_without_any_formatting()
    {
        var calculator = new InvoiceCalculator(taxRate: 0.19m);

        Assert.Equal(75m, InvoiceCalculator.Subtotal(Lines));
        Assert.Equal(89.25m, calculator.Total(Lines));
    }

    [Fact]
    public void Printer_only_deals_with_layout()
    {
        var printer = new InvoicePrinter(new InvoiceCalculator(taxRate: 0m));

        Assert.Equal("Keyboard: 50.00\nMouse: 25.00\nTotal: 75.00", printer.Print(Lines));
    }
}

public class OpenClosedTests
{
    public static TheoryData<IDiscountPolicy, decimal> Policies => new()
    {
        { new NoDiscount(), 200m },
        { new PercentageDiscount(10), 180m },
        { new FixedAmountDiscount(50), 150m },
        { new FixedAmountDiscount(500), 0m },
    };

    [Theory]
    [MemberData(nameof(Policies))]
    public void Checkout_works_with_any_policy_without_being_changed(IDiscountPolicy policy, decimal expected)
    {
        Assert.Equal(expected, new Checkout(policy).Total(200m));
    }
}

public class LiskovSubstitutionTests
{
    [Fact]
    public void Before_a_subtype_breaks_code_written_for_its_base_type()
    {
        LspBefore.Customer[] customers = [new LspBefore.GoldCustomer(), new LspBefore.Enquiry()];

        Assert.Throws<NotSupportedException>(() => LspBefore.CustomerRepository.SaveAll(customers));
    }

    [Fact]
    public void After_every_persistable_can_be_saved()
    {
        LspAfter.IPersistable[] items = [new LspAfter.Customer(), new LspAfter.GoldCustomer()];

        Assert.Equal(["Customer saved", "GoldCustomer saved"], LspAfter.CustomerRepository.SaveAll(items));
    }

    [Fact]
    public void After_an_enquiry_still_gets_a_discount()
    {
        LspAfter.IDiscountable[] discountables = [new LspAfter.GoldCustomer(), new LspAfter.Enquiry()];

        Assert.Equal([10m, 5m], discountables.Select(d => d.Discount(100m)));
    }
}

public class InterfaceSegregationTests
{
    [Fact]
    public void A_basic_printer_is_not_forced_to_pretend_it_can_scan()
    {
        var printer = new BasicPrinter();

        Assert.Equal("Printed report", printer.Print("report"));
        Assert.IsNotAssignableFrom<IScanner>(printer);
    }

    [Fact]
    public void A_device_can_implement_several_small_interfaces()
    {
        var machine = new OfficeMachine();

        Assert.Equal("Scanned report", ((IScanner)machine).Scan("report"));
        Assert.Equal("Faxed report", ((IFax)machine).Fax("report"));
    }
}

public class DependencyInversionTests
{
    [Fact]
    public void Service_can_be_tested_with_a_fake_logger()
    {
        var logger = new InMemoryLogger();
        var service = new CustomerService(logger);

        Assert.False(service.Register(" "));
        Assert.True(service.Register("Ada"));
        Assert.Equal(["Rejected a customer with no name.", "Registered Ada."], logger.Messages);
    }

    [Fact]
    public void A_di_container_wires_the_abstraction_to_an_implementation()
    {
        using var provider = new ServiceCollection()
            .AddSingleton<InMemoryLogger>()
            .AddSingleton<DesignPatterns.Solid.DependencyInversion.After.ILogger>(sp => sp.GetRequiredService<InMemoryLogger>())
            .AddTransient<CustomerService>()
            .BuildServiceProvider();

        provider.GetRequiredService<CustomerService>().Register("Grace");

        Assert.Equal(["Registered Grace."], provider.GetRequiredService<InMemoryLogger>().Messages);
    }
}
