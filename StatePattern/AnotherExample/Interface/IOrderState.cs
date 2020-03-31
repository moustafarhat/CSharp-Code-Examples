namespace StatePattern.AnotherExample.Interface
{
    public interface IOrderState
    {
        bool CanShip(Order order);

        void Ship(Order order);

        bool CanCancel(Order order);

        void Cancel(Order order);

        OrderStatus Status { get; }
    }
}