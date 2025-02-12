using System;
using System.Collections.Generic;

// Interface for tax handling
public interface ITaxable
{
    double CalculateTax();
    string GetTaxDetails();
}

// Abstract class Product
public abstract class Product
{
    public int ProductId { get; private set; }
    public string Name { get; private set; }
    public double Price { get; protected set; }

    public Product(int productId, string name, double price)
    {
        ProductId = productId;
        Name = name;
        Price = price;
    }

    public abstract double CalculateDiscount();

    public void DisplayFinalPrice()
    {
        double discount = CalculateDiscount();
        double tax = (this is ITaxable taxable) ? taxable.CalculateTax() : 0;
        double finalPrice = Price + tax - discount;
        Console.WriteLine("Product: {0}, Final Price: {1}", Name, finalPrice);
    }
}

// Electronics class
public class Electronics : Product, ITaxable
{
    public Electronics(int productId, string name, double price)
        : base(productId, name, price) { }

    public override double CalculateDiscount()
    {
        return Price * 0.1;
    }

    public double CalculateTax()
    {
        return Price * 0.15;
    }

    public string GetTaxDetails()
    {
        return "Tax Rate: 15%";
    }
}

// Clothing class
public class Clothing : Product, ITaxable
{
    public Clothing(int productId, string name, double price)
        : base(productId, name, price) { }

    public override double CalculateDiscount()
    {
        return Price * 0.2;
    }

    public double CalculateTax()
    {
        return Price * 0.05;
    }

    public string GetTaxDetails()
    {
        return "Tax Rate: 5%";
    }
}

// Groceries class
public class Groceries : Product
{
    public Groceries(int productId, string name, double price)
        : base(productId, name, price) { }

    public override double CalculateDiscount()
    {
        return Price * 0.05;
    }
}

// Main program
public class Program
{
    public static void Main()
    {
        List<Product> products = new List<Product>();
        products.Add(new Electronics(1, "Laptop", 1000));
        products.Add(new Clothing(2, "T-Shirt", 50));
        products.Add(new Groceries(3, "Apple", 5));

        foreach (Product product in products)
        {
            product.DisplayFinalPrice();
        }
    }
}
