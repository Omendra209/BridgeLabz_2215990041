using System;
using System.Collections.Generic;

// Abstract base class for all product categories
public abstract class ProductCategory
{
    public string CategoryName { get; private set; }

    protected ProductCategory(string categoryName)
    {
        CategoryName = categoryName;
    }
}

// Specific product categories
public class BookCategory : ProductCategory
{
    public BookCategory() : base("Books") { }
}

public class ClothingCategory : ProductCategory
{
    public ClothingCategory() : base("Clothing") { }
}

// Generic Product class restricted to ProductCategory types
public class Product<T> where T : ProductCategory
{
    public string Name { get; private set; }
    public double Price { get; private set; }
    public T Category { get; private set; }

    public Product(string name, double price, T category)
    {
        Name = name;
        Price = price;
        Category = category;
    }

    public void ApplyDiscount(double percentage)
    {
        if (percentage > 0 && percentage <= 100)
        {
            Price -= Price * (percentage / 100);
        }
    }

    public override string ToString()
    {
        return Name + " (" + Category.CategoryName + ") - " + Price.ToString("F2");
    }
}

// Generic catalog to store products
public class ProductCatalog<T> where T : ProductCategory
{
    private readonly List<Product<T>> products = new List<Product<T>>();

    public void AddProduct(Product<T> product)
    {
        if (product != null)
        {
            products.Add(product);
        }
    }

    public void DisplayProducts()
    {
        if (products.Count == 0)
        {
            Console.WriteLine("No products available.");
            return;
        }

        foreach (var product in products)
        {
            Console.WriteLine(product);
        }
    }
}

// Testing the implementation
class Program
{
    static void Main()
    {
        ProductCatalog<BookCategory> bookCatalog = new ProductCatalog<BookCategory>();
        ProductCatalog<ClothingCategory> clothingCatalog = new ProductCatalog<ClothingCategory>();

        var book1 = new Product<BookCategory>("C# Programming", 45.99, new BookCategory());
        var book2 = new Product<BookCategory>("Data Structures", 39.99, new BookCategory());
        var clothing1 = new Product<ClothingCategory>("T-Shirt", 19.99, new ClothingCategory());
        var clothing2 = new Product<ClothingCategory>("Jeans", 49.99, new ClothingCategory());

        bookCatalog.AddProduct(book1);
        bookCatalog.AddProduct(book2);
        clothingCatalog.AddProduct(clothing1);
        clothingCatalog.AddProduct(clothing2);

        book1.ApplyDiscount(10);
        clothing1.ApplyDiscount(15);

        Console.WriteLine("Book Catalog:");
        bookCatalog.DisplayProducts();

        Console.WriteLine("\nClothing Catalog:");
        clothingCatalog.DisplayProducts();
    }
}
