using System;
using System.IO;

class ImageToByteArray
{
    static void Main()
    {
        string sourceImagePath = "source_image.jpg";
        string destinationImagePath = "copied_image.jpg";

        try
        {
            byte[] imageData = ConvertImageToByteArray(sourceImagePath);
            File.WriteAllBytes(destinationImagePath, imageData);

            Console.WriteLine("Image copied successfully.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }

    static byte[] ConvertImageToByteArray(string filePath)
    {
        if (!File.Exists(filePath))
        {
            throw new FileNotFoundException("Source image not found.");
        }

        using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
        using (MemoryStream ms = new MemoryStream())
        {
            fs.CopyTo(ms);
            return ms.ToArray();
        }
    }
}
