using System;

class CircularTour
{
    private int[] petrolQueue;
    private int[] distanceQueue;
    private int front, rear, size, capacity;

    // Constructor to initialize queue
    public CircularTour(int capacity)
    {
        this.capacity = capacity;
        petrolQueue = new int[capacity];
        distanceQueue = new int[capacity];
        front = 0;
        rear = -1;
        size = 0;
    }

    // Enqueue petrol and distance
    public void Enqueue(int petrol, int distance)
    {
        if (size == capacity)
        {
            Console.WriteLine("Queue is full!");
            return;
        }
        rear = (rear + 1) % capacity;
        petrolQueue[rear] = petrol;
        distanceQueue[rear] = distance;
        size++;
    }

    // Dequeue front element
    public void Dequeue()
    {
        if (size == 0)
        {
            Console.WriteLine("Queue is empty!");
            return;
        }
        front = (front + 1) % capacity;
        size--;
    }

    // Get front petrol
    public int GetFrontPetrol()
    {
        return petrolQueue[front];
    }

    // Get front distance
    public int GetFrontDistance()
    {
        return distanceQueue[front];
    }

    // Check if queue is empty
    public bool IsEmpty()
    {
        return size == 0;
    }

    // Function to find the starting petrol pump index
    public static int FindStartingPoint(int[] petrol, int[] distance)
    {
        int n = petrol.Length;
        int start = 0;
        int surplus = 0, deficit = 0;

        for (int i = 0; i < n; i++)
        {
            surplus += petrol[i] - distance[i];

            // If deficit occurs, reset start to next pump
            if (surplus < 0)
            {
                start = i + 1;
                deficit += surplus;
                surplus = 0;
            }
        }

        // If total petrol is greater than or equal to total distance, return start index
        return (surplus + deficit >= 0) ? start : -1;
    }

    public static void Main()
    {
        int[] petrol = { 4, 6, 7, 4 };
        int[] distance = { 6, 5, 3, 5 };

        Console.WriteLine("Finding the starting petrol pump index...");
        int result = FindStartingPoint(petrol, distance);

        if (result != -1)
        {
            Console.WriteLine("Start at petrol pump: " + result);
        }
        else
        {
            Console.WriteLine("No solution exists!");
        }
    }
}
