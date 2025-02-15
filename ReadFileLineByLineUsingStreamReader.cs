using System;
using System.IO;

class ReadFileExample
{
    public static void Main()
    {
        Console.Write("Enter the file path: ");
        string filePath = Console.ReadLine(); // Get the file path from user

        try
        {
            // Open the file using StreamReader
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null) // Read each line until EOF
                {
                    Console.WriteLine(line); // Print the line to console
                }
            }
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
