using System;
using System.Diagnostics;
using System.IO;

class BufferedFileCopy
{
    static void Main()
    {
        string sourceFilePath = "largefile.dat";
        string bufferedDestination = "buffered_copy.dat";
        string unbufferedDestination = "unbuffered_copy.dat";

        if (!File.Exists(sourceFilePath))
        {
            Console.WriteLine("Error: Source file does not exist.");
            return;
        }

        Stopwatch stopwatch = new Stopwatch();

        stopwatch.Start();
        CopyWithBufferedStream(sourceFilePath, bufferedDestination);
        stopwatch.Stop();
        Console.WriteLine("Buffered Stream Copy Time: " + stopwatch.ElapsedMilliseconds + " ms");

        stopwatch.Reset();

        stopwatch.Start();
        CopyWithFileStream(sourceFilePath, unbufferedDestination);
        stopwatch.Stop();
        Console.WriteLine("Unbuffered Stream Copy Time: " + stopwatch.ElapsedMilliseconds + " ms");
    }

    static void CopyWithBufferedStream(string source, string destination)
    {
        using (FileStream fsRead = new FileStream(source, FileMode.Open, FileAccess.Read))
        using (FileStream fsWrite = new FileStream(destination, FileMode.Create, FileAccess.Write))
        using (BufferedStream bsRead = new BufferedStream(fsRead, 4096))
        using (BufferedStream bsWrite = new BufferedStream(fsWrite, 4096))
        {
            byte[] buffer = new byte[4096];
            int bytesRead;
            while ((bytesRead = bsRead.Read(buffer, 0, buffer.Length)) > 0)
            {
                bsWrite.Write(buffer, 0, bytesRead);
            }
        }
    }

    static void CopyWithFileStream(string source, string destination)
    {
        using (FileStream fsRead = new FileStream(source, FileMode.Open, FileAccess.Read))
        using (FileStream fsWrite = new FileStream(destination, FileMode.Create, FileAccess.Write))
        {
            byte[] buffer = new byte[4096];
            int bytesRead;
            while ((bytesRead = fsRead.Read(buffer, 0, buffer.Length)) > 0)
            {
                fsWrite.Write(buffer, 0, bytesRead);
            }
        }
    }
}
