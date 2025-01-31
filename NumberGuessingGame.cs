using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number between 1 to 100 for Computer to Guess : ");
        byte inputNum = byte.Parse(Console.ReadLine());
        byte low=0, high=100;
    Again:
        byte guess = (byte)(GuessNum(low,high));
        Console.WriteLine("Number Guessed by Computer is : "+guess);
        switch (Feedback(guess))
        {
            case "high":
                high = (byte)(guess-1);
                goto Again;
            case "low":
                low = (byte)(guess+1);
                goto Again;
            case "correct":
                Console.WriteLine("Computer Guessed your Number : "+ guess);
                break;
        }
    }
    static int GuessNum(byte low,byte high)
    {
        Random random = new Random();
        return random.Next(low,high+1);
    }
    static string Feedback(byte guess)
    {
        Console.Write("Enter the feedback in \"High\" , \"Low\" or Correct : ");
        string inputFeedback = Console.ReadLine();
        return inputFeedback.ToLower();
    }
}