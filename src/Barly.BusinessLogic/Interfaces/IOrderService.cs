using System;
using System.Collections.Generic;

namespace Barly.BusinessLogic.Interfaces;

public interface IOrderService
{
    public List<Order> GetOrders();
}
