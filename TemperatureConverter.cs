using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the Temperature in Fahrenheit/Celsius : ");
        double input;
        if (!double.TryParse(Console.ReadLine(), out input))
        {
            Console.Write("Please Enter Valid Temperature in Numbers");
            return;
        }
        Console.WriteLine("Enter 1 for Fahrenheit to Celsius\nEnter 2 for Celsius to Fahrenheit");
        switch (int.Parse(Console.ReadLine()))
        {
            case 1:
                Console.WriteLine("Your Converted Temperature is {0}C", F2C(input));
                break;
            case 2:
                Console.WriteLine("Your Converted Temperature is {0}F", C2F(input));
                break;
            default:
                Console.WriteLine("You Enter invalid Choice");
                break;
        }
    }
    static double F2C(double input)
    {
        return (input -32)*5/9;
    }
    static double C2F(double input)
    {
        return (input * 9 / 5) + 32;
    }
}
