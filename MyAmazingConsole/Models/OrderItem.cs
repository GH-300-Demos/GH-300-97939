namespace MyAmazingConsole.Models;

/// <summary>
/// Represents a single line item within a customer order.
/// </summary>
public class OrderItem
{
    /// <summary>Gets or sets the unique identifier for the order item.</summary>
    public int Id { get; set; }

    /// <summary>Gets or sets the human-readable description of the item.</summary>
    public string Description { get; set; }

    /// <summary>Gets or sets the product code for the item.</summary>
    public string Code { get; set; }

    private int _qty;

    /// <summary>
    /// Gets or sets the quantity of the item ordered.
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException">
    /// Thrown when the value is set to zero or a negative number.
    /// </exception>
    public int Qty
    {
        get { return _qty; }
        set {
            if (value <= 0) {
                throw new ArgumentOutOfRangeException(nameof(value), "Quantity must be greater than zero.");
            }
            _qty = value;
        }
    }

    /// <summary>Gets or sets the cost per single unit of the item.</summary>
    public decimal UnitCost { get; set; }

    /// <summary>Gets the total cost for this line item, calculated as <see cref="Qty"/> multiplied by <see cref="UnitCost"/>.</summary>
    public decimal TotalCost
    {
        get { return Qty * UnitCost; }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="OrderItem"/> class.
    /// </summary>
    /// <param name="id">The unique identifier for the order item.</param>
    /// <param name="description">The human-readable description of the item.</param>
    /// <param name="code">The product code for the item.</param>
    /// <param name="qty">The quantity ordered. Must be greater than zero.</param>
    /// <param name="unitCost">The cost per single unit of the item.</param>
    public OrderItem(int id, string description, string code, int qty, decimal unitCost)
    {
        Id = id;
        Description = description;
        Code = code;
        Qty = qty;
        UnitCost = unitCost;
    }
}
