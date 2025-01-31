using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter a Number : ");
        int input;
    Again:
        if (!int.TryParse(Console.ReadLine(), out input) || input <=0)
        {
            Console.Write("Invalid input, Please Enter Positive Number: ");
            goto Again;
        }
        int result = Factorial(input);
        Console.WriteLine("Factorial of {0} is {1}.",input,result);
    }
    static int Factorial(int input)
    {
        if (input == 0 || input == 1) return 1; 
        return (input * Factorial(input-1));
    }
}