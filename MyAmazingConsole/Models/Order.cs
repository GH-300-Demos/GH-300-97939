namespace MyAmazingConsole.Models;

/// <summary>
/// Represents an order with customer information and products
/// </summary>
public class Order
{
    private readonly List<Product> _products = new();
    private OrderStatus _status;

    public string OrderId { get; }
    public CustomerInfo Customer { get; }
    public IReadOnlyList<Product> Products => _products.AsReadOnly();
    public OrderStatus Status
    {
        get => _status;
        set => _status = value;
    }

    /// <summary>
    /// Calculated as the sum of all product total costs
    /// </summary>
    public decimal TotalCost => _products.Sum(p => p.TotalCost);

    public Order(string orderId, CustomerInfo customer)
    {
        OrderId = orderId ?? throw new ArgumentNullException(nameof(orderId));
        Customer = customer ?? throw new ArgumentNullException(nameof(customer));
        _status = OrderStatus.Created;
    }

    /// <summary>
    /// Adds a product to the order
    /// </summary>
    public void AddProduct(Product product)
    {
        if (product == null)
            throw new ArgumentNullException(nameof(product));

        _products.Add(product);
    }

    /// <summary>
    /// Removes a product from the order by code
    /// </summary>
    public bool RemoveProduct(string productCode)
    {
        var product = _products.FirstOrDefault(p => p.Code == productCode);
        if (product != null)
        {
            _products.Remove(product);
            return true;
        }
        return false;
    }

    /// <summary>
    /// Clears all products from the order
    /// </summary>
    public void ClearProducts()
    {
        _products.Clear();
    }

    public override string ToString()
    {
        var productsInfo = string.Join(", ", _products.Select(p => $"{p.Description} (x{p.Quantity})"));
        return $"Order {OrderId} - Customer: {Customer} - Products: {productsInfo} - Total: ${TotalCost:F2} - Status: {Status}";
    }
}
