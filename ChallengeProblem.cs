using System;

class SearchChallenge
{
    // Function to find the first missing positive integer using Linear Search
    public static int FindFirstMissingPositive(int[] arr)
    {
        int n = arr.Length;

        // Step 1: Mark the elements outside the range [1, n] as invalid by setting them to a value greater than n
        for (int i = 0; i < n; i++)
        {
            if (arr[i] <= 0 || arr[i] > n)
            {
                arr[i] = n + 1; // Use n+1 as an invalid value
            }
        }

        // Step 2: Mark the elements that are within the range [1, n] by making the corresponding index negative
        for (int i = 0; i < n; i++)
        {
            int num = Math.Abs(arr[i]);
            if (num <= n)
            {
                arr[num - 1] = -Math.Abs(arr[num - 1]);
            }
        }

        // Step 3: Find the first index with a positive value, which corresponds to the first missing positive integer
        for (int i = 0; i < n; i++)
        {
            if (arr[i] > 0)
            {
                return i + 1; // The first missing positive integer
            }
        }

        // If all elements are marked, return n + 1
        return n + 1;
    }

    // Function to perform Binary Search to find the index of the target in a sorted array
    public static int BinarySearch(int[] arr, int target)
    {
        int left = 0;
        int right = arr.Length - 1;

        // Perform binary search
        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            // Check if target is found
            if (arr[mid] == target)
            {
                return mid; // Return the index of the target
            }
            else if (arr[mid] < target)
            {
                left = mid + 1; // Search in the right half
            }
            else
            {
                right = mid - 1; // Search in the left half
            }
        }

        return -1; // Target not found
    }

    // Main method to test the functions
    public static void Main(string[] args)
    {
        // Example array for finding the first missing positive integer
        int[] arr1 = { 3, 4, -1, 1 };

        // Find the first missing positive integer
        int firstMissingPositive = FindFirstMissingPositive(arr1);
        Console.WriteLine("First missing positive integer is: " + firstMissingPositive);

        // Example array for Binary Search
        int[] arr2 = { -1, 0, 3, 4, 5, 8, 10, 15 };

        // Target value to search for
        int target = 5;

        // Perform binary search
        int targetIndex = BinarySearch(arr2, target);

        // Output the result
        if (targetIndex != -1)
        {
            Console.WriteLine("Target " + target + " found at index: " + targetIndex);
        }
        else
        {
            Console.WriteLine("Target " + target + " not found.");
        }
    }
}
