using System;

class NumberChecker
{
    // Method to check if the number is positive, negative, or zero
    public int CheckNumber(int number)
    {
        if (number < 0)
        {
            return -1; // Negative number
        }
        else if (number > 0)
        {
            return 1; // Positive number
        }
        else
        {
            return 0; // Zero
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Instantiate the NumberChecker class
        NumberChecker checker = new NumberChecker();

        // Get integer input from the user
        Console.Write("Enter an integer: ");
        int userInput = Convert.ToInt32(Console.ReadLine());

        // Check the number and get the result
        int result = checker.CheckNumber(userInput);

        // Display the result
        if (result == -1)
        {
            Console.WriteLine("The number is negative.");
        }
        else if (result == 1)
        {
            Console.WriteLine("The number is positive.");
        }
        else
        {
            Console.WriteLine("The number is zero.");
        }
    }
}