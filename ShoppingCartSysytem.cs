using System;

class Product
{
    // Static variable shared by all instances of Product for Discount
    public static double Discount = 10.0; // Discount in percentage

    // Readonly variable for ProductID
    private readonly int productID;

    // Instance variables for product details
    private string productName;
    private double price;
    private int quantity;

    // Static method to update the discount for all products
    public static void UpdateDiscount(double newDiscount)
    {
        Discount = newDiscount;
        Console.WriteLine("Discount updated to: " + Discount + "%");
    }

    // Constructor to initialize the product details
    public Product(int productID, string productName, double price, int quantity)
    {
        this.productID = productID;   // Initialize product ID (readonly)
        this.productName = productName; // Initialize product name
        this.price = price;             // Initialize price
        this.quantity = quantity;       // Initialize quantity
    }

    // Method to display product details
    public void DisplayProductDetails()
    {
        Console.WriteLine("Product Name: " + productName);
        Console.WriteLine("Product ID: " + productID);
        Console.WriteLine("Price: $" + price);
        Console.WriteLine("Quantity: " + quantity);
        Console.WriteLine("Discount: " + Discount + "%");
        Console.WriteLine("Discounted Price: $" + (price - (price * Discount / 100)));
    }
}

public class ShoppingCartSystem
{
    public static void Main()
    {
        // Creating instances of Product
        Product product1 = new Product(101, "Laptop", 1000.0, 2);
        Product product2 = new Product(102, "Smartphone", 500.0, 3);

        // Display details of each product before updating discount
        Console.WriteLine("Before updating discount:\n");
        product1.DisplayProductDetails();
        product2.DisplayProductDetails();

        // Update the discount for all products
        Product.UpdateDiscount(15.0);

        // Display details of each product after updating discount
        Console.WriteLine("\nAfter updating discount:\n");
        product1.DisplayProductDetails();
        product2.DisplayProductDetails();

        // Using 'is' operator to check if the objects are instances of Product class
        if (product1 is Product)
        {
            Console.WriteLine("\nproduct1 is an instance of Product class.");
        }

        if (product2 is Product)
        {
            Console.WriteLine("product2 is an instance of Product class.");
        }
    }
}
