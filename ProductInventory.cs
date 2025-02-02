using System;

public class Product
{
    // Instance variables
    private string productName;
    private double price;

    // Class variable (shared among all instances)
    private static int totalProducts = 0;

    // Constructor
    public Product(string productName, double price)
    {
        this.productName = productName;
        this.price = price;
        totalProducts++; // Increment total products when a new product is created
    }

    // Instance method to display product details
    public void DisplayProductDetails()
    {
        Console.WriteLine($"Product Name: {productName}");
        Console.WriteLine($"Price: {price:C}");
    }

    // Class method to display total number of products
    public static void DisplayTotalProducts()
    {
        Console.WriteLine($"Total Products: {totalProducts}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create some products
        Product product1 = new Product("Laptop", 1200.50);
        Product product2 = new Product("Smartphone", 800.75);
        Product product3 = new Product("Tablet", 450.00);

        // Display details of each product
        Console.WriteLine("Product Details:");
        product1.DisplayProductDetails();
        product2.DisplayProductDetails();
        product3.DisplayProductDetails();

        // Display total number of products
        Product.DisplayTotalProducts();
    }
}
