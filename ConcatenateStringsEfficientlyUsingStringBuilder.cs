using System;
using System.Text;

class StringConcatenation
{
    // Method to concatenate strings efficiently using StringBuilder
    public static string ConcatenateStrings(string[] words)
    {
        StringBuilder sb = new StringBuilder(); // Create a StringBuilder instance

        // Append each string from the array to the StringBuilder
        for (int i = 0; i < words.Length; i++)
        {
            sb.Append(words[i]);

            // Add a space between words (optional)
            if (i < words.Length - 1)
            {
                sb.Append(" ");
            }
        }

        return sb.ToString(); // Convert StringBuilder to string and return
    }

    public static void Main()
    {
        Console.Write("Enter the number of words: ");
        int n = Convert.ToInt32(Console.ReadLine()); // Read number of words

        string[] words = new string[n]; // Create an array of strings

        Console.WriteLine("Enter the words:");
        for (int i = 0; i < n; i++)
        {
            words[i] = Console.ReadLine(); // Read each word
        }

        string result = ConcatenateStrings(words); // Concatenate words

        Console.WriteLine("Concatenated String: " + result); // Display result
    }
}
