namespace Barly.Domain.UnitTests;

[TestClass]
public class OrderTests
{
    [TestMethod]
    public void AddItem_ShouldIncreaseTotalAmount()
    {
        // Arrange
        var order = new Order(null);
        var item = new OrderItem(Guid.NewGuid(), 2, 5.0);

        // Act
        order.AddItem(item);

        // Assert
        Assert.AreEqual(10.0, order.TotalAmount);
        Assert.AreEqual(1, order.Items.Count);
    }

    [TestMethod]
    public void MarkAsPaid_ShouldChangeStatusToPaid()
    {
        // Arrange
        var order = new Order(null);

        // Act
        order.MarkAsPaid();

        // Assert
        Assert.AreEqual(OrderStatus.Paid, order.Status);
    }

    [TestMethod]
    public void Constructor_ShouldInitializeProperties()
    {
        // Arrange
        var customerId = Guid.NewGuid();

        // Act
        var order = new Order(customerId);

        // Assert
        Assert.AreEqual(customerId, order.CustomerId);
        Assert.AreEqual(OrderStatus.Pending, order.Status);
        Assert.AreEqual(0, order.TotalAmount);
        Assert.AreEqual(0, order.Items.Count);
        Assert.IsNotNull(order.CreatedAt);
    }
}
