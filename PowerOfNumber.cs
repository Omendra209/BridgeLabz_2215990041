using System;

class PowerOfNumber
{
    static void Main(string[] args)
    {
        // Prompt the user to enter the base number
        Console.WriteLine("Enter the base number:");
        int number = int.Parse(Console.ReadLine());

        // Prompt the user to enter the power
        Console.WriteLine("Enter the power:");
        int power = int.Parse(Console.ReadLine());

        // Initialize the result variable
        int result = 1;

        // Loop to calculate the power
        for (int i = 1; i <= power; i++)
        {
            result *= number; // Multiply the result by the number
        }

        // Display the result
        Console.WriteLine(number + " raised to the power of " + power + " is: " + result);
    }
}