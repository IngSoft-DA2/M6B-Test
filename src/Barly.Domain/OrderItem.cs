namespace Barly.Domain;

public class OrderItem(Guid drinkId, int quantity, double price)
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public Guid DrinkId { get; private set; } = drinkId;
    public int Quantity { get; private set; } = quantity;
    public double Price { get; private set; } = price;
    public double TotalPrice => Price * Quantity;
}
