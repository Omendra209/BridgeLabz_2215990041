using System;
using System.Collections.Generic;

// Class representing a Product
public class Product
{
    public string Name { get; set; }
    public double PricePerUnit { get; set; }
    public double Quantity { get; set; }

    public Product(string name, double pricePerUnit, double quantity)
    {
        Name = name;
        PricePerUnit = pricePerUnit;
        Quantity = quantity;
    }

    public double GetTotalPrice()
    {
        return PricePerUnit * Quantity;
    }
}

// Class representing a Customer
public class Customer
{
    public string Name { get; set; }
    private List<Product> products = new List<Product>();

    public Customer(string name)
    {
        Name = name;
    }

    public void AddProduct(string productName, double pricePerUnit, double quantity)
    {
        products.Add(new Product(productName, pricePerUnit, quantity));
    }

    public List<Product> GetProducts()
    {
        return products;
    }
}

// Class to generate bill
public class BillGenerator
{
    public static double CalculateTotal(Customer customer)
    {
        double total = 0;
        foreach (Product product in customer.GetProducts())
        {
            total += product.GetTotalPrice();
        }
        return total;
    }
}

// Main Program
public class Program
{
    public static void Main()
    {
        Console.Write("Enter Customer Name: ");
        string customerName = Console.ReadLine();
        Customer customer = new Customer(customerName);

        while (true)
        {
            Console.WriteLine("Enter Product Name (or type 'exit' to finish): ");
            string productName = Console.ReadLine();
            if (productName.ToLower() == "exit")
            {
                break;
            }

            Console.Write("Enter Price Per Unit: ");
            double pricePerUnit = double.Parse(Console.ReadLine());

            Console.Write("Enter Quantity: ");
            double quantity = double.Parse(Console.ReadLine());

            customer.AddProduct(productName, pricePerUnit, quantity);
        }

        double total = BillGenerator.CalculateTotal(customer);

        Console.WriteLine("Customer Name: {0}", customer.Name);
        Console.WriteLine("Products Purchased:");
        foreach (Product product in customer.GetProducts())
        {
            Console.WriteLine("{0} - {1} units at ${2} per unit: ${3}", product.Name, product.Quantity, product.PricePerUnit, product.GetTotalPrice());
        }
        Console.WriteLine("Total Bill: ${0}", total);
    }
}