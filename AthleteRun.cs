// Program to calculate the number of rounds an athlete must complete in a triangular park
using System;

class AthleteRun {
    public static void Main(string[] args) {
        // Prompt user for the sides of the triangular park
        Console.Write("Enter the first side of the triangular park (in meters): ");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second side of the triangular park (in meters): ");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the third side of the triangular park (in meters): ");
        double side3 = Convert.ToDouble(Console.ReadLine());

        // Calculate the perimeter of the triangular park
        double perimeter = side1 + side2 + side3;

        // Convert the 5 km run to meters (1 km = 1000 meters)
        double distanceToRun = 5 * 1000;

        // Calculate the total number of rounds required
        double rounds = distanceToRun / perimeter;

        // Output the result
        Console.WriteLine("The total number of rounds the athlete will run is " + Math.Ceiling(rounds) + " to complete 5 km.");
    }
}
