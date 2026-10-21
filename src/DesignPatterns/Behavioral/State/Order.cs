namespace DesignPatterns.Behavioral.State;

public enum OrderStatus
{
    New,
    Shipped,
    Delivered,
    Cancelled,
}

/// <summary>
/// The order delegates every action to its current state, so there are no
/// <c>switch (Status)</c> blocks here. Each state decides what is allowed and what comes next.
/// </summary>
public sealed class Order
{
    private IOrderState _state = NewState.Instance;

    public OrderStatus Status => _state.Status;

    public bool CanShip => _state.CanShip;

    public bool CanCancel => _state.CanCancel;

    public void Ship() => _state = _state.Ship();

    public void Deliver() => _state = _state.Deliver();

    public void Cancel() => _state = _state.Cancel();
}
