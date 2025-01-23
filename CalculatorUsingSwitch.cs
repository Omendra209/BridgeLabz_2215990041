using System;

class CalculatorUsingSwitch
{
    static void Main(string[] args)
    {
        // Prompt the user for the first number
        Console.WriteLine("Enter the first number:");
        double first = double.Parse(Console.ReadLine());

        // Prompt the user for the second number
        Console.WriteLine("Enter the second number:");
        double second = double.Parse(Console.ReadLine());

        // Prompt the user for the operator
        Console.WriteLine("Enter an operator (+, -, *, /):");
        string op = Console.ReadLine();

        // Variable to store the result
        double result = 0;

        // Perform the operation based on the input operator
        switch (op)
        {
            case "+":
                result = first + second; // Addition
                Console.WriteLine("The result of addition is: " + result);
                break;

            case "-":
                result = first - second; // Subtraction
                Console.WriteLine("The result of subtraction is: " + result);
                break;

            case "*":
                result = first * second; // Multiplication
                Console.WriteLine("The result of multiplication is: " + result);
                break;

            case "/":
                if (second != 0) // Check for division by zero
                {
                    result = first / second; // Division
                    Console.WriteLine("The result of division is: " + result);
                }
                else
                {
                    Console.WriteLine("Division by zero is not allowed.");
                }
                break;

            default:
                // Handle invalid operator input
                Console.WriteLine("Invalid Operator. Please use +, -, *, or /.");
                break;
        }
    }
}
