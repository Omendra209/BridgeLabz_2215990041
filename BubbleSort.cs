using System;

class BubbleSort
{
    // Method to perform Bubble Sort
    public static void SortMarks(int[] marks)
    {
        int n = marks.Length;

        // Outer loop for passes
        for (int i = 0; i < n - 1; i++)
        {
            bool swapped = false; // Optimization to stop if already sorted

            // Inner loop for comparing adjacent elements
            for (int j = 0; j < n - i - 1; j++)
            {
                if (marks[j] > marks[j + 1]) // Swap if left element is greater
                {
                    int temp = marks[j];
                    marks[j] = marks[j + 1];
                    marks[j + 1] = temp;

                    swapped = true;
                }
            }

            // If no swaps occurred, array is already sorted
            if (!swapped)
                break;
        }
    }

    public static void Main()
    {
        // Example marks array
        int[] marks = { 85, 72, 90, 68, 88, 79 };

        Console.WriteLine("Original Marks:");
        foreach (int mark in marks)
        {
            Console.Write(mark + " ");
        }

        // Sort the marks using Bubble Sort
        SortMarks(marks);

        Console.WriteLine("\nSorted Marks:");
        foreach (int mark in marks)
        {
            Console.Write(mark + " ");
        }
    }
}
