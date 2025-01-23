using System;

class FizzBuzz
{
    static void Main(string[] args)
    {
        // Prompt the user to enter a positive integer
        Console.WriteLine("Enter a positive integer:");

        // Read the number entered by the user
        int number = int.Parse(Console.ReadLine());

        // Check if the number is positive
        if (number > 0)
        {
            // Initialize the counter
            int i = 0;

            // Use a while loop to iterate from 0 to the entered number
            while (i <= number)
            {
                // Check if the current number is a multiple of both 3 and 5
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                // Check if the current number is a multiple of 3
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                // Check if the current number is a multiple of 5
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                // Otherwise, print the number
                else
                {
                    Console.WriteLine(i);
                }

                // Increment the counter
                i++;
            }
        }
        else
        {
            // Print a message if the input is not a positive integer
            Console.WriteLine("Please enter a positive integer.");
        }
    }
}