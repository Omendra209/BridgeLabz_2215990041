using System;
using System.IO;
using System.IO.Pipes;
using System.Text;
using System.Threading;

class PipedStreamExample
{
    static void Main()
    {
        using (AnonymousPipeServerStream pipeServer = new AnonymousPipeServerStream(PipeDirection.Out, HandleInheritability.Inheritable))
        using (AnonymousPipeClientStream pipeClient = new AnonymousPipeClientStream(PipeDirection.In, pipeServer.ClientSafePipeHandle))
        {
            Thread writerThread = new Thread(() => WriteData(pipeServer));
            Thread readerThread = new Thread(() => ReadData(pipeClient));

            writerThread.Start();
            readerThread.Start();

            writerThread.Join();
            readerThread.Join();
        }
    }

    static void WriteData(PipeStream pipe)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(pipe, Encoding.UTF8, 1024, true))
            {
                for (int i = 1; i <= 5; i++)
                {
                    string message = "Message " + i;
                    writer.WriteLine(message);
                    writer.Flush();
                    Thread.Sleep(500);
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("Writer error: " + ex.Message);
        }
    }

    static void ReadData(PipeStream pipe)
    {
        try
        {
            using (StreamReader reader = new StreamReader(pipe, Encoding.UTF8, true, 1024, true))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine("Received: " + line);
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("Reader error: " + ex.Message);
        }
    }
}
