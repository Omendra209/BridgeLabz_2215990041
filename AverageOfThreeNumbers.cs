//Write a program that takes three numbers as input from the user and prints their average.
using System;
class AverageOfThreeNumbers
{
    static void Main()
    {
        double number1, number2, number3, average;
        Console.Write("Enter the first number = ");
        number1 = double.Parse(Console.ReadLine());
        Console.Write("Enter the second number = ");
        number2 = double.Parse(Console.ReadLine());
        Console.Write("Enter the third number = ");
        number3 = double.Parse(Console.ReadLine());
        average = (number1 + number2 + number3) / 3;
        Console.WriteLine(average);
    }
}
