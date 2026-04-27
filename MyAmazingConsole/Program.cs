using MyAmazingConsole.Models;
using MyAmazingConsole.Repositories;

Console.WriteLine("Welcome to My Amazing E-Commerce Order Management System!");
Console.WriteLine();

// Create an in-memory repository
IOrderRepository orderRepository = new InMemoryOrderRepository();

// Create customer information
var customer1 = new CustomerInfo("John", "Doe", "123 Main St, Springfield, IL 62701");
var customer2 = new CustomerInfo("Jane", "Smith", "456 Oak Ave, Shelbyville, IL 62702");

// Create orders
var order1 = new Order("ORD-001", customer1);
order1.AddProduct(new Product("PROD-001", "Laptop", 1, 999.99m));
order1.AddProduct(new Product("PROD-002", "Mouse", 2, 25.50m));
order1.Status = OrderStatus.Completed;

var order2 = new Order("ORD-002", customer2);
order2.AddProduct(new Product("PROD-003", "Monitor", 1, 349.99m));
order2.AddProduct(new Product("PROD-004", "Keyboard", 1, 79.99m));
order2.Status = OrderStatus.Shipped;

var order3 = new Order("ORD-003", customer1);
order3.AddProduct(new Product("PROD-005", "USB Cable", 5, 5.99m));

// Add orders to repository
orderRepository.AddOrder(order1);
orderRepository.AddOrder(order2);
orderRepository.AddOrder(order3);

// Display all orders
Console.WriteLine("=== All Orders ===");
foreach (var order in orderRepository.GetAllOrders())
{
    Console.WriteLine(order);
}

Console.WriteLine();

// Display orders by status
Console.WriteLine("=== Completed Orders ===");
foreach (var order in orderRepository.GetOrdersByStatus(OrderStatus.Completed))
{
    Console.WriteLine(order);
}

Console.WriteLine();

// Display order count
Console.WriteLine($"Total Orders: {orderRepository.GetOrderCount()}");
Console.WriteLine();

// Retrieve a specific order
var retrievedOrder = orderRepository.GetOrder("ORD-001");
Console.WriteLine($"Retrieved Order: {retrievedOrder}");
Console.WriteLine($"Order Total Cost: ${retrievedOrder.TotalCost:F2}");