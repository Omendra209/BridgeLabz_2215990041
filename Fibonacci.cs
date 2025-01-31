using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of terms: ");
        int input;
    Again:
        if (!int.TryParse(Console.ReadLine(), out input) || input <= 0)
        {
            Console.Write("\nInvalid input! Please enter a positive integer.\nEnter Again : ");
            goto Again;
        }
        Console.WriteLine("Fibonacci Series:");
        FibonacciLoop(input);
    }
    static void FibonacciLoop(int input)
    {
        int a = 0, b = 1, c;
        Console.Write(a + " " + b + " ");
        for (int i = 2; i < input; i++)
        {
            c = a + b;
            Console.Write(c + " ");
            a = b;
            b = c;
        }
    }
}
