using System;

class NaturalNumberSum
{
    // Method to find the sum of n natural numbers using a loop
    public int SumOfNaturalNumbers(int n)
    {
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += i; // Add each natural number to the sum
        }
        return sum;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Instantiate the NaturalNumberSum class
        NaturalNumberSum naturalNumberSum = new NaturalNumberSum();

        // Get integer input from the user
        Console.Write("Enter a positive integer: ");
        int n = Convert.ToInt32(Console.ReadLine());

        // Check if the input is a positive integer
        if (n < 1)
        {
            Console.WriteLine("Please enter a positive integer greater than 0.");
            return;
        }

        // Calculate the sum of n natural numbers
        int sum = naturalNumberSum.SumOfNaturalNumbers(n);

        // Display the result
        Console.WriteLine("The sum of the first " + n + " natural numbers is " + sum + ".");
    }
}