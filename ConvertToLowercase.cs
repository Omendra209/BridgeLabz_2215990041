﻿using System;
using System.IO;
using System.Text;

class ConvertToLowercase
{
    static void Main()
    {
        string sourceFilePath = "source.txt";
        string destinationFilePath = "converted.txt";

        try
        {
            if (!File.Exists(sourceFilePath))
            {
                Console.WriteLine("Error: Source file does not exist.");
                return;
            }

            using (FileStream fsRead = new FileStream(sourceFilePath, FileMode.Open, FileAccess.Read))
            using (BufferedStream bsRead = new BufferedStream(fsRead))
            using (StreamReader reader = new StreamReader(bsRead, Encoding.UTF8))
            using (FileStream fsWrite = new FileStream(destinationFilePath, FileMode.Create, FileAccess.Write))
            using (BufferedStream bsWrite = new BufferedStream(fsWrite))
            using (StreamWriter writer = new StreamWriter(bsWrite, Encoding.UTF8))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    writer.WriteLine(line.ToLower());
                }
            }

            Console.WriteLine("File converted successfully.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}
