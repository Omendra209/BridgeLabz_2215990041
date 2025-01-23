// Program to check whether a number is positive, negative, or zero
using System;

class NumberChecker {
    public static void Main(string[] args) {
        // Prompt the user for input
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Check if the number is positive, negative, or zero
        if (number > 0) {
            // Display the result for a positive number
            Console.WriteLine("The number " + number + " is positive.");
        } else if (number < 0) {
            // Display the result for a negative number
            Console.WriteLine("The number " + number + " is negative.");
        } else {
            // Display the result for zero
            Console.WriteLine("The number is zero.");
        }
    }
}
