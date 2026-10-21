using DesignPatterns.Creational.Builder;

namespace DesignPatterns.Tests.Creational;

public class BuilderTests
{
    [Fact]
    public void Builder_applies_every_step_and_keeps_defaults_for_the_rest()
    {
        var vehicle = new VehicleBuilder()
            .WithModel("Roadster")
            .WithDoors(2)
            .AddAccessory("Soft top")
            .Build();

        Assert.Equal("Roadster", vehicle.Model);
        Assert.Equal(2, vehicle.Doors);
        Assert.Equal("Manual", vehicle.Transmission);
        Assert.Equal(["Soft top"], vehicle.Accessories);
    }

    [Fact]
    public void Build_rejects_a_vehicle_without_a_model()
    {
        var builder = new VehicleBuilder().WithDoors(4);

        Assert.Throws<InvalidOperationException>(builder.Build);
    }

    [Fact]
    public void Build_rejects_a_vehicle_without_doors()
    {
        var builder = new VehicleBuilder().WithModel("Box").WithDoors(0);

        Assert.Throws<InvalidOperationException>(builder.Build);
    }

    [Fact]
    public void Built_vehicles_do_not_change_when_the_builder_is_reused()
    {
        var builder = new VehicleBuilder().WithModel("Base").AddAccessory("Mats");
        var first = builder.Build();

        builder.AddAccessory("Spoiler");

        Assert.Equal(["Mats"], first.Accessories);
    }

    [Fact]
    public void Director_produces_known_configurations()
    {
        var explorer = VehicleDirector.BuildFordExplorer();
        var hatchback = VehicleDirector.BuildCityHatchback();

        Assert.Equal("SUV", explorer.Body);
        Assert.Equal(5, explorer.Doors);
        Assert.Equal(3, hatchback.Doors);
        Assert.Empty(hatchback.Accessories);
    }
}
