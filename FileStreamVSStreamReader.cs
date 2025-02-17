using System;
using System.Diagnostics;
using System.IO;
using System.Text;

public class FileReadingComparison
{
    public static void Main()
    {
        string filePath = "large_test_file.txt"; // File to read
        long fileSizeMB = 1000; // Adjust file size (MB)

        // Generate a test file if it doesn't exist
        if (!File.Exists(filePath))
        {
            Console.WriteLine("Generating a large test file...");
            GenerateLargeFile(filePath, fileSizeMB);
            Console.WriteLine("Test file created: " + fileSizeMB + " MB");
        }

        // StreamReader Test
        Stopwatch stopwatch1 = Stopwatch.StartNew();
        ReadWithStreamReader(filePath);
        stopwatch1.Stop();
        Console.WriteLine("StreamReader Time: " + stopwatch1.ElapsedMilliseconds + " ms");

        // FileStream Test
        Stopwatch stopwatch2 = Stopwatch.StartNew();
        ReadWithFileStream(filePath);
        stopwatch2.Stop();
        Console.WriteLine("FileStream Time: " + stopwatch2.ElapsedMilliseconds + " ms");
    }

    // Generate a large test file with repeated text
    private static void GenerateLargeFile(string path, long sizeMB)
    {
        long bytesToWrite = sizeMB * 1024 * 1024;
        string sampleText = "This is a test line for file reading performance comparison.\n";
        byte[] data = Encoding.UTF8.GetBytes(sampleText);

        using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
        {
            for (long written = 0; written < bytesToWrite; written += data.Length)
            {
                fs.Write(data, 0, data.Length);
            }
        }
    }

    // Reading using StreamReader (Character-Based, Slower)
    private static void ReadWithStreamReader(string path)
    {
        using (StreamReader sr = new StreamReader(path))
        {
            while (sr.ReadLine() != null) { }
        }
    }

    // Reading using FileStream (Byte-Based, Faster)
    private static void ReadWithFileStream(string path)
    {
        using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
        {
            byte[] buffer = new byte[4096]; // 4 KB buffer
            while (fs.Read(buffer, 0, buffer.Length) > 0) { }
        }
    }
}
