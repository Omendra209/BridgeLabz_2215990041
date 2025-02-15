using System;
using System.Text;

class RemoveDuplicates
{
    // Method to remove duplicate characters while maintaining order
    public static string RemoveDuplicateChars(string input)
    {
        StringBuilder sb = new StringBuilder();
        bool[] seen = new bool[256]; // Array to track seen characters (Assuming ASCII characters)

        // Iterate through each character in the input string
        for (int i = 0; i < input.Length; i++)
        {
            char ch = input[i];

            // If character is not seen before, append to StringBuilder and mark as seen
            if (!seen[ch])
            {
                sb.Append(ch);
                seen[ch] = true;
            }
        }

        return sb.ToString(); // Convert StringBuilder to string and return
    }

    public static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine(); // Read user input

        string result = RemoveDuplicateChars(input); // Remove duplicates

        Console.WriteLine("String after removing duplicates: " + result); // Display result
    }
}
