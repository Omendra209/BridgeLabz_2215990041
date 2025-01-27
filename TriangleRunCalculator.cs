using System;

class TriangleRunCalculator
{
    // Method to compute the number of rounds needed to complete a 5 km run
    public double CalculateRounds(double side1, double side2, double side3)
    {
        // Calculate the perimeter of the triangle
        double perimeter = side1 + side2 + side3;

        // Calculate the number of rounds needed to complete 5 km (5000 meters)
        double rounds = 5000 / perimeter;

        return rounds;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Instantiate the TriangleRunCalculator class
        TriangleRunCalculator calculator = new TriangleRunCalculator();

        // Take user input for the three sides of the triangle
        Console.Write("Enter the length of side 1 (in meters): ");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the length of side 2 (in meters): ");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the length of side 3 (in meters): ");
        double side3 = Convert.ToDouble(Console.ReadLine());

        // Calculate the number of rounds needed
        double rounds = calculator.CalculateRounds(side1, side2, side3);

        // Display the result
        Console.WriteLine("The athlete needs to complete " + Math.Ceiling(rounds) + " rounds to finish a 5 km run.");
    }
}