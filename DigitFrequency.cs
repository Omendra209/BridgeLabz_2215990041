using System;

public class DigitFrequency {
    public static void Main(string[] args) {
        // Taking input for the number
        Console.Write("Enter a number: ");
        string inputNumber = Console.ReadLine();

        // Convert input to a valid number (we use string to easily loop through digits)
        // Validate the input to ensure it's numeric
        if (!long.TryParse(inputNumber, out long number)) {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return;
        }

        // Create an array to store frequency of digits (0-9)
        int[] frequency = new int[10];

        // Loop through each character of the string representation of the number
        foreach (char digitChar in inputNumber) {
            if (Char.IsDigit(digitChar)) {
                // Convert character to integer and increment the frequency
                int digit = digitChar - '0';
                frequency[digit]++;
            }
        }

        // Display the frequency of each digit
        Console.WriteLine("Digit Frequency:");
        for (int i = 0; i < 10; i++) {
            if (frequency[i] > 0) {
                Console.WriteLine("Digit " + i + ": " + frequency[i] + " time(s)");
            }
        }
    }
}
