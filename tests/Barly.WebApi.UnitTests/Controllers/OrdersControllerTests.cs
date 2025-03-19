using Barly.BusinessLogic.Interfaces;
using Barly.Domain;
using Barly.WebApi.Controllers;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace Barly.WebApi.UnitTests.Controllers;

[TestClass]
public class OrdersControllerTests
{
    private Mock<IOrderService>? _orderServiceMock;
    private OrdersController? _ordersController;

    [TestInitialize]
    public void Setup()
    {
        _orderServiceMock = new Mock<IOrderService>();
        _ordersController = new OrdersController(_orderServiceMock.Object);
    }

    [TestMethod]
    public void GetOrders_ReturnsOkResult_WithOrder()
    {
        // Arrange
        Order order = new(null);
        _orderServiceMock!.Setup(service => service.GetOrders()).Returns([order]);

        // Act
        OkObjectResult response = (_ordersController!.Get() as OkObjectResult)!;

        // Assert
        Assert.IsNotNull(response.Value);

        var result = (List<Order>)response.Value;
        Assert.AreEqual(order, result.First());
    }

    [TestMethod]
    public void GetOrders_ReturnsNotFoundResult_WhenOrderDoesNotExist()
    {
        // Arrange
        _orderServiceMock!.Setup(service => service.GetOrders()).Returns([]);

        // Act
        OkObjectResult response = (_ordersController!.Get() as OkObjectResult)!;

        // Assert
        Assert.IsNotNull(response.Value);

        var result = (List<Order>)response.Value;
        Assert.AreEqual(0, result.Count);
    }
}
