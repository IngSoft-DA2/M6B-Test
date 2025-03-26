using Microsoft.AspNetCore.Mvc;

namespace Barly.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class OrdersController : ControllerBase
{
    private readonly IOrderService _orderService;

    public OrdersController(IOrderService orderService)
    {
        _orderService = orderService;
    }

    [HttpGet(Name = "GetOrders")]
    public IActionResult Get()
    {
        return Ok(_orderService.GetOrders());

    }
}
