using System;

class ChocolateDistributor
{
    // Method to find the number of chocolates each child gets and the remaining chocolates
    public static int[] FindRemainderAndQuotient(int numberOfChocolates, int numberOfChildren)
    {
        int chocolatesPerChild = numberOfChocolates / numberOfChildren; // Calculate chocolates per child
        int remainingChocolates = numberOfChocolates % numberOfChildren; // Calculate remaining chocolates

        return new int[] { chocolatesPerChild, remainingChocolates }; // Return an array with chocolates per child and remaining chocolates
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Get user input for the number of chocolates and number of children
        Console.Write("Enter the number of chocolates: ");
        int numberOfChocolates = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the number of children: ");
        int numberOfChildren = Convert.ToInt32(Console.ReadLine());

        // Check if the number of children is zero to avoid division by zero error
        if (numberOfChildren == 0)
        {
            Console.WriteLine("Error: The number of children cannot be zero.");
            return;
        }

        // Find the number of chocolates each child gets and the remaining chocolates
        int[] result = ChocolateDistributor.FindRemainderAndQuotient(numberOfChocolates, numberOfChildren);

        // Display the results
        Console.WriteLine("Each child will get: " + result[0] + " chocolates.");
        Console.WriteLine("Remaining chocolates: " + result[1] + ".");
    }
}