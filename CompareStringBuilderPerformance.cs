using System;
using System.Text;
using System.Diagnostics;

class StringPerformanceComparison
{
    // Method to concatenate strings using String
    public static string ConcatenateUsingString(int n)
    {
        string result = ""; // Start with an empty string
        for (int i = 0; i < n; i++)
        {
            result += "Hello "; // Concatenation (Creates new strings each time)
        }
        return result;
    }

    // Method to concatenate strings using StringBuilder
    public static string ConcatenateUsingStringBuilder(int n)
    {
        StringBuilder sb = new StringBuilder(); // Create StringBuilder instance
        for (int i = 0; i < n; i++)
        {
            sb.Append("Hello "); // Append to StringBuilder (Efficient)
        }
        return sb.ToString();
    }

    public static void Main()
    {
        Console.Write("Enter the number of repetitions: ");
        int n = Convert.ToInt32(Console.ReadLine()); // Read user input

        Stopwatch stopwatch = new Stopwatch(); // Create a Stopwatch instance

        // Measure time for String concatenation
        stopwatch.Start();
        string result1 = ConcatenateUsingString(n);
        stopwatch.Stop();
        Console.WriteLine("Time taken using String concatenation: " + stopwatch.ElapsedMilliseconds + " ms");

        // Measure time for StringBuilder concatenation
        stopwatch.Reset(); // Reset stopwatch
        stopwatch.Start();
        string result2 = ConcatenateUsingStringBuilder(n);
        stopwatch.Stop();
        Console.WriteLine("Time taken using StringBuilder: " + stopwatch.ElapsedMilliseconds + " ms");
    }
}
