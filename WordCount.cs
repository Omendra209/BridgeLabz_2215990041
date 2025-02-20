using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

class WordCount
{
    static void Main()
    {
        string filePath = "sample.txt";

        try
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("Error: File not found.");
                return;
            }

            Dictionary<string, int> wordCount = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    foreach (string word in Regex.Split(line.ToLower(), @"\W+"))
                    {
                        if (!string.IsNullOrEmpty(word))
                        {
                            if (wordCount.ContainsKey(word))
                                wordCount[word]++;
                            else
                                wordCount[word] = 1;
                        }
                    }
                }
            }

            int totalWords = wordCount.Values.Sum();
            Console.WriteLine("Total Words: " + totalWords);

            Console.WriteLine("\nTop 5 Most Frequent Words:");
            foreach (var item in wordCount.OrderByDescending(kv => kv.Value).Take(5))
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}
