using System;

class Program
{
	static void Main()
	{
		Console.Write("Enter a Number :");
		int input;
        if (!int.TryParse(Console.ReadLine(), out input) || input < 0)
        {
            Console.WriteLine("Invalid input! Please enter a positive integer.");
            return;
        }
        if (IsPrime(input)) Console.WriteLine("Number is Prime");
		else Console.WriteLine("Number is not Prime");
    }
	static bool IsPrime(int input)
	{
		int range = (int)Math.Sqrt(input);
		if (input < 2) return false;
		for (int i = 2; i <= range; i++)
		{
			if (input % i == 0) return false;
		}
		return true;
	}
}
