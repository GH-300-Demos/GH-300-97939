namespace MyAmazingConsole.Models;

public class OrderItem
{
    public int Id { get; set; }
    public string Description { get; set; }
    public string Code { get; set; }
    public int Qty { get; set; }
    public decimal UnitCost { get; set; }
    public decimal TotalCost
    {
        get { return Qty * UnitCost; }
    }

    public OrderItem(int id, string description, string code, int qty, decimal unitCost)
    {
        Id = id;
        Description = description;
        Code = code;
        Qty = qty;
        UnitCost = unitCost;
    }
}
