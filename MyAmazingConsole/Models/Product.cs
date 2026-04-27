namespace MyAmazingConsole.Models;

/// <summary>
/// Represents a product in an order
/// </summary>
public class Product
{
    public string Code { get; set; }
    public string Description { get; set; }
    public int Quantity { get; set; }
    public decimal UnitCost { get; set; }

    /// <summary>
    /// Calculated as Quantity * UnitCost
    /// </summary>
    public decimal TotalCost => Quantity * UnitCost;

    public Product(string code, string description, int quantity, decimal unitCost)
    {
        Code = code ?? throw new ArgumentNullException(nameof(code));
        Description = description ?? throw new ArgumentNullException(nameof(description));
        Quantity = quantity > 0 ? quantity : throw new ArgumentException("Quantity must be greater than 0");
        UnitCost = unitCost >= 0 ? unitCost : throw new ArgumentException("Unit cost cannot be negative");
    }
}
