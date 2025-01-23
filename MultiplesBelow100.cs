using System;

class MultiplesBelow100
{
    static void Main(string[] args)
    {
        // Prompt the user to enter a number
        Console.WriteLine("Enter a number to find its multiples below 100:");
        int number = int.Parse(Console.ReadLine());

        // Display a message indicating the multiples
        Console.WriteLine("The multiples of " + number + " below 100 are:");

        // Loop backward from 100 to 1
        for (int i = 100; i >= 1; i--)
        {
            // Check if the number is a multiple of i
            if (i % number == 0)
            {
                Console.WriteLine(i); // Print the multiple
            }
        }
    }
}