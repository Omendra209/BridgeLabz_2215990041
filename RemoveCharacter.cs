using System;

class Program
{
	static void Main()
	{
		Console.WriteLine("Enter the String: ");
		string inputString = Console.ReadLine();
        Console.WriteLine("Enter the Character to Remove from String: ");
        char inputCharacter = Console.ReadKey().KeyChar;
        string result = RemoveCharacter(inputString,inputCharacter);
		Console.WriteLine("\nString after removing Characters: "+result);
	}
	static string RemoveCharacter(string inputString, char inputCharacter)
	{
        string result = "\0";
        foreach (char item in inputString)
        {
            if (item != inputCharacter)
            {
                result += item;
            }
        }
        return result;
    }
}
