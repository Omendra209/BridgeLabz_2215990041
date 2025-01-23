using System;

class HarshadNumberChecker
{
    static void Main(string[] args)
    {
        // Prompt the user for input
        Console.WriteLine("Enter a number to check if it is a Harshad Number:");

        // Get input value for the number
        int origNumber = int.Parse(Console.ReadLine());

        // Define variables to store the number and the sum of its digits
        int number = origNumber; // Copy of the original number for digit processing
        int sum = 0; // Initialize sum of digits to zero

        // Calculate the sum of digits of the number
        while (number != 0)
        {
            // Extract the last digit of the number
            int digit = number % 10;

            // Add the digit to the sum
            sum += digit;

            // Remove the last digit from the number (reduce it)
            number = number / 10;
        }

        // Check if the original number is divisible by the sum of its digits
        if (origNumber % sum == 0)
        {
            // Print if the number is a Harshad Number
            Console.WriteLine("The number {0} is a Harshad Number.", origNumber);
        }
        else
        {
            // Print if the number is not a Harshad Number
            Console.WriteLine("The number {0} is not a Harshad Number.", origNumber);
        }
    }
}
