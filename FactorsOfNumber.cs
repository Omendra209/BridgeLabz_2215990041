using System;

class FactorsOfNumber
{
    static void Main(string[] args)
    {
        // Prompt the user to enter a number
        Console.WriteLine("Enter a number to find its factors:");
        int number = int.Parse(Console.ReadLine());

        // Display a message indicating the factors
        Console.WriteLine("The factors of " + number + " are:");

        // Loop to find and print factors
        for (int i = 1; i <= number; i++) // Loop from 1 to the number
        {
            if (number % i == 0) // Check if i is a factor of the number
            {
                Console.WriteLine(i); // Print the factor
            }
        }
    }
}