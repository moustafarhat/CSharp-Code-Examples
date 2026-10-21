namespace DesignPatterns.Creational.Builder;

/// <summary>
/// Builds an immutable <see cref="Vehicle"/> step by step and validates it once at the end.
/// </summary>
public sealed class VehicleBuilder
{
    private readonly List<string> _accessories = [];
    private string? _model;
    private string _engine = "Unknown";
    private string _transmission = "Manual";
    private string _body = "Sedan";
    private int _doors = 4;

    public VehicleBuilder WithModel(string model)
    {
        _model = model;
        return this;
    }

    public VehicleBuilder WithEngine(string engine)
    {
        _engine = engine;
        return this;
    }

    public VehicleBuilder WithTransmission(string transmission)
    {
        _transmission = transmission;
        return this;
    }

    public VehicleBuilder WithBody(string body)
    {
        _body = body;
        return this;
    }

    public VehicleBuilder WithDoors(int doors)
    {
        _doors = doors;
        return this;
    }

    public VehicleBuilder AddAccessory(string accessory)
    {
        _accessories.Add(accessory);
        return this;
    }

    public Vehicle Build()
    {
        if (string.IsNullOrWhiteSpace(_model))
        {
            throw new InvalidOperationException("A vehicle needs a model.");
        }

        if (_doors <= 0)
        {
            throw new InvalidOperationException("A vehicle needs at least one door.");
        }

        return new Vehicle(_model, _engine, _transmission, _body, _doors, [.. _accessories]);
    }
}
