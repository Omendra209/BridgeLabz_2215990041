using System;

class BinarySearchFirstLastOccurrence
{
    // Function to find the first occurrence of a target element using Binary Search
    public static int FindFirstOccurrence(int[] arr, int target)
    {
        int left = 0;
        int right = arr.Length - 1;
        int result = -1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            // Check if mid is the target
            if (arr[mid] == target)
            {
                result = mid; // Found the target, but continue searching to the left for first occurrence
                right = mid - 1;
            }
            // Move to the left half if the target is smaller
            else if (arr[mid] > target)
            {
                right = mid - 1;
            }
            // Move to the right half if the target is larger
            else
            {
                left = mid + 1;
            }
        }

        return result;
    }

    // Function to find the last occurrence of a target element using Binary Search
    public static int FindLastOccurrence(int[] arr, int target)
    {
        int left = 0;
        int right = arr.Length - 1;
        int result = -1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            // Check if mid is the target
            if (arr[mid] == target)
            {
                result = mid; // Found the target, but continue searching to the right for last occurrence
                left = mid + 1;
            }
            // Move to the left half if the target is smaller
            else if (arr[mid] > target)
            {
                right = mid - 1;
            }
            // Move to the right half if the target is larger
            else
            {
                left = mid + 1;
            }
        }

        return result;
    }

    // Main method to test the function
    public static void Main(string[] args)
    {
        // Example sorted array
        int[] arr = { 1, 2, 2, 2, 3, 4, 4, 5, 6 };

        // Target value to search for
        int target = 2;

        // Call the FindFirstOccurrence function
        int firstOccurrence = FindFirstOccurrence(arr, target);
        int lastOccurrence = FindLastOccurrence(arr, target);

        // Output the result
        if (firstOccurrence != -1 && lastOccurrence != -1)
        {
            Console.WriteLine("First occurrence of " + target + " is at index: " + firstOccurrence);
            Console.WriteLine("Last occurrence of " + target + " is at index: " + lastOccurrence);
        }
        else
        {
            Console.WriteLine("Target " + target + " not found in the array.");
        }
    }
}
