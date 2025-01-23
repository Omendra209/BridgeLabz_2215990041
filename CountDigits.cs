// Program to count the number of digits in an integer
using System;

class CountDigits
{
    static void Main(string[] args)
    {
        // Prompt the user for input
        Console.WriteLine("Enter an integer to count its digits:");

        // Get input value for the number
        int number = int.Parse(Console.ReadLine());

        // Initialize count to 0
        int count = 0;

        // Use a loop to count digits
        while (number != 0)
        {
            // Remove the last digit by dividing the number by 10
            number /= 10;

            // Increment the count for each digit
            count++;
        }

        // Display the total number of digits
        Console.WriteLine($"The number of digits is: {count}");
    }
}
