using System;
using System.Diagnostics;

public class FibonacciComparison
{
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nEnter Fibonacci number index (or 0 to exit):");
            int n;
            if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
                break;

            // Recursive Fibonacci (O(2^N)) - Only for small values
            if (n <= 30)
            {
                Stopwatch stopwatch1 = Stopwatch.StartNew();
                int recursiveResult = FibonacciRecursive(n);
                stopwatch1.Stop();
                Console.WriteLine("Recursive Fibonacci Result: " + recursiveResult);
                Console.WriteLine("Recursive Time: " + stopwatch1.ElapsedMilliseconds + " ms");
            }
            else
            {
                Console.WriteLine("Skipping Recursive Fibonacci (Too Slow for N > 30)");
            }

            // Iterative Fibonacci (O(N))
            Stopwatch stopwatch2 = Stopwatch.StartNew();
            int iterativeResult = FibonacciIterative(n);
            stopwatch2.Stop();
            Console.WriteLine("Iterative Fibonacci Result: " + iterativeResult);
            Console.WriteLine("Iterative Time: " + stopwatch2.ElapsedMilliseconds + " ms");
        }
    }

    // Recursive Fibonacci (O(2^N))
    public static int FibonacciRecursive(int n)
    {
        if (n <= 1) return n;
        return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
    }

    // Iterative Fibonacci (O(N))
    public static int FibonacciIterative(int n)
    {
        if (n <= 1) return n;
        int a = 0, b = 1, sum = 0;
        for (int i = 2; i <= n; i++)
        {
            sum = a + b;
            a = b;
            b = sum;
        }
        return b;
    }
}
