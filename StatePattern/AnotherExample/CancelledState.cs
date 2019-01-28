using System;
using System.Collections.Generic;
using System.Text;
using StatePattern.AnotherExample.Interface;

namespace StatePattern.AnotherExample
{
   public  class CancelledState : IOrderState
    {
        public bool CanShip(Order order)
        {
            return false;
        }

        public void Ship(Order order)
        {
            throw new NotImplementedException("Cannot ship, already cancelled.");
        }

        public bool CanCancel(Order order)
        {
            return false;
        }

        public void Cancel(Order order)
        {
            throw new NotImplementedException("Already cancelled.");
        }

        public OrderStatus Status => OrderStatus.Cancelled;
    }
}
