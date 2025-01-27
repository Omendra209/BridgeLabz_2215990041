using System;

class FactorCalculator
{
    // Method to find the factors of a number and return them in an array
    public static int[] FindFactors(int number)
    {
        // First loop to count the factors
        int count = 0;
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                count++;
            }
        }

        // Initialize the array with the count of factors
        int[] factors = new int[count];
        int index = 0;

        // Second loop to save the factors into the array
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                factors[index] = i;
                index++;
            }
        }

        return factors; // Return the array of factors
    }

    // Method to find the sum of the factors
    public static int SumOfFactors(int[] factors)
    {
        int sum = 0;
        foreach (int factor in factors)
        {
            sum += factor;
        }
        return sum;
    }

    // Method to find the product of the factors
    public static long ProductOfFactors(int[] factors)
    {
        long product = 1;
        foreach (int factor in factors)
        {
            product *= factor;
        }
        return product;
    }

    // Method to find the sum of squares of the factors
    public static double SumOfSquaresOfFactors(int[] factors)
    {
        double sumOfSquares = 0;
        foreach (int factor in factors)
        {
            sumOfSquares += Math.Pow(factor, 2);
        }
        return sumOfSquares;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Get user input for the number
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Find the factors of the number
        int[] factors = FactorCalculator.FindFactors(number);

        // Display the factors
        Console.WriteLine("Factors of " + number + ": " + string.Join(", ", factors));

        // Calculate and display the sum of factors
        int sum = FactorCalculator.SumOfFactors(factors);
        Console.WriteLine("Sum of factors: " + sum);

        // Calculate and display the product of factors
        long product = FactorCalculator.ProductOfFactors(factors);
        Console.WriteLine("Product of factors: " + product);

        // Calculate and display the sum of squares of factors
        double sumOfSquares = FactorCalculator.SumOfSquaresOfFactors(factors);
        Console.WriteLine("Sum of squares of factors: " + sumOfSquares);
    }
}