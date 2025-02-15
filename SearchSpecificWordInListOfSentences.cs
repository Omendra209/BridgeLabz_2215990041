using System;

class LinearSearchWord
{
    // Function to perform Linear Search to find a sentence containing the specific word
    public static int SearchSentence(string[] sentences, string word)
    {
        // Iterate through each sentence in the array
        for (int i = 0; i < sentences.Length; i++)
        {
            // Check if the current sentence contains the word
            if (sentences[i].Contains(word))
            {
                return i; // Return the index of the first matching sentence
            }
        }

        return -1; // Return -1 if the word is not found in any sentence
    }

    // Main method to test the function
    public static void Main(string[] args)
    {
        // Array of sentences
        string[] sentences = {
            "I am learning to code.",
            "This is a linear search problem.",
            "Linear search can be useful.",
            "I am practicing algorithms."
        };

        // Word to search for
        string word = "linear";

        // Call the SearchSentence function and store the result
        int index = SearchSentence(sentences, word);

        // Output the result
        if (index != -1)
        {
            Console.WriteLine("The first sentence containing the word is at index: " + index);
            Console.WriteLine("Sentence: " + sentences[index]);
        }
        else
        {
            Console.WriteLine("The word was not found in any sentence.");
        }
    }
}
