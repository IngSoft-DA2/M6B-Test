using Barly.Domain;

namespace Barly.BusinessLogic;

public class OrderService
{
    public List<Order> GetOrders()
    {
        Order order = new(null);
        return [order];
    }
}
