using System;

class Program
{
    static void Main()
    {
        // Define input string
        string input = "Hello World";

        // Call method to count vowels and consonants
        CountVowelsAndConsonants(input);
    }

    static void CountVowelsAndConsonants(string input)
    {
        // Initialize vowel and consonant counters
        int vowels = 0, consonants = 0;

        // Convert input string to lowercase to handle case insensitivity
        input = input.ToLower();

        // Iterate through each character in the string
        foreach (char ch in input)
        {
            // Check if the character is a letter
            if (ch >= 'a' && ch <= 'z')
            {
                // Check if the character is a vowel
                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                {
                    vowels++; // Increment vowel count
                }
                else
                {
                    consonants++; // Increment consonant count
                }
            }
        }

        // Print the count of vowels and consonants
        Console.WriteLine("Vowels: " + vowels);
        Console.WriteLine("Consonants: " + consonants);
    }
}
