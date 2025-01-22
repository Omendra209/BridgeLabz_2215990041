// Program to perform double operations with given input values a, b, and c
using System;

class DoubleOpt {
    public static void Main(string[] args) {
        // Prompt user for the input values a, b, and c (as doubles)
        Console.Write("Enter the value for a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the value for b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the value for c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        // Perform the double operations considering operator precedence
        double result1 = a + b * c;   // Multiplication has higher precedence than addition
        double result2 = a * b + c;   // Multiplication has higher precedence than addition
        double result3 = c + a / b;   // Division has higher precedence than addition
        double result4 = a % b + c;   // Modulus has higher precedence than addition

        // Output the results
        Console.WriteLine("The results of Double Operations are " + result1 + ", " + result2 + ", " + result3 + ", and " + result4);
    }
}
