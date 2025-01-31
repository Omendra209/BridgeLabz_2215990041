using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the Two Numbers : ");
        int input1, input2;
        if(!int.TryParse(Console.ReadLine(), out input1) || input1 <=0 ||
            !int.TryParse(Console.ReadLine(), out input2) || input2 <= 0)
        {
            Console.Write("Invalid input, Please Enter Positive Numbers");
            return;
        }
        int resultGCD = ResultGCD(input1,input2);
        int resultLCM = ResultLCM(input1,input2);
        Console.WriteLine("LCM for {0} and {1} is {2}.", input1, input2, resultLCM);
        Console.WriteLine("GCD for {0} and {1} is {2}.", input1, input2, resultGCD);
    }
    static int ResultGCD(int input1,int input2)
    {
        while(input2 !=0 )
        {
            int temp = input2;
            input2 = input1%input2;
            input1 = temp;
        }
        return input1;
    }
    static int ResultLCM(int input1,int input2)
    {
        return (input1 * input2) / ResultGCD(input1 ,input2);
    }
}
