using System;

class NaturalNumberSumCalculator
{
    // Method to find the sum of n natural numbers using recursion
    public static int SumOfNaturalNumbersRecursive(int n)
    {
        if (n == 1) // Base case
        {
            return 1;
        }
        return n + SumOfNaturalNumbersRecursive(n - 1); // Recursive case
    }

    // Method to find the sum of n natural numbers using the formula
    public static int SumOfNaturalNumbersFormula(int n)
    {
        return n * (n + 1) / 2; // Formula for the sum of first n natural numbers
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Get user input for the number
        Console.Write("Enter a natural number: ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
        {
            Console.WriteLine("Please enter a valid natural number greater than 0.");
            return; // Exit if input is not a natural number
        }

        // Calculate the sum using recursion
        int recursiveSum = NaturalNumberSumCalculator.SumOfNaturalNumbersRecursive(n);
        Console.WriteLine("Sum of first " + n + " natural numbers (recursive): " + recursiveSum);

        // Calculate the sum using the formula
        int formulaSum = NaturalNumberSumCalculator.SumOfNaturalNumbersFormula(n);
        Console.WriteLine("Sum of first " + n + " natural numbers (formula): " + formulaSum);

        // Compare the results
        if (recursiveSum == formulaSum)
        {
            Console.WriteLine("Both methods give the same result. The computation is correct.");
        }
        else
        {
            Console.WriteLine("The results do not match. There is an error in the computation.");
        }
    }
}