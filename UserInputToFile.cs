using System;
using System.IO;

class UserInputToFile
{
    static void Main()
    {
        string filePath = "user_data.txt";

        try
        {
            Console.WriteLine("Enter your name:");
            string name = ReadFromConsole();

            Console.WriteLine("Enter your age:");
            string age = ReadFromConsole();

            Console.WriteLine("Enter your favorite programming language:");
            string language = ReadFromConsole();

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Name: " + name);
                writer.WriteLine("Age: " + age);
                writer.WriteLine("Favorite Programming Language: " + language);
            }

            Console.WriteLine("Data saved successfully in " + filePath);
        }
        catch (IOException ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }

    static string ReadFromConsole()
    {
        using (StreamReader reader = new StreamReader(Console.OpenStandardInput()))
        {
            return reader.ReadLine();
        }
    }
}
