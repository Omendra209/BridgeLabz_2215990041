using System;

class InsertionSort
{
    // Method to perform Insertion Sort
    public static void SortEmployeeIDs(int[] employeeIDs)
    {
        int n = employeeIDs.Length;

        // Iterate through the array starting from index 1
        for (int i = 1; i < n; i++)
        {
            int key = employeeIDs[i]; // Pick the current element
            int j = i - 1;

            // Move elements of sorted part to make space for key
            while (j >= 0 && employeeIDs[j] > key)
            {
                employeeIDs[j + 1] = employeeIDs[j]; // Shift element to the right
                j--;
            }

            // Insert the key at the correct position
            employeeIDs[j + 1] = key;
        }
    }

    public static void Main()
    {
        // Example employee IDs array
        int[] employeeIDs = { 104, 102, 109, 101, 107, 105 };

        Console.WriteLine("Original Employee IDs:");
        foreach (int id in employeeIDs)
        {
            Console.Write(id + " ");
        }

        // Sort the employee IDs using Insertion Sort
        SortEmployeeIDs(employeeIDs);

        Console.WriteLine("\nSorted Employee IDs:");
        foreach (int id in employeeIDs)
        {
            Console.Write(id + " ");
        }
    }
}
