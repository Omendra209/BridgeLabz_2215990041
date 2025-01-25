using System;

class MultiplicationTable6To9
{
    static void Main(string[] args)
    {
        // Prompt the user for input
        Console.WriteLine("Enter a number to generate its multiplication table from 6 to 9:");
        
        // Take integer input and store it in the variable 'number'
        int number = int.Parse(Console.ReadLine());

        // Define an integer array to store the multiplication results
        int[] multiplicationResult = new int[4];

        // Using a for loop, calculate the multiplication table for numbers from 6 to 9
        for (int i = 0; i < 4; i++)
        {
            // Multiply the number by (6 + i) and store the result in the array
            multiplicationResult[i] = number * (6 + i);
        }

        // Display the multiplication table in the specified format
        Console.WriteLine("\nMultiplication table for " + number + " from 6 to 9:");
        for (int i = 0; i < 4; i++)
        {
            int multiplier = 6 + i; // Calculate the multiplier
            Console.WriteLine(number + " * " + multiplier + " = " + multiplicationResult[i]);
        }
    }
}
