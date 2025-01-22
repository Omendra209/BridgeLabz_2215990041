// Program to perform integer operations with given input values a, b, and c
using System;

class IntOperation {
    public static void Main(string[] args) {
        // Prompt user for the input values a, b, and c
        Console.Write("Enter the value for a: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the value for b: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the value for c: ");
        int c = Convert.ToInt32(Console.ReadLine());

        // Perform the integer operations considering operator precedence
        int result1 = a + b * c;   // Multiplication has higher precedence than addition
        int result2 = a * b + c;   // Multiplication has higher precedence than addition
        int result3 = c + a / b;   // Division has higher precedence than addition
        int result4 = a % b + c;   // Modulus has higher precedence than addition

        // Output the results
        Console.WriteLine("The results of Int Operations are " + result1 + ", " + result2 + ", " + result3 + ", and " + result4);
    }
}
