using MyAmazingConsole.Models;
using MyAmazingConsole.Repositories;

Console.WriteLine("Welcome to My Amazing E-Commerce Order Management System!");
Console.WriteLine();

var orderRepository = new OrderRepository();

// --- Create customers ---
var customer1 = new Customer(1, "Smith", "Alice", "123 Main St, Springfield");
var customer2 = new Customer(2, "Jones", "Bob", "456 Oak Ave, Shelbyville");

// --- Create orders ---
var order1 = new Order(1, customer1);
order1.Items.Add(new OrderItem(1, "Wireless Mouse", "WM-001", 2, 29.99m));
order1.Items.Add(new OrderItem(2, "USB-C Hub", "UCH-004", 1, 49.99m));

var order2 = new Order(2, customer2);
order2.Items.Add(new OrderItem(1, "Mechanical Keyboard", "MK-007", 1, 89.99m));
order2.Items.Add(new OrderItem(2, "Monitor Stand", "MS-012", 2, 34.99m));
order2.Items.Add(new OrderItem(3, "HDMI Cable", "HC-002", 3, 12.99m));

// --- Add orders to repository ---
orderRepository.Add(order1);
orderRepository.Add(order2);

// --- Display all orders ---
Console.WriteLine("=== All Orders ===");
foreach (var order in orderRepository.GetAll())
{
    Console.WriteLine($"Order #{order.Id} | Customer: {order.Customer.FirstName} {order.Customer.LastName} | Status: {order.Status} | Total: {order.TotalCost:C}");
    foreach (var item in order.Items)
    {
        Console.WriteLine($"  - [{item.Code}] {item.Description} | Qty: {item.Qty} | Unit: {item.UnitCost:C} | Total: {item.TotalCost:C}");
    }
    Console.WriteLine();
}

// --- Update order status ---
Console.WriteLine("=== Updating Order #1 status to Shipped ===");
order1.Status = OrderStatus.Shipped;
orderRepository.Update(order1);
var updatedOrder = orderRepository.GetById(1);
Console.WriteLine($"Order #1 new status: {updatedOrder?.Status}");
Console.WriteLine();

// --- Delete an order ---
Console.WriteLine("=== Deleting Order #2 ===");
orderRepository.Delete(2);
Console.WriteLine($"Remaining orders: {orderRepository.GetAll().Count()}");
Console.WriteLine();

// --- Try to get a non-existing order ---
Console.WriteLine("=== Looking up non-existing Order #99 ===");
var missingOrder = orderRepository.GetById(99);
Console.WriteLine(missingOrder == null ? "Order #99 not found." : $"Found order #{missingOrder.Id}");
