using System;

class StockSpan
{
    private int[] arr;  // Stack array to store indices
    private int top;    // Pointer to the top of the stack
    private int size;   // Maximum stack size

    // Constructor to initialize the stack
    public StockSpan(int capacity)
    {
        arr = new int[capacity];
        size = capacity;
        top = -1; // Stack is initially empty
    }

    // Push an element onto the stack
    public void Push(int value)
    {
        if (top == size - 1)
        {
            Console.WriteLine("Stack Overflow!");
            return;
        }
        top++;
        arr[top] = value;
    }

    // Pop an element from the stack
    public int Pop()
    {
        if (top == -1)
        {
            return -1; // Indicates stack underflow
        }
        int value = arr[top];
        top--;
        return value;
    }

    // Peek the top element without removing it
    public int Peek()
    {
        if (top == -1)
        {
            return -1; // Indicates empty stack
        }
        return arr[top];
    }

    // Check if stack is empty
    public bool IsEmpty()
    {
        return top == -1;
    }

    // Function to calculate stock span
    public static void CalculateStockSpan(int[] prices, int[] span)
    {
        int n = prices.Length;
        StockSpan stack = new StockSpan(n); // Stack to store indices

        // Process each stock price
        for (int i = 0; i < n; i++)
        {
            // Remove elements from stack if they are smaller than or equal to current price
            while (!stack.IsEmpty() && prices[stack.Peek()] <= prices[i])
            {
                stack.Pop();
            }

            // If stack is empty, span is i+1 (all previous days had a lower price)
            if (stack.IsEmpty())
            {
                span[i] = i + 1;
            }
            else
            {
                span[i] = i - stack.Peek();
            }

            // Push current index onto the stack
            stack.Push(i);
        }
    }

    public static void Main()
    {
        int[] prices = { 100, 80, 60, 70, 60, 75, 85 };
        int[] span = new int[prices.Length];

        Console.WriteLine("Stock Prices:");
        foreach (int price in prices)
        {
            Console.Write(price + " ");
        }

        // Compute stock spans
        CalculateStockSpan(prices, span);

        Console.WriteLine("\n\nStock Spans:");
        foreach (int s in span)
        {
            Console.Write(s + " ");
        }
    }
}
