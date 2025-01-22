// Program to swap two numbers
using System;

class NumberSwapper {
    public static void Main(string[] args) {
        // Prompt user for the first number
        Console.Write("Enter the first number: ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        // Prompt user for the second number
        Console.Write("Enter the second number: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        // Swap the numbers
        int temp = number1;
        number1 = number2;
        number2 = temp;

        // Output the swapped numbers
        Console.WriteLine("The swapped numbers are " + number1 + " and " + number2);
    }
}
