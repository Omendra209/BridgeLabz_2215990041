// Program to calculate the total price based on unit price and quantity
using System;

class TotalPriceCalculator {
    public static void Main(string[] args) {
        // Prompt user for the unit price of the item
        Console.Write("Enter the unit price of the item (INR): ");
        double unitPrice = Convert.ToDouble(Console.ReadLine());

        // Prompt user for the quantity of the item
        Console.Write("Enter the quantity to be bought: ");
        int quantity = Convert.ToInt32(Console.ReadLine());

        // Calculate the total price
        double totalPrice = unitPrice * quantity;

        // Output the result using the requested format
        Console.WriteLine("The total purchase price is INR " + totalPrice + " if the quantity is " + quantity + " and unit price is INR " + unitPrice);
    }
}
