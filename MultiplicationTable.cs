using System;

class MultiplicationTable
{
    static void Main(string[] args)
    {
        // Get user input for the number
        Console.WriteLine("Enter a number to print its multiplication table:");
        int number = int.Parse(Console.ReadLine());

        // Define an array to store the multiplication table results
        int[] table = new int[10];

        // Calculate the multiplication table and store it in the array
        for (int i = 1; i <= 10; i++)
        {
            table[i - 1] = number * i;
        }

        // Display the results from the array
        Console.WriteLine("\nMultiplication Table for " + number + ":");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(number + " * " + i + " = " + table[i - 1]);
        }
    }
}
