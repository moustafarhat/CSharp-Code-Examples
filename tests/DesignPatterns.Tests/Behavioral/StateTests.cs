using DesignPatterns.Behavioral.State;

namespace DesignPatterns.Tests.Behavioral;

public class StateTests
{
    [Fact]
    public void A_new_order_can_be_shipped_or_cancelled()
    {
        var order = new Order();

        Assert.Equal(OrderStatus.New, order.Status);
        Assert.True(order.CanShip);
        Assert.True(order.CanCancel);
    }

    [Fact]
    public void Order_moves_through_the_happy_path()
    {
        var order = new Order();

        order.Ship();
        Assert.Equal(OrderStatus.Shipped, order.Status);

        order.Deliver();
        Assert.Equal(OrderStatus.Delivered, order.Status);
    }

    [Fact]
    public void A_shipped_order_can_no_longer_be_cancelled()
    {
        var order = new Order();
        order.Ship();

        Assert.False(order.CanCancel);
        var error = Assert.Throws<InvalidOperationException>(order.Cancel);
        Assert.Equal("Cannot cancel an order that is SHIPPED.", error.Message);
        Assert.Equal(OrderStatus.Shipped, order.Status);
    }

    [Fact]
    public void A_cancelled_order_is_final()
    {
        var order = new Order();
        order.Cancel();

        Assert.Equal(OrderStatus.Cancelled, order.Status);
        Assert.Throws<InvalidOperationException>(order.Ship);
        Assert.Throws<InvalidOperationException>(order.Deliver);
        Assert.Throws<InvalidOperationException>(order.Cancel);
    }

    [Fact]
    public void A_new_order_cannot_be_delivered_before_it_ships()
    {
        Assert.Throws<InvalidOperationException>(new Order().Deliver);
    }
}
