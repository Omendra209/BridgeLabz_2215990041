// Program to create a basic calculator for addition, subtraction, multiplication, and division
using System;

class BasicCalculator {
    public static void Main(string[] args) {
        // Prompt user for the first number
        Console.Write("Enter the first number: ");
        double number1 = Convert.ToDouble(Console.ReadLine());

        // Prompt user for the second number
        Console.Write("Enter the second number: ");
        double number2 = Convert.ToDouble(Console.ReadLine());

        // Perform arithmetic operations
        double addition = number1 + number2;
        double subtraction = number1 - number2;
        double multiplication = number1 * number2;
        double division = number2 != 0 ? number1 / number2 : double.NaN; // Handle division by zero

        // Output the results
        Console.WriteLine($"The addition, subtraction, multiplication, and division value of two numbers {number1} and {number2} is {addition}, {subtraction}, {multiplication}, and {(double.IsNaN(division) ? "undefined (division by zero)" : division)}.");
    }
}
