// Program to convert weight in pounds to kilograms
using System;

class WeightConverter {
    public static void Main(string[] args) {
        // Prompt user for the weight in pounds
        Console.Write("Enter the weight (in pounds): ");
        double weightInPounds = Convert.ToDouble(Console.ReadLine());

        // Convert the weight to kilograms
        double weightInKilograms = weightInPounds / 2.2;

        // Output the results
        Console.WriteLine("The weight of the person in pounds is " + weightInPounds + " and in kg is " + weightInKilograms + ".");
    }
}
