using System;
using System.Collections.Generic;

// Product class represents a product in the e-commerce platform
public class Product
{
    public string ProductName { get; set; }
    public double Price { get; set; }

    // Constructor to initialize product details
    public Product(string productName, double price)
    {
        ProductName = productName;
        Price = price;
    }

    // Method to display product details
    public void DisplayProduct()
    {
        Console.WriteLine("Product: " + ProductName + ", Price: $" + Price);
    }
}

// Order class represents an order placed by a customer, containing multiple products
public class Order
{
    public int OrderID { get; set; }
    public List<Product> Products { get; set; }
    public DateTime OrderDate { get; set; }

    // Constructor to initialize order details
    public Order(int orderID)
    {
        OrderID = orderID;
        Products = new List<Product>();
        OrderDate = DateTime.Now;
    }

    // Method to add a product to the order
    public void AddProduct(Product product)
    {
        Products.Add(product);
        Console.WriteLine("Product added to order ID " + OrderID);
    }

    // Method to display order details and the products in the order
    public void DisplayOrderDetails()
    {
        Console.WriteLine("Order ID: " + OrderID + ", Order Date: " + OrderDate);
        Console.WriteLine("Products in this order:");
        foreach (var product in Products)
        {
            product.DisplayProduct();
        }
    }

    // Method to calculate total order price
    public double CalculateTotal()
    {
        double total = 0;
        foreach (var product in Products)
        {
            total += product.Price;
        }
        return total;
    }
}

// Customer class represents a customer who places orders
public class Customer
{
    public string Name { get; set; }
    public int CustomerID { get; set; }
    private List<Order> orders;

    // Constructor to initialize customer details
    public Customer(string name, int customerID)
    {
        Name = name;
        CustomerID = customerID;
        orders = new List<Order>();
    }

    // Method to place an order
    public void PlaceOrder(Order order)
    {
        orders.Add(order);
        Console.WriteLine(Name + " placed an order with ID " + order.OrderID);
    }

    // Method to view all orders placed by the customer
    public void ViewOrders()
    {
        Console.WriteLine(Name + "'s Orders:");
        foreach (var order in orders)
        {
            order.DisplayOrderDetails();
        }
    }
}

// Main program to demonstrate the relationships and interactions
public class Program
{
    public static void Main()
    {
        // Creating products
        Product product1 = new Product("Laptop", 999.99);
        Product product2 = new Product("Smartphone", 499.99);
        Product product3 = new Product("Headphones", 79.99);

        // Creating a customer
        Customer customer = new Customer("John Doe", 1);

        // Creating an order for the customer
        Order order1 = new Order(1001);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        // Creating another order for the customer
        Order order2 = new Order(1002);
        order2.AddProduct(product3);

        // Customer placing orders
        customer.PlaceOrder(order1);
        customer.PlaceOrder(order2);

        // Displaying customer orders
        customer.ViewOrders();

        // Calculate total for order 1
        Console.WriteLine("\nTotal price for Order ID " + order1.OrderID + ": $" + order1.CalculateTotal());

        // Calculate total for order 2
        Console.WriteLine("Total price for Order ID " + order2.OrderID + ": $" + order2.CalculateTotal());

        // Adding switch-case for user interaction
        int choice = 0;
        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. View all orders");
            Console.WriteLine("2. View details of a specific order");
            Console.WriteLine("3. Calculate total price of an order");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    // Display all orders placed by the customer
                    customer.ViewOrders();
                    break;

                case 2:
                    // View details of a specific order
                    Console.Write("Enter Order ID to view details: ");
                    int orderID = int.Parse(Console.ReadLine());
                    Order orderToView = null;
                    foreach (var order in customer.orders)
                    {
                        if (order.OrderID == orderID)
                        {
                            orderToView = order;
                            break;
                        }
                    }
                    if (orderToView != null)
                    {
                        orderToView.DisplayOrderDetails();
                    }
                    else
                    {
                        Console.WriteLine("Order not found.");
                    }
                    break;

                case 3:
                    // Calculate total price of an order
                    Console.Write("Enter Order ID to calculate total price: ");
                    orderID = int.Parse(Console.ReadLine());
                    Order orderToCalculate = null;
                    foreach (var order in customer.orders)
                    {
                        if (order.OrderID == orderID)
                        {
                            orderToCalculate = order;
                            break;
                        }
                    }
                    if (orderToCalculate != null)
                    {
                        Console.WriteLine("Total price for Order ID " + orderID + ": $" + orderToCalculate.CalculateTotal());
                    }
                    else
                    {
                        Console.WriteLine("Order not found.");
                    }
                    break;

                case 0:
                    // Exit the program
                    Console.WriteLine("Exiting the program.");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}