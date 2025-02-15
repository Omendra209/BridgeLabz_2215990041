using System;

class BinarySearchRotationPoint
{
    // Function to find the index of the smallest element in a rotated sorted array
    public static int FindRotationPoint(int[] arr)
    {
        int left = 0;
        int right = arr.Length - 1;

        // Perform binary search to find the rotation point
        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            // Check if mid is the rotation point
            if (mid > 0 && arr[mid] < arr[mid - 1])
            {
                return mid; // Mid is the smallest element
            }

            // Determine which half to search
            if (arr[mid] >= arr[left])
            {
                // Left half is sorted, so the rotation point is in the right half
                left = mid + 1;
            }
            else
            {
                // Right half is sorted, so the rotation point is in the left half
                right = mid - 1;
            }
        }

        return 0; // In case the array is not rotated (it's already sorted)
    }

    // Main method to test the function
    public static void Main(string[] args)
    {
        // Example rotated sorted array
        int[] arr = { 6, 7, 9, 15, 19, 2, 3 };

        // Call the FindRotationPoint function
        int index = FindRotationPoint(arr);

        // Output the result
        Console.WriteLine("The rotation point is at index: " + index);
        Console.WriteLine("The smallest element is: " + arr[index]);
    }
}
