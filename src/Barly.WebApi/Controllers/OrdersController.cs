using Microsoft.AspNetCore.Mvc;

namespace Barly.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class OrdersController(IOrderService orderService) : ControllerBase
{
    [HttpGet(Name = "GetOrders")]
    public IEnumerable<Order> Get()
    {
        return orderService.GetOrders();
    }
}
