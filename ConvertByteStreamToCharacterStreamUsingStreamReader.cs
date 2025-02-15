using System;
using System.IO;
using System.Text;

class ByteToCharacterStream
{
    public static void Main()
    {
        Console.Write("Enter the file path: ");
        string filePath = Console.ReadLine(); // Get file path from user

        try
        {
            // Open a FileStream in read mode
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                // Use StreamReader with a specified encoding (UTF-8)
                using (StreamReader reader = new StreamReader(fileStream, Encoding.UTF8))
                {
                    string content = reader.ReadToEnd(); // Read the entire file content
                    Console.WriteLine("File Content:\n" + content);
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
