using System;

public class ReverseNumber {
    public static void Main(string[] args) {
        // Taking user input for the number
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Find the number of digits in the number
        int numDigits = (int)Math.Floor(Math.Log10(number) + 1);

        // Define an array to store the digits
        int[] digits = new int[numDigits];

        // Extract digits and store in the array
        for (int i = 0; i < numDigits; i++) {
            digits[i] = number % 10; // Get the last digit
            number /= 10; // Remove the last digit
        }

        // Display the digits in reverse order
        Console.Write("Reversed number: ");
        for (int i = 0; i < numDigits; i++) {
            Console.Write(digits[i]); // Print each digit
        }
        Console.WriteLine(); // New line after the reversed number
    }
}
