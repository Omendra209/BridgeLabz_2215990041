// Program to find the sum of numbers until the user enters 0
using System;

class SumOfNumbers {
    public static void Main(string[] args) {
        // Initialize the total variable to store the sum and the user input value
        double total = 0.0;
        double userInput;

        // Use a while loop to continue adding values until the user enters 0
        while (true) {
            // Prompt the user for input
            Console.Write("Enter a number (or 0 to stop): ");
            userInput = double.Parse(Console.ReadLine());

            // If the user enters 0, break the loop
            if (userInput == 0) {
                break;
            }

            // Add the user input to the total
            total += userInput;
        }

        // Display the total sum of numbers
        Console.WriteLine("The total sum of the numbers is: "+total);
    }
}
