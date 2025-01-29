using System;

class Program
{
    static void Main()
    {
        // Prompt the user to enter a sentence
        Console.WriteLine("Enter the Sentence");

        // Read the input sentence from the console
        string input = Console.ReadLine();

        // Call the method to find the longest word in the sentence
        string result = LongestWord(input);

        // Display the longest word found
        Console.WriteLine("Longest Word in a Sentence is " + result);
    }

    static string LongestWord(string str)
    {
        // Variable to store the longest word
        string word = "";

        // Variable to store the length of the longest word found
        int length = 0;

        // Split the input string into an array of words using space as a delimiter
        string[] words = str.Split(' ');

        // Iterate through each word in the array
        foreach (string s in words)
        {
            // If the current word is longer than the previously stored longest word
            if (s.Length > length)
            {
                // Update the longest word and its length
                word = s;
                length = s.Length;
            }
        }

        // Return the longest word found in the sentence
        return word;
    }
}
