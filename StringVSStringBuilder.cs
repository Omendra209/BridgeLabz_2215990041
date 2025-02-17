using System;
using System.Diagnostics;
using System.Text;

public class StringConcatenationPerformance
{
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nEnter the number of concatenations (or 0 to exit):");
            int n;
            if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
                break;

            string sampleText = "A";

            // String Concatenation (O(N²))
            Stopwatch stopwatch1 = Stopwatch.StartNew();
            string resultString = "";
            for (int i = 0; i < n; i++)
            {
                resultString += sampleText; // Inefficient
            }
            stopwatch1.Stop();
            Console.WriteLine("String Concatenation Time: " + stopwatch1.ElapsedMilliseconds + " ms");

            // StringBuilder Concatenation (O(N))
            Stopwatch stopwatch2 = Stopwatch.StartNew();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                sb.Append(sampleText);
            }
            stopwatch2.Stop();
            Console.WriteLine("StringBuilder Time: " + stopwatch2.ElapsedMilliseconds + " ms");
        }
    }
}
