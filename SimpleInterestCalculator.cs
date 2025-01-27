using System;

class SimpleInterestCalculator
{
    // Method to calculate Simple Interest
    public double CalculateSimpleInterest(double principal, double rate, double time)
    {
        return (principal * rate * time) / 100;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Instantiate the SimpleInterestCalculator class
        SimpleInterestCalculator calculator = new SimpleInterestCalculator();

        // Take user input for Principal, Rate, and Time
        Console.Write("Enter Principal: ");
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Rate of Interest: ");
        double rate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Time (in years): ");
        double time = Convert.ToDouble(Console.ReadLine());

        // Calculate Simple Interest
        double simpleInterest = calculator.CalculateSimpleInterest(principal, rate, time);

        // Output the result without using string interpolation
        Console.WriteLine("The Simple Interest is " + simpleInterest + " for Principal " + principal + ", Rate of Interest " + rate + ", and Time " + time + ".");
    }
}