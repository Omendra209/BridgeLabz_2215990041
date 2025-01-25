using System;

class FactorsFinder
{
    static void Main(string[] args)
    {
        // Prompt user for input
        Console.WriteLine("Enter a number to find its factors:");
        int number = int.Parse(Console.ReadLine());

        // Handle invalid input
        if (number <= 0)
        {
            Console.WriteLine("Error: Please enter a positive number.");
            return;
        }

        // Initialize variables
        int maxFactor = 10; // Initial array size
        int[] factors = new int[maxFactor];
        int index = 0; // Current index in factors array

        // Loop to find factors
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                // Add factor to the array
                if (index == maxFactor)
                {
                    // Double the size of the factors array
                    maxFactor *= 2;
                    int[] temp = new int[maxFactor];
                    Array.Copy(factors, temp, factors.Length);
                    factors = temp;
                }
                factors[index++] = i; // Add factor and increment index
            }
        }

        // Display factors
        Console.WriteLine($"\nFactors of {number} are:");
        for (int i = 0; i < index; i++)
        {
            Console.Write(factors[i] + " ");
        }
    }
}
