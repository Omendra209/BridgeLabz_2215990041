// Program to find the side of the square from the perimeter
using System;

class SquareSideCalculator {
    public static void Main(string[] args) {
        // Prompt user for the perimeter of the square
        Console.Write("Enter the perimeter of the square: ");
        double perimeter = Convert.ToDouble(Console.ReadLine());

        // Calculate the side of the square (Side = Perimeter / 4)
        double side = perimeter / 4;

        // Output the result
        Console.WriteLine("The length of the side is "+(side)+ " whose perimeter is "+(perimeter));
    }
}
