namespace DesignPatterns.Creational.Builder;

public sealed record Vehicle(
    string Model,
    string Engine,
    string Transmission,
    string Body,
    int Doors,
    IReadOnlyList<string> Accessories);
