using StatePattern.AnotherExample.Interface;
using System;

namespace StatePattern.AnotherExample
{
    public class Order
    {
        private IOrderState _orderState;

        public Order(IOrderState orderState)
        {
            _orderState = orderState;
        }

        public int Id { get; set; }
        public string Customer { get; set; }
        public DateTime OrderDate { get; set; }

        public OrderStatus Status => _orderState.Status;

        public bool CanCancel()
        {
            return _orderState.CanCancel(this);
        }

        public void Cancel()
        {
            if (CanCancel())
                _orderState.Cancel(this);
        }

        public bool CanShip()
        {
            return _orderState.CanShip(this);
        }

        public void Ship()
        {
            if (CanShip())
                _orderState.Ship(this);
        }

        public void Change(IOrderState orderState)
        {
            _orderState = orderState;
        }
    }
}