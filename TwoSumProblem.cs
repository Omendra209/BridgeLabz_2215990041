using System;
using System.Collections.Generic;

class TwoSumProblem
{
    // Method to find two indices that add up to the target sum
    public static int[] TwoSum(int[] nums, int target)
    {
        // Dictionary to store numbers and their indices
        Dictionary<int, int> numIndexMap = new Dictionary<int, int>();

        // Traverse the array
        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            // Check if complement exists in the dictionary
            if (numIndexMap.ContainsKey(complement))
            {
                return new int[] { numIndexMap[complement], i };
            }

            // Store the index of the current number
            numIndexMap[nums[i]] = i;
        }

        return new int[] { -1, -1 }; // Return -1 if no valid pair is found
    }

    public static void Main()
    {
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;

        int[] result = TwoSum(nums, target);

        if (result[0] != -1)
        {
            Console.WriteLine("Indices: " + result[0] + " and " + result[1]);
        }
        else
        {
            Console.WriteLine("No valid pair found.");
        }
    }
}
