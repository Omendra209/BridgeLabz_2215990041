using System;

class PrimeNumberCheck
{
    static void Main(string[] args)
    {
        // Prompt the user to enter a number
        Console.WriteLine("Enter a number to check if it is a prime number:");

        // Read the number entered by the user
        int number = int.Parse(Console.ReadLine());

        // Initialize a boolean variable to determine if the number is prime
        bool isPrime = true;

        // Check if the number is greater than 1 (only numbers > 1 can be prime)
        if (number > 1)
        {
            // Loop from 2 to number - 1 to check for divisors
            for (int i = 2; i < number; i++)
            {
                // If the number is divisible by i, it's not a prime number
                if (number % i == 0)
                {
                    isPrime = false;
                    break; // Exit the loop as we found a divisor
                }
            }
        }
        else
        {
            // Numbers <= 1 are not prime
            isPrime = false;
        }

        // Print the result based on the value of isPrime
        if (isPrime)
        {
            Console.WriteLine(number + " is a Prime Number.");
        }
        else
        {
            Console.WriteLine(number + " is Not a Prime Number.");
        }
    }
}