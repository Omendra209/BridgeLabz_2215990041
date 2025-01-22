// Program to calculate the quotient and remainder of two numbers
using System;

class QuotientRemainderCalculator {
    public static void Main(string[] args) {
        // Prompt user for the first number
        Console.Write("Enter the first number: ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        // Prompt user for the second number
        Console.Write("Enter the second number: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        // Calculate the quotient and remainder
        int quotient = number1 / number2;
        int remainder = number1 % number2;

        // Output the result using the requested format
        Console.WriteLine("The Quotient is " + quotient + " and Remainder is " + remainder + " of two numbers " + number1 + " and " + number2);
    }
}
