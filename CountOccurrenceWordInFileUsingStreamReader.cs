using System;
using System.IO;

class WordCount
{
    public static void Main()
    {
        Console.Write("Enter the file path: ");
        string filePath = Console.ReadLine(); // Get the file path from user

        Console.Write("Enter the word to search: ");
        string searchWord = Console.ReadLine(); // Get the word to count

        int count = 0;

        try
        {
            // Open the file using StreamReader
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null) // Read each line
                {
                    // Split line into words (ignoring case and punctuation)
                    string[] words = line.Split(new char[] { ' ', '.', ',', '!', '?', ';', ':' }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (string word in words)
                    {
                        if (word.Equals(searchWord, StringComparison.OrdinalIgnoreCase))
                        {
                            count++; // Increment count if match is found
                        }
                    }
                }
            }

            Console.WriteLine("The word '" + searchWord + "' appears " + count + " times in the file.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Error: The file was not found.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("Error reading the file: " + ex.Message);
        }
    }
}
