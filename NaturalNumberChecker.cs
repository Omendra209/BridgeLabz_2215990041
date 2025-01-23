// Program to check if a number is a natural number and calculate the sum of n natural numbers
using System;

class NaturalNumberChecker {
    public static void Main(string[] args) {
        // Prompt the user for input
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Check if the number is a natural number (positive integer)
        if (number > 0) {
            // Calculate the sum of n natural numbers
            int sum = number * (number + 1) / 2;

            // Display the result
            Console.WriteLine("The sum of " + number + " natural numbers is " + sum);
        } else {
            // Display the result for non-natural numbers
            Console.WriteLine("The number " + number + " is not a natural number.");
        }
    }
}
