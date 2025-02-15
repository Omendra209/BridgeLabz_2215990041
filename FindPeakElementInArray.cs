using System;

class BinarySearchPeakElement
{
    // Function to find the peak element using Binary Search
    public static int FindPeakElement(int[] arr)
    {
        int left = 0;
        int right = arr.Length - 1;

        // Perform binary search to find a peak element
        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            // Check if mid is a peak element
            if ((mid == 0 || arr[mid] > arr[mid - 1]) && (mid == arr.Length - 1 || arr[mid] > arr[mid + 1]))
            {
                return mid; // Mid is the peak element
            }

            // If the element on the right of mid is greater, move right
            else if (mid < arr.Length - 1 && arr[mid] < arr[mid + 1])
            {
                left = mid + 1;
            }
            // If the element on the left of mid is greater, move left
            else
            {
                right = mid - 1;
            }
        }

        return -1; // This should never be reached if the array has a peak element
    }

    // Main method to test the function
    public static void Main(string[] args)
    {
        // Example array
        int[] arr = { 1, 3, 20, 4, 1, 0 };

        // Call the FindPeakElement function
        int index = FindPeakElement(arr);

        // Output the result
        if (index != -1)
        {
            Console.WriteLine("The peak element is at index: " + index);
            Console.WriteLine("The peak element is: " + arr[index]);
        }
        else
        {
            Console.WriteLine("No peak element found.");
        }
    }
}
