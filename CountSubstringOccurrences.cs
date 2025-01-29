using System;

class Program
{
    static void Main()
    {
        // Prompt user to enter the main string
        Console.WriteLine("Enter the main string:");
        string mainString = Console.ReadLine();

        // Prompt user to enter the substring to search for
        Console.WriteLine("Enter the substring to count occurrences:");
        string subString = Console.ReadLine();

        // Call method to count occurrences of the substring
        int count = CountSubstringOccurrences(mainString, subString);

        // Display the count of occurrences
        Console.WriteLine("The substring occurs " + count + " times in the main string.");
    }

    static int CountSubstringOccurrences(string mainStr, string subStr)
    {
        int count = 0;
        int index = 0;

        // Search for the substring within the main string
        while ((index = mainStr.IndexOf(subStr, index)) != -1)
        {
            count++; // Increment count when found
            index += subStr.Length; // Move index to the next position after the found substring
        }

        return count;
    }
}
