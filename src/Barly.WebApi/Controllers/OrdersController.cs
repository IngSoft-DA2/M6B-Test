using Microsoft.AspNetCore.Mvc;

namespace Barly.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class OrdersController(IOrderService orderService) : ControllerBase
{
    [HttpGet(Name = "GetOrders")]
    public IActionResult Get()
    {
        return NotFound(orderService.GetOrders());
    }
}
