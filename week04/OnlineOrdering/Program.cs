using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1: USA Customer
        Address address1 = new Address("123 Main St", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Wireless Mouse", "P101", 25.99, 2));
        order1.AddProduct(new Product("Mechanical Keyboard", "P102", 75.50, 1));
        order1.AddProduct(new Product("Desk Pad", "P103", 15.00, 1));

        // Order 2: International Customer
        Address address2 = new Address("456 Kampala Rd", "Kampala", "Central", "Uganda");
        Customer customer2 = new Customer("Senga Sacre", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("USB-C Hub", "P201", 45.00, 1));
        order2.AddProduct(new Product("Monitor Stand", "P202", 30.25, 2));

        // Display Details for Order 1
        Console.WriteLine("==================================================");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost():F2}");
        Console.WriteLine("==================================================\n");

        // Display Details for Order 2
        Console.WriteLine("==================================================");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost():F2}");
        Console.WriteLine("==================================================\n");
    }
}