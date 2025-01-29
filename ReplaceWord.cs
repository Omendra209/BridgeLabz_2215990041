using System;

class Program
{
    static void Main()
    {
        // Taking input sentence from the user
        Console.WriteLine("Enter the sentence: ");
        string sentence = Console.ReadLine();

        // Taking input for the word to be replaced
        Console.WriteLine("Enter the word to replace: ");
        string oldWord = Console.ReadLine();

        // Taking input for the new word
        Console.WriteLine("Enter the new word: ");
        string newWord = Console.ReadLine();

        // Calling the custom ReplaceWord method
        string result = ReplaceWord(sentence, oldWord, newWord);

        // Displaying the modified sentence
        Console.WriteLine("Modified Sentence: " + result);
    }

    static string ReplaceWord(string sentence, string oldWord, string newWord)
    {
        string result = ""; // Initialize an empty result string
        string tempWord = ""; // Store the current word being read
        int length = sentence.Length;

        for (int i = 0; i < length; i++)
        {
            if (sentence[i] == ' ' || i == length - 1)
            {
                // If we reached the last character, include it in tempWord
                if (i == length - 1 && sentence[i] != ' ')
                {
                    tempWord += sentence[i];
                }

                // Check if the word matches the oldWord
                if (tempWord == oldWord)
                {
                    result += newWord; // Replace old word with new word
                }
                else
                {
                    result += tempWord; // Keep original word
                }

                result += " "; // Add space after each word
                tempWord = ""; // Reset tempWord for next word
            }
            else
            {
                tempWord += sentence[i]; // Build the word character by character
            }
        }

        return result.TrimEnd(); // Remove the trailing space at the end
    }
}
