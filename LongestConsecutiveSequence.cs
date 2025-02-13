using System;
using System.Collections.Generic;

class LongestConsecutiveSequence
{
    // Function to find the length of the longest consecutive sequence
    public static int FindLongestConsecutive(int[] arr)
    {
        if (arr.Length == 0)
        {
            return 0;
        }

        HashSet<int> numbers = new HashSet<int>();
        int longestStreak = 0;

        // Store all elements in a HashSet
        for (int i = 0; i < arr.Length; i++)
        {
            numbers.Add(arr[i]);
        }

        // Iterate through the array and check for the start of a sequence
        for (int i = 0; i < arr.Length; i++)
        {
            if (!numbers.Contains(arr[i] - 1)) // Check if it's the start of a sequence
            {
                int currentNum = arr[i];
                int currentStreak = 1;

                // Count the length of the consecutive sequence
                while (numbers.Contains(currentNum + 1))
                {
                    currentNum++;
                    currentStreak++;
                }

                // Update the longest streak found
                if (currentStreak > longestStreak)
                {
                    longestStreak = currentStreak;
                }
            }
        }

        return longestStreak;
    }

    public static void Main()
    {
        int[] arr = { 100, 4, 200, 1, 3, 2, 5, 6 };
        int result = FindLongestConsecutive(arr);
        Console.WriteLine("Length of the longest consecutive sequence: " + result);
    }
}
