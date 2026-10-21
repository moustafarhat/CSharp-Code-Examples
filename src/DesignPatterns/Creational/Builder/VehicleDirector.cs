namespace DesignPatterns.Creational.Builder;

/// <summary>
/// Knows the build steps for well-known configurations, so callers don't repeat them.
/// </summary>
public static class VehicleDirector
{
    public static Vehicle BuildFordExplorer() =>
        new VehicleBuilder()
            .WithModel("Ford Explorer")
            .WithEngine("3.0 L EcoBoost V6")
            .WithTransmission("10-speed automatic")
            .WithBody("SUV")
            .WithDoors(5)
            .AddAccessory("Roof rails")
            .AddAccessory("Tow hitch")
            .Build();

    public static Vehicle BuildCityHatchback() =>
        new VehicleBuilder()
            .WithModel("City Hatchback")
            .WithEngine("1.0 L three-cylinder")
            .WithBody("Hatchback")
            .WithDoors(3)
            .Build();
}
