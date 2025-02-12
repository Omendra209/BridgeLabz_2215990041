using System;

// Abstract class defining a food item
abstract class FoodItem
{
    protected string itemName;
    protected double price;
    protected int quantity;

    public FoodItem(string name, double price, int quantity)
    {
        this.itemName = name;
        this.price = price;
        this.quantity = quantity;
    }

    public abstract double CalculateTotalPrice();

    public void GetItemDetails()
    {
        Console.WriteLine("Item: " + itemName + ", Price: " + price + ", Quantity: " + quantity);
    }
}

// Interface for discountable items
interface IDiscountable
{
    double ApplyDiscount(double discountPercentage);
    void GetDiscountDetails();
}

// VegItem class
class VegItem : FoodItem, IDiscountable
{
    private const double VegCharge = 5.0;

    public VegItem(string name, double price, int quantity) : base(name, price, quantity) { }

    public override double CalculateTotalPrice()
    {
        return (price * quantity) + VegCharge;
    }

    public double ApplyDiscount(double discountPercentage)
    {
        return CalculateTotalPrice() * (1 - discountPercentage / 100);
    }

    public void GetDiscountDetails()
    {
        Console.WriteLine("Veg item has a discount policy available.");
    }
}

// NonVegItem class
class NonVegItem : FoodItem, IDiscountable
{
    private const double NonVegCharge = 10.0;

    public NonVegItem(string name, double price, int quantity) : base(name, price, quantity) { }

    public override double CalculateTotalPrice()
    {
        return (price * quantity) + NonVegCharge;
    }

    public double ApplyDiscount(double discountPercentage)
    {
        return CalculateTotalPrice() * (1 - discountPercentage / 100);
    }

    public void GetDiscountDetails()
    {
        Console.WriteLine("Non-Veg item has a discount policy available.");
    }
}

class Program
{
    static void Main()
    {
        FoodItem vegBurger = new VegItem("Veg Burger", 50, 2);
        FoodItem chickenWings = new NonVegItem("Chicken Wings", 100, 3);

        vegBurger.GetItemDetails();
        Console.WriteLine("Total Price: " + vegBurger.CalculateTotalPrice());

        chickenWings.GetItemDetails();
        Console.WriteLine("Total Price: " + chickenWings.CalculateTotalPrice());
    }
}