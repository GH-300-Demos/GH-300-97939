namespace MyAmazingConsole.Models;

/// <summary>
/// Represents the lifecycle status of a customer order.
/// </summary>
public enum OrderStatus
{
    /// <summary>The order has been created but not yet processed.</summary>
    Created,

    /// <summary>The order has been fulfilled and payment received.</summary>
    Completed,

    /// <summary>The order has been closed and is no longer active.</summary>
    Closed,

    /// <summary>The order has been dispatched and is on its way to the customer.</summary>
    Shipped
}
