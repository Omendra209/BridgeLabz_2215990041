using System;
using System.IO;

class UserInputToFile
{
    public static void Main()
    {
        Console.Write("Enter the file path to save your input: ");
        string filePath = Console.ReadLine(); // Get file path from user

        Console.WriteLine("Enter your text (Type 'EXIT' to stop):");

        try
        {
            // Open StreamWriter to write to the file
            using (StreamWriter writer = new StreamWriter(filePath, false)) // Overwrite mode
            {
                while (true)
                {
                    string input = Console.ReadLine(); // Read user input
                    if (input.ToUpper() == "EXIT") // Stop writing on 'EXIT'
                        break;

                    writer.WriteLine(input); // Write input to file
                }
            }

            Console.WriteLine("Your input has been successfully saved to the file.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("Error writing to the file: " + ex.Message);
        }
    }
}
