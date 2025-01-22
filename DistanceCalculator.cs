// Program to find the distance in yards and miles from the distance in feet
using System;

class DistanceCalculator {
    public static void Main(string[] args) {
        // Prompt user for the distance in feet
        Console.Write("Enter the distance in feet: ");
        double distanceInFeet = Convert.ToDouble(Console.ReadLine());

        // Convert the distance to yards (1 yard = 3 feet)
        double distanceInYards = distanceInFeet / 3;

        // Convert the distance to miles (1 mile = 1760 yards)
        double distanceInMiles = distanceInYards / 1760;

        // Output the results
        Console.WriteLine("The distance is "+(distanceInYards)+" yards and "+(distanceInMiles)+" miles.");
    }
}
