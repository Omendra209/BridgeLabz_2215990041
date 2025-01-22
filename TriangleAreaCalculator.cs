// Program to calculate the area of a triangle in square inches and square centimeters
using System;

class TriangleAreaCalculator {
    public static void Main(string[] args) {
        // Prompt user for the base of the triangle in centimeters
        Console.Write("Enter the base of the triangle in centimeters: ");
        double baseCm = Convert.ToDouble(Console.ReadLine());

        // Prompt user for the height of the triangle in centimeters
        Console.Write("Enter the height of the triangle in centimeters: ");
        double heightCm = Convert.ToDouble(Console.ReadLine());

        // Calculate the area in square centimeters
        double areaCm2 = 0.5 * baseCm * heightCm;

        // Convert the area to square inches (1 cm² = 0.155 square inches)
        double areaIn2 = areaCm2 * 0.155;

        // Output the results
        Console.WriteLine($"The area of the triangle is {areaCm2} square centimeters and {areaIn2} square inches.");
    }
}
