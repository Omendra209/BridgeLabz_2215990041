using System;
using System.Diagnostics;

public class SortingComparison
{
    // Bubble Sort (O(N²))
    public static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // Swap
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    // Merge Sort (O(N log N))
    public static void MergeSort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int mid = left + (right - left) / 2;

            MergeSort(arr, left, mid);
            MergeSort(arr, mid + 1, right);
            Merge(arr, left, mid, right);
        }
    }

    private static void Merge(int[] arr, int left, int mid, int right)
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;

        int[] leftArr = new int[n1];
        int[] rightArr = new int[n2];

        for (int i = 0; i < n1; i++) leftArr[i] = arr[left + i];
        for (int j = 0; j < n2; j++) rightArr[j] = arr[mid + 1 + j];

        int iIndex = 0, jIndex = 0, k = left;

        while (iIndex < n1 && jIndex < n2)
        {
            if (leftArr[iIndex] <= rightArr[jIndex])
                arr[k++] = leftArr[iIndex++];
            else
                arr[k++] = rightArr[jIndex++];
        }

        while (iIndex < n1) arr[k++] = leftArr[iIndex++];
        while (jIndex < n2) arr[k++] = rightArr[jIndex++];
    }

    // Quick Sort (O(N log N))
    public static void QuickSort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pivot = Partition(arr, low, high);
            QuickSort(arr, low, pivot - 1);
            QuickSort(arr, pivot + 1, high);
        }
    }

    private static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (arr[j] <= pivot)
            {
                i++;
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }

        int swapTemp = arr[i + 1];
        arr[i + 1] = arr[high];
        arr[high] = swapTemp;

        return i + 1;
    }

    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nEnter dataset size (or 0 to exit):");
            int size;
            if (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
                break;

            int minValue = 0, maxValue = size * 10;
            Random rand = new Random();
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
                arr[i] = rand.Next(minValue, maxValue);

            Console.WriteLine("Sorting " + size + " elements...");

            // Bubble Sort (Only if size is small)
            if (size <= 10000)
            {
                int[] bubbleArr = (int[])arr.Clone();
                Stopwatch stopwatch1 = Stopwatch.StartNew();
                BubbleSort(bubbleArr);
                stopwatch1.Stop();
                Console.WriteLine("Bubble Sort Time: " + stopwatch1.ElapsedMilliseconds + " ms");
            }
            else
            {
                Console.WriteLine("Bubble Sort: Skipped (Unfeasible for large data)");
            }

            // Merge Sort
            int[] mergeArr = (int[])arr.Clone();
            Stopwatch stopwatch2 = Stopwatch.StartNew();
            MergeSort(mergeArr, 0, mergeArr.Length - 1);
            stopwatch2.Stop();
            Console.WriteLine("Merge Sort Time: " + stopwatch2.ElapsedMilliseconds + " ms");

            // Quick Sort
            int[] quickArr = (int[])arr.Clone();
            Stopwatch stopwatch3 = Stopwatch.StartNew();
            QuickSort(quickArr, 0, quickArr.Length - 1);
            stopwatch3.Stop();
            Console.WriteLine("Quick Sort Time: " + stopwatch3.ElapsedMilliseconds + " ms");
        }
    }
}
