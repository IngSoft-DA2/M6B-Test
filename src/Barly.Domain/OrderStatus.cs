namespace Barly.Domain;

public enum OrderStatus
{
    /// <summary>
    /// Pending status of an order
    /// </summary>
    Pending,

    /// <summary>
    /// In Progress status of an order
    /// </summary>
    InProgress,

    /// <summary>
    /// The order was served
    /// </summary>
    Served,

    /// <summary>
    /// The order was paid by the customer
    /// </summary>
    Paid
}
