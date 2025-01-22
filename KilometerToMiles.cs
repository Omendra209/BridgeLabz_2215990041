// Program to convert distance in kilometers to miles
using System;

class KilometerToMiles {
    public static void Main(string[] args) {
        // Conversion factor: 1 mile = 1.6 kilometers
        double conversionFactor = 1.6;

        // Prompt user for input
        Console.Write("Enter the distance in kilometers = ");
        
        // Read user input and parse to double
        double kilometers = Convert.ToDouble(Console.ReadLine());

        // Convert kilometers to miles
        double miles = kilometers / conversionFactor;

        // Output the result
        Console.WriteLine($"The total miles is {miles} mile for the given {kilometers} km");
    }
}