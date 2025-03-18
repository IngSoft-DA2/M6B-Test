using Barly.BusinessLogic.Interfaces;

namespace Barly.BusinessLogic;

public class OrderService : IOrderService
{
    public List<Order> GetOrders()
    {
        Order order = new(null);
        return [order];
    }
}
