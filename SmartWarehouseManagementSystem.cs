using System;
using System.Collections.Generic;

// Abstract base class for all warehouse items
public abstract class WarehouseItem
{
    public string Name { get; private set; }
    public double Price { get; private set; }

    protected WarehouseItem(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public override string ToString()
    {
        return $"{Name} - ${Price}";
    }
}

// Electronics category
public class Electronics : WarehouseItem
{
    public Electronics(string name, double price) : base(name, price) { }
}

// Groceries category
public class Groceries : WarehouseItem
{
    public Groceries(string name, double price) : base(name, price) { }
}

// Furniture category
public class Furniture : WarehouseItem
{
    public Furniture(string name, double price) : base(name, price) { }
}

// Generic storage class with type constraint
public class Storage<T> where T : WarehouseItem
{
    private readonly List<T> items = new List<T>();

    // Method to add an item to storage
    public void AddItem(T item)
    {
        if (item != null)
        {
            items.Add(item);
        }
    }

    // Method to display all stored items
    public void DisplayItems()
    {
        if (items.Count == 0)
        {
            Console.WriteLine("No items in storage.");
            return;
        }

        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }
}

// Testing the implementation
class Program
{
    static void Main()
    {
        // Creating storage for different categories
        Storage<Electronics> electronicsStorage = new Storage<Electronics>();
        Storage<Groceries> groceriesStorage = new Storage<Groceries>();
        Storage<Furniture> furnitureStorage = new Storage<Furniture>();

        // Adding items
        electronicsStorage.AddItem(new Electronics("Laptop", 1200.50));
        electronicsStorage.AddItem(new Electronics("Smartphone", 800));

        groceriesStorage.AddItem(new Groceries("Apple", 2.5));
        groceriesStorage.AddItem(new Groceries("Milk", 1.2));

        furnitureStorage.AddItem(new Furniture("Chair", 75));
        furnitureStorage.AddItem(new Furniture("Table", 150));

        // Displaying items
        Console.WriteLine("Electronics Storage:");
        electronicsStorage.DisplayItems();

        Console.WriteLine("\nGroceries Storage:");
        groceriesStorage.DisplayItems();

        Console.WriteLine("\nFurniture Storage:");
        furnitureStorage.DisplayItems();
    }
}
