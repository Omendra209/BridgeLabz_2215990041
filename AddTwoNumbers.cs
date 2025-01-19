//Write a program that takes two numbers as input from the user and prints their sum.

using System;
class AddTwoNumbers
{
    static void Main()
    {
        int number1, number2, result;
        Console.Write("Enter the first number = ");
        number1 = int.parse(Console.ReadLine()); 
        Console.Write("Enter the second number =  ");
        number2 = int.parse(Console.ReadLine()); 
        result = num1 + num2;       
        Console.WriteLine("The Addition of {0} and {1} is = {2}", number1, number2, result);
    }
}