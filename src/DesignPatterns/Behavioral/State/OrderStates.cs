namespace DesignPatterns.Behavioral.State;

internal interface IOrderState
{
    OrderStatus Status { get; }

    bool CanShip => false;

    bool CanCancel => false;

    IOrderState Ship() => throw NotAllowed("ship");

    IOrderState Deliver() => throw NotAllowed("deliver");

    IOrderState Cancel() => throw NotAllowed("cancel");

    private InvalidOperationException NotAllowed(string action) =>
        new($"Cannot {action} an order that is {Status.ToString().ToUpperInvariant()}.");
}

// States hold no data, so a single shared instance of each is enough.
internal sealed class NewState : IOrderState
{
    public static readonly NewState Instance = new();

    public OrderStatus Status => OrderStatus.New;

    public bool CanShip => true;

    public bool CanCancel => true;

    public IOrderState Ship() => ShippedState.Instance;

    public IOrderState Cancel() => CancelledState.Instance;
}

internal sealed class ShippedState : IOrderState
{
    public static readonly ShippedState Instance = new();

    public OrderStatus Status => OrderStatus.Shipped;

    public IOrderState Deliver() => DeliveredState.Instance;
}

internal sealed class DeliveredState : IOrderState
{
    public static readonly DeliveredState Instance = new();

    public OrderStatus Status => OrderStatus.Delivered;
}

internal sealed class CancelledState : IOrderState
{
    public static readonly CancelledState Instance = new();

    public OrderStatus Status => OrderStatus.Cancelled;
}
