// Creating a class with the name Profit to calculate the profit and loss in number and percentage.
using System;
class Profit {
    public static void Main(string[] args) {
     
        // Create variables for cost price and selling price
        int costPrice = 129;
        int sellingPrice = 191;
     
        // Create variable for storing profit in number
        double profit = sellingPrice - costPrice;
        
        // Create variable for storing profit in percentage
        double profitPercentage = (profit/costPrice)*100;
        
        // Display profit in number and percentage
        Console.WriteLine("The Cost Price in INR "+costPrice+" and Selling Price is INR "+sellingPrice+" \nThe Profit is INR "+profit+" and the Profit Percentage is "+profitPercentage);
    }
}