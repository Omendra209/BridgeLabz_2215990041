using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter two Numbers :");
        double input1, input2;
        if (!double.TryParse(Console.ReadLine(), out input1) ||
            !double.TryParse(Console.ReadLine(), out input2))
        {
            Console.Write("Invalid input, Please Enter valid Numbers");
            return;
        }
        Console.Write("Enter 1 for Addition\n" +
            "Enter 2 for Subtraction\n" +
            "Enter 3 for Multiplication\n" +
            "Enter 4 for Division\n" +
            "Enter Your Choice : ");
    Again:
        switch (int.Parse(Console.ReadLine()))
        {
            case 1:
                Console.WriteLine("Addition for number {0} and {1} is {2}", input1,input2,Addition(input1,input2));
                break;
            case 2:
                Console.WriteLine("Subtraction for number {0} and {1} is {2}", input1, input2, Subtraction(input1, input2));
                break;
            case 3:
                Console.WriteLine("Multiplication for number {0} and {1} is {2}", input1, input2, Multiplication(input1, input2));
                break;
            case 4:
                Console.WriteLine("Division for number {0} and {1} is {2}", input1, input2, Division(input1, input2));
                break;
            default:
                Console.Write("You Enter invalid Choice : ");
                goto Again;
        }
    }
    static double Addition(double input1, double input2)
    {
        return input1 + input2; 
    }
    static double Subtraction(double input1, double input2)
    {
        return input1 - input2;
    }
    static double Multiplication(double input1, double input2)
    {
        return input1 * input2;
    }
    static double Division(double input1, double input2)
    {
        return input1 / input2;
    }
}
