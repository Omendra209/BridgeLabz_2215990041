using System;
using System.Collections.Generic;

class PairWithGivenSum
{
    // Function to check if a pair with the given sum exists
    public static bool HasPairWithSum(int[] arr, int target)
    {
        Dictionary<int, bool> hashMap = new Dictionary<int, bool>();

        for (int i = 0; i < arr.Length; i++)
        {
            int complement = target - arr[i];

            // Check if complement exists in hashMap
            if (hashMap.ContainsKey(complement))
            {
                Console.WriteLine("Pair found: (" + arr[i] + ", " + complement + ")");
                return true;
            }

            // Store the current element in hashMap
            if (!hashMap.ContainsKey(arr[i]))
            {
                hashMap[arr[i]] = true;
            }
        }

        Console.WriteLine("No pair found.");
        return false;
    }

    public static void Main()
    {
        int[] arr = { 8, 4, 1, 6, 10, 5 };
        int target = 9;

        HasPairWithSum(arr, target);
    }
}
