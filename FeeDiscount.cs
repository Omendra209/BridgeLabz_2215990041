// Creating a class with the name FeeDiscount to find the discounted amount and discounted price the student will pay for the course.
using System;
class FeeDiscount {
    public static void Main(string[] args) {
     
        // Create a variable named fee and assign 125000 to it.
        int fee = 125000;
     
        // Create another variable discountPercent and assign 10 to it.
        int discountPercent = 10;
        
        // Compute discount and assign it to the discount variable.
        double discount = (fee*discountPercent)/100;
        
        // Compute and print the fee you have to pay by subtracting the discount from the fee.
        Console.WriteLine($"The discount amount is INR {discount} and final discounted fee is INR {fee-discount}");
    }
}