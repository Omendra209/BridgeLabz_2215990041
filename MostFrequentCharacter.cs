using System;
using System.Collections.Generic;
class Program
{
	static void Main()
	{
		Console.WriteLine("Enter the String");
		string input = Console.ReadLine();
		char result = MostFrequencyCharacter(input);
		Console.WriteLine("Most Frequency Character: "+result);
	}
	static char MostFrequencyCharacter(string input)
	{
		Dictionary<char, int> charCount = new Dictionary<char, int>();
		foreach(char c in input)
		{
            if (charCount.ContainsKey(c))
            {
				charCount[c]++;
            }
            else
            {
                charCount.Add(c, 1);
            }
        }
		char mostFrequent = '\0';
		int maxCount = 0;
        foreach (var item in charCount)
        {
            if (item.Value>maxCount)
            {
                maxCount = item.Value;
                mostFrequent = item.Key;
            }
        }
        return mostFrequent;
    }
}