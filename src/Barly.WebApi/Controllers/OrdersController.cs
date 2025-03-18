using Microsoft.AspNetCore.Mvc;

namespace Barly.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class OrdersController(OrderService service) : ControllerBase
{
    private readonly OrderService _orderService = service;

    [HttpGet(Name = "GetOrders")]
    public IEnumerable<Order> Get()
    {
        return _orderService.GetOrders();
    }
}
