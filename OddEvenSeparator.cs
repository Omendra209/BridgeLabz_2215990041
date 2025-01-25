using System;

class OddEvenSeparator
{
    static void Main(string[] args)
    {
        // Prompt the user for input
        Console.WriteLine("Enter a natural number:");

        // Get input from the user
        int number = int.Parse(Console.ReadLine());

        // Check if the input is a natural number
        if (number < 1)
        {
            Console.WriteLine("Error: Please enter a natural number (greater than or equal to 1).");
            return; // Exit the program
        }

        // Initialize arrays for odd and even numbers
        int[] oddNumbers = new int[number / 2 + 1];
        int[] evenNumbers = new int[number / 2 + 1];

        // Index variables for odd and even arrays
        int oddIndex = 0, evenIndex = 0;

        // Loop to classify numbers as odd or even
        for (int i = 1; i <= number; i++)
        {
            if (i % 2 == 0)
            {
                evenNumbers[evenIndex++] = i; // Add to even numbers
            }
            else
            {
                oddNumbers[oddIndex++] = i; // Add to odd numbers
            }
        }

        // Print the odd numbers
        Console.WriteLine("\nOdd Numbers:");
        for (int i = 0; i < oddIndex; i++)
        {
            Console.Write(oddNumbers[i] + " ");
        }

        // Print the even numbers
        Console.WriteLine("\n\nEven Numbers:");
        for (int i = 0; i < evenIndex; i++)
        {
            Console.Write(evenNumbers[i] + " ");
        }
    }
}
