using System;

class SlidingWindowMax
{
    private int[] deque; // Array to implement deque
    private int front, rear; // Pointers for front and rear
    private int size; // Maximum size of deque

    // Constructor to initialize the deque
    public SlidingWindowMax(int capacity)
    {
        deque = new int[capacity];
        size = capacity;
        front = 0;
        rear = -1;
    }

    // Insert an index at the rear
    public void InsertRear(int index)
    {
        if (rear == size - 1)
        {
            Console.WriteLine("Deque Overflow!");
            return;
        }
        rear++;
        deque[rear] = index;
    }

    // Remove element from the front
    public void RemoveFront()
    {
        if (front > rear)
        {
            Console.WriteLine("Deque Underflow!");
            return;
        }
        front++;
    }

    // Remove element from the rear
    public void RemoveRear()
    {
        if (front > rear)
        {
            Console.WriteLine("Deque Underflow!");
            return;
        }
        rear--;
    }

    // Get the front element
    public int GetFront()
    {
        if (front > rear)
        {
            return -1; // Indicates empty deque
        }
        return deque[front];
    }

    // Get the rear element
    public int GetRear()
    {
        if (front > rear)
        {
            return -1; // Indicates empty deque
        }
        return deque[rear];
    }

    // Check if deque is empty
    public bool IsEmpty()
    {
        return front > rear;
    }

    // Function to find the maximum in each sliding window
    public static void FindSlidingWindowMax(int[] arr, int k)
    {
        int n = arr.Length;
        SlidingWindowMax deque = new SlidingWindowMax(n);

        Console.WriteLine("Sliding Window Maximums:");

        for (int i = 0; i < n; i++)
        {
            // Remove elements that are out of this window
            if (!deque.IsEmpty() && deque.GetFront() <= i - k)
            {
                deque.RemoveFront();
            }

            // Remove elements from rear that are smaller than current element
            while (!deque.IsEmpty() && arr[deque.GetRear()] <= arr[i])
            {
                deque.RemoveRear();
            }

            // Add the current index at the rear
            deque.InsertRear(i);

            // Print the maximum for this window
            if (i >= k - 1)
            {
                Console.Write(arr[deque.GetFront()] + " ");
            }
        }
    }

    public static void Main()
    {
        int[] arr = { 1, 3, -1, -3, 5, 3, 6, 7 };
        int k = 3;

        Console.WriteLine("Input Array:");
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine("\n");
        FindSlidingWindowMax(arr, k);
    }
}
