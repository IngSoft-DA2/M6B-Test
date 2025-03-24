namespace Barly.Domain;

public class Order(Guid? customerId)
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public Guid? CustomerId { get; private set; } = customerId;
    public List<OrderItem> Items { get; private set; } = [];
    public double TotalAmount { get; private set; }
    public OrderStatus Status { get; private set; } = OrderStatus.Pending;
    public DateTime CreatedAt { get; private set; } = DateTime.UtcNow;
    public DateTime? ClosedAt { get; private set; }

    public void AddItem(OrderItem item)
    {
        Items.Add(item);
        CalculateTotal();
    }

    private void CalculateTotal()
    {
        TotalAmount = Items.Sum(i => i.TotalPrice);
    }

    public void MarkAsPaid() => Status = OrderStatus.Paid;
}
