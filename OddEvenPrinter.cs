using System;

class OddEvenPrinter {
    public static void Main(string[] args) {
        // Prompt user for input
        Console.Write("Enter a natural number: ");
        int number = int.Parse(Console.ReadLine());

        // Check if the number is a positive natural number
        if (number <= 0) {
            // If the number is not a positive integer, print an error message
            Console.WriteLine("Please enter a positive natural number.");
        } else {
            // Iterate through numbers from 1 to the entered number
            for (int i = 1; i <= number; i++) {
                // Check if the number is even or odd
                if (i % 2 == 0) {
                    // If the number is divisible by 2, it is even
                    Console.WriteLine(i + " is an even number.");
                } else {
                    // If the number is not divisible by 2, it is odd
                    Console.WriteLine(i + " is an odd number.");
                }
            }
        }
    }
}
