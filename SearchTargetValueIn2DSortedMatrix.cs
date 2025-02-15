using System;

class BinarySearch2DMatrix
{
    // Function to search for a target value in a 2D sorted matrix using Binary Search
    public static bool SearchMatrix(int[,] matrix, int target)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        int left = 0;
        int right = rows * cols - 1;

        // Perform binary search on the matrix
        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            // Convert mid to 2D coordinates
            int midValue = matrix[mid / cols, mid % cols];

            // Check if mid is the target
            if (midValue == target)
            {
                return true;
            }
            // If the mid value is less than the target, search the right half
            else if (midValue < target)
            {
                left = mid + 1;
            }
            // If the mid value is greater than the target, search the left half
            else
            {
                right = mid - 1;
            }
        }

        return false; // Target not found
    }

    // Main method to test the function
    public static void Main(string[] args)
    {
        // Example 2D matrix where each row is sorted in ascending order
        int[,] matrix = {
            { 1, 4, 7, 11 },
            { 2, 5, 8, 12 },
            { 3, 6, 9, 16 },
            { 10, 13, 14, 17 }
        };

        // Target value to search for
        int target = 5;

        // Call the SearchMatrix function
        bool found = SearchMatrix(matrix, target);

        // Output the result
        if (found)
        {
            Console.WriteLine("Target " + target + " found in the matrix.");
        }
        else
        {
            Console.WriteLine("Target " + target + " not found in the matrix.");
        }
    }
}
