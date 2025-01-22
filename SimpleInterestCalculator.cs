// Program to calculate Simple Interest
using System;

class SimpleInterestCalculator {
    public static void Main(string[] args) {
        // Prompt user for the principal amount
        Console.Write("Enter the Principal amount (INR): ");
        double principal = Convert.ToDouble(Console.ReadLine());

        // Prompt user for the rate of interest
        Console.Write("Enter the Rate of Interest (%): ");
        double rate = Convert.ToDouble(Console.ReadLine());

        // Prompt user for the time period
        Console.Write("Enter the Time (in years): ");
        double time = Convert.ToDouble(Console.ReadLine());

        // Calculate the Simple Interest
        double simpleInterest = (principal * rate * time) / 100;

        // Output the result
        Console.WriteLine("The Simple Interest is " + simpleInterest + " for Principal " + principal + ", Rate of Interest " + rate + " and Time " + time + ".");
    }
}
