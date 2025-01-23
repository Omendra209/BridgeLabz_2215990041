// Program to check if a number is divisible by 5
using System;

class DivisibilityChecker {
    public static void Main(string[] args) {
        // Prompt the user for input
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Check if the number is divisible by 5
        bool isDivisible = (number % 5 == 0);

        // Display the result
        Console.WriteLine("Is the number " + number + " divisible by 5? " + (isDivisible ? "Yes" : "No"));
    }
}
