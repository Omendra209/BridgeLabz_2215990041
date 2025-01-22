// Program to calculate discounted fee based on user input.
using System;
class FeeDiscountCalculator {
    public static void Main(string[] args) {
     
        // Prompt user for the fee
		Console.Write("Enter the student fee (INR): ");
        int fee = Convert.ToInt32(Console.ReadLine());
     
        // Prompt user for the discount percentage
		Console.Write("Enter the university discount percentage: ");
        int discountPercent = Convert.ToInt32(Console.ReadLine());
        
        // Compute discount and assign it to the discount variable.
        double discount = (fee*discountPercent)/100;
        
        // Clear the console after taking input
        Console.Clear();
        
        // Compute and print the fee you have to pay by subtracting the discount from the fee.
        Console.WriteLine($"The discount amount is INR {discount} and final discounted fee is INR {fee-discount}");
    }
}