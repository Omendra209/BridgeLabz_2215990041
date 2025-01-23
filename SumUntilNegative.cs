// Program to find the sum of numbers until the user enters 0 or a negative number
using System;

class SumUntilNegative {
    public static void Main(string[] args) {
        // Initialize the total variable to store the sum and the user input value
        double total = 0.0;
        double userInput;

        // Use an infinite while loop to continue adding values until the user enters 0 or a negative number
        while (true) {
            // Prompt the user for input
            Console.Write("Enter a number (or a negative number to stop): ");
            userInput = double.Parse(Console.ReadLine());

            // If the user enters 0 or a negative number, break the loop
            if (userInput <= 0) {
                break;
            }

            // Add the user input to the total
            total += userInput;
        }

        // Display the total sum of numbers
        Console.WriteLine("The total sum of the numbers is: "+total);
    }
}