using System;

class NumberAnalysis
{
    static void Main(string[] args)
    {
        // Define an array of 5 integers
        int[] numbers = new int[5];

        // Take user input for 5 numbers
        Console.WriteLine("Enter 5 numbers:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Number " + (i + 1) + ": ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nNumber Analysis:");
        
        // Loop through the array and analyze each number
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > 0)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine("Number " + numbers[i] + " is positive and even.");
                }
                else
                {
                    Console.WriteLine("Number " + numbers[i] + " is positive and odd.");
                }
            }
            else if (numbers[i] < 0)
            {
                Console.WriteLine("Number " + numbers[i] + " is negative.");
            }
            else
            {
                Console.WriteLine("Number " + numbers[i] + " is zero.");
            }
        }

        // Compare the first and last elements of the array
        Console.WriteLine("\nComparison of the first and last elements:");
        if (numbers[0] > numbers[4])
        {
            Console.WriteLine("The first element (" + numbers[0] + ") is greater than the last element (" + numbers[4] + ").");
        }
        else if (numbers[0] < numbers[4])
        {
            Console.WriteLine("The first element (" + numbers[0] + ") is less than the last element (" + numbers[4] + ").");
        }
        else
        {
            Console.WriteLine("The first element (" + numbers[0] + ") is equal to the last element (" + numbers[4] + ").");
        }
    }
}
