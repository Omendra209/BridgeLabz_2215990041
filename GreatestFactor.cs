using System;

class GreatestFactor
{
    static void Main(string[] args)
    {
        // Prompt the user to enter a number
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        // Initialize the greatestFactor variable
        int greatestFactor = 1;

        // Loop to find the greatest factor
        for (int i = number - 1; i >= 1; i--)
        {
            if (number % i == 0) // Check if the number is divisible by i
            {
                greatestFactor = i; // Assign i to greatestFactor
                break; // Exit the loop
            }
        }

        // Display the greatest factor
        Console.WriteLine("The greatest factor of " + number + " (excluding itself) is: " + greatestFactor);
    }
}