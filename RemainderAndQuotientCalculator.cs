using System;

class RemainderAndQuotientCalculator
{
    // Method to find the remainder and the quotient of two numbers
    public static int[] FindRemainderAndQuotient(int number, int divisor)
    {
        int quotient = number / divisor; // Calculate quotient
        int remainder = number % divisor; // Calculate remainder

        return new int[] { quotient, remainder }; // Return an array with quotient and remainder
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Get user input for two numbers
        Console.Write("Enter the dividend (number): ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the divisor: ");
        int divisor = Convert.ToInt32(Console.ReadLine());

        // Check if the divisor is zero to avoid division by zero error
        if (divisor == 0)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
            return;
        }

        // Find the remainder and quotient
        int[] result = RemainderAndQuotientCalculator.FindRemainderAndQuotient(number, divisor);

        // Display the results
        Console.WriteLine("Quotient: " + result[0]);
        Console.WriteLine("Remainder: " + result[1]);
    }
}