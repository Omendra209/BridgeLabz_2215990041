using System;
using System.Collections.Generic;

class ZeroSumSubarrays
{
    // Function to find all subarrays with zero sum
    public static void FindZeroSumSubarrays(int[] arr)
    {
        Dictionary<int, List<int>> hashMap = new Dictionary<int, List<int>>();
        int sum = 0;

        // Add an initial value to handle cases where subarray starts from index 0
        hashMap[0] = new List<int> { -1 };

        Console.WriteLine("Subarrays with zero sum:");

        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i]; // Calculate cumulative sum

            // If sum already exists in hashMap, it means a subarray with zero sum is found
            if (hashMap.ContainsKey(sum))
            {
                foreach (int startIdx in hashMap[sum])
                {
                    Console.WriteLine($"[{startIdx + 1}, {i}]");
                }
            }

            // Store sum in hashMap
            if (!hashMap.ContainsKey(sum))
            {
                hashMap[sum] = new List<int>();
            }
            hashMap[sum].Add(i);
        }
    }

    public static void Main()
    {
        int[] arr = { 3, 4, -7, 3, 1, 3, 1, -4, -2, -2 };
        FindZeroSumSubarrays(arr);
    }
}
