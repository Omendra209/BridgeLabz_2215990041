using System;

class Program
{
	static void Main()
	{
		Console.Write("Enter the String :");
		string input = Console.ReadLine().Replace(" ","").ToLower();
		if (IsPalindrome(input)) { Console.WriteLine("String is Palindrome"); }
		else { Console.WriteLine("String is not Palindrome"); }
	}
	static bool IsPalindrome(string input)
	{
		int start = 0,end = input.Length-1;
		while (start < end)
		{
			if (input[start] != input[end]) return false;
			start++;
			end--;
		}
		return true;
	}
}
