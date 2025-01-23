// Program to Check if a Number is an Armstrong Number
using System;

class ArmstrongCheck
{
    static void Main(string[] args)
    {
        // Prompt the user to input a number
        Console.WriteLine("Enter a number to check if it is an Armstrong number:");

        // Get the integer input from the user and store it in the variable 'number'
        int number = int.Parse(Console.ReadLine());

        // Define a variable 'sum' to store the sum of cubes of digits, initialized to zero
        int sum = 0;

        // Define a variable 'originalNumber' and assign the input number to it
        int originalNumber = number;

        // Run a while loop until 'originalNumber' becomes zero
        while (originalNumber != 0)
        {
            // Find the last digit of 'originalNumber' using the modulus operator
            int digit = originalNumber % 10;

            // Add the cube of the digit to 'sum'
            sum += digit * digit * digit;

            // Remove the last digit from 'originalNumber' using integer division
            originalNumber /= 10;
        }

        // Check if the computed sum is equal to the original number
        if (sum == number)
        {
            // If true, it is an Armstrong number
            Console.WriteLine("The number " + number + " is an Armstrong number.");
        }
        else
        {
            // Otherwise, it is not an Armstrong number
            Console.WriteLine("The number " + number + " is not an Armstrong number.");
        }
    }
}
