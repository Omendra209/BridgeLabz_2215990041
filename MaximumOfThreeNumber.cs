using System;

class Program
{
    static void Main()
    {
        int number1 = input();
        int number2 = input();
        int number3 = input();
        Display(MaximumNum(number1, number2, number3));
    }
    static int input()
    {
        Console.WriteLine("Enter a number : ");
        return int.Parse(Console.ReadLine());
    }
    static int MaximumNum(int number1, int number2, int number3)
    {
        if (number1 > number2 && number1 > number3) return number1;
        else if (number2 > number1 && number2 > number3) return number2;
        else return number3;
    }
    static void Display(int num)
    {
        Console.WriteLine("Maximum number is :" + num);
    }
}