using System;

class AbundantNumberChecker
{
    static void Main(string[] args)
    {
        // Prompt the user for input
        Console.WriteLine("Enter a number to check if it is an Abundant Number:");

        // Get input value for the number
        int number = int.Parse(Console.ReadLine());

        // Define variable to store the sum of divisors, initialized to zero
        int sum = 0;

        // Iterate through all potential divisors from 1 to (number - 1)
        for (int i = 1; i < number; i++)
        {
            // Check if 'i' is a divisor of the number
            if (number % i == 0)
            {
                // Add the divisor to the sum
                sum += i;
            }
        }

        // Check if the sum of divisors is greater than the number
        if (sum > number)
        {
            // Print if the number is an Abundant Number
            Console.WriteLine("The number {0} is an Abundant Number.", number);
        }
        else
        {
            // Print if the number is not an Abundant Number
            Console.WriteLine("The number {0} is not an Abundant Number.", number);
        }
    }
}
