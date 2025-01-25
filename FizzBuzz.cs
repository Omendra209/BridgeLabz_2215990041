using System;

public class FizzBuzz {
    public static void Main(string[] args) {
        // Prompt the user to enter a positive integer
        Console.Write("Enter a positive integer: ");
        int number;
        
        // Validate the user input
        if (!int.TryParse(Console.ReadLine(), out number) || number <= 0) {
            Console.WriteLine("Please enter a valid positive integer.");
            return;
        }

        // Create a String array to hold the results
        string[] results = new string[number];

        // Loop through numbers from 1 to the input number
        for (int i = 1; i <= number; i++) {
            // Check for multiples of both 3 and 5, then 3, then 5
            if (i % 3 == 0 && i % 5 == 0) {
                results[i - 1] = "FizzBuzz";
            } else if (i % 3 == 0) {
                results[i - 1] = "Fizz";
            } else if (i % 5 == 0) {
                results[i - 1] = "Buzz";
            } else {
                results[i - 1] = i.ToString(); // Save the number if not a multiple of 3 or 5
            }
        }

        // Loop to display the results in the desired format
        for (int i = 0; i < results.Length; i++) {
            Console.WriteLine("Position " + (i + 1) + " = " + results[i]);
        }
    }
}