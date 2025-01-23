// Program to check if the first number is the smallest of three numbers
using System;

class SmallestNumberChecker {
    public static void Main(string[] args) {
        // Prompt the user for three numbers
        Console.Write("Enter the first number: ");
        int number1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int number2 = int.Parse(Console.ReadLine());

        Console.Write("Enter the third number: ");
        int number3 = int.Parse(Console.ReadLine());

        // Check if the first number is the smallest
        bool isFirstSmallest = (number1 < number2 && number1 < number3);

        // Display the result
        Console.WriteLine("Is the first number the smallest? " + (isFirstSmallest ? "Yes" : "No"));
    }
}
