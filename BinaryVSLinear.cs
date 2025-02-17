using System;
using System.Collections.Generic;
using System.Diagnostics;

public class SearchComparison
{
    public static int LinearSearch(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target)
            {
                return i; // Found
            }
        }
        return -1; // Not found
    }

    public static int BinarySearch(int[] arr, int target)
    {
        int left = 0, right = arr.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (arr[mid] == target)
                return mid;
            if (arr[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return -1;
    }

    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nEnter the size of array (or type 0 to exit):");
            int size;
            if (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
                break;

            int minValue = 0, maxValue = size * 10; // Adjust range
            Random rand = new Random();
            int[] arr = new int[size];

            // Generate random numbers
            for (int i = 0; i < size; i++)
                arr[i] = rand.Next(minValue, maxValue);

            // Pick a random target
            int target = arr[rand.Next(size)];

            Console.WriteLine("Searching for target: " + target);

            // Measure Linear Search Time
            Stopwatch stopwatch1 = Stopwatch.StartNew();
            int linearResult = LinearSearch(arr, target);
            stopwatch1.Stop();

            if (linearResult != -1)
                Console.WriteLine("Linear Search: Found at index " + linearResult);
            else
                Console.WriteLine("Linear Search: Not found");

            Console.WriteLine("Linear Search time: " + stopwatch1.ElapsedMilliseconds + " ms");

            // Measure Sorting Time
            Console.WriteLine("Sorting array...");
            Stopwatch sortTimer = Stopwatch.StartNew();
            Array.Sort(arr); // Sorting (O(N log N))
            sortTimer.Stop();
            Console.WriteLine("Sorting time: " + sortTimer.ElapsedMilliseconds + " ms");

            // Measure Binary Search Time
            Stopwatch stopwatch2 = Stopwatch.StartNew();
            int binaryResult = BinarySearch(arr, target);
            stopwatch2.Stop();

            if (binaryResult != -1)
                Console.WriteLine("Binary Search: Found at index " + binaryResult);
            else
                Console.WriteLine("Binary Search: Not found");

            Console.WriteLine("Binary Search time (excluding sorting): " + stopwatch2.ElapsedMilliseconds + " ms");

            // Total Binary Search Time (Sorting + Search)
            long totalBinaryTime = sortTimer.ElapsedMilliseconds + stopwatch2.ElapsedMilliseconds;
            Console.WriteLine("Total Binary Search time (including sorting): " + totalBinaryTime + " ms");
        }
    }
}
