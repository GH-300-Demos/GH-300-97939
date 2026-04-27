namespace MyAmazingConsole.Models;

public class OrderItem
{
    public int Id { get; set; }
    public string Description { get; set; }
    public string Code { get; set; }
    private int _qty;
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
    public decimal UnitCost { get; set; }
    public decimal TotalCost
    {
        get { return Qty * UnitCost; }
    }

    public OrderItem(int id, string description, string code, int qty, decimal unitCost)
    {
        if (qty <= 0) {
            throw new ArgumentOutOfRangeException(nameof(qty), "Quantity must be greater than zero.");
        }
        Id = id;
        Description = description;
        Code = code;
        Qty = qty;
        UnitCost = unitCost;
    }
}
