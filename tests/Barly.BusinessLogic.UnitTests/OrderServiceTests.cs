using Barly.Domain;

namespace Barly.BusinessLogic.UnitTests;

[TestClass]
public class OrderServiceTests
{
    private OrderService? _ordersService;

    [TestInitialize]
    public void Setup()
    {
        _ordersService = new OrderService();
    }

    [TestMethod]
    public void GetOrders_ReturnsAllOrders()
    {
        // Arrange

        // Act
        List<Order> result = _ordersService!.GetOrders();

        // Assert
        Assert.IsNotNull(result);
        Assert.AreEqual(1, result.Count);
    }
}
