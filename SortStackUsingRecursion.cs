using System;

class Stack
{
    private int[] arr;  // Array to store stack elements
    private int top;    // Pointer to the top element
    private int size;   // Maximum stack size

    // Constructor to initialize the stack
    public Stack(int capacity)
    {
        arr = new int[capacity];
        size = capacity;
        top = -1; // Stack is initially empty
    }

    // Push an element onto the stack manually
    public void Push(int value)
    {
        if (top == size - 1)
        {
            Console.WriteLine("Stack Overflow! Cannot push " + value);
            return;
        }
        top++;
        arr[top] = value;
    }

    // Pop an element from the stack manually
    public int Pop()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack Underflow! Cannot pop.");
            return -1; // Indicating empty stack
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
            return -1; // Stack is empty
        }
        return arr[top];
    }

    // Check if stack is empty
    public bool IsEmpty()
    {
        return top == -1;
    }

    // Display stack elements
    public void Display()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Stack is empty.");
            return;
        }

        Console.Write("Stack (Top to Bottom): ");
        for (int i = top; i >= 0; i--)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }

    // Recursive function to sort the stack
    public void SortStack()
    {
        if (!IsEmpty())
        {
            int temp = Pop();  // Remove the top element
            SortStack();       // Sort the remaining stack
            SortedInsert(temp); // Insert the removed element at the correct position
        }
    }

    // Recursive function to insert an element in sorted order
    private void SortedInsert(int value)
    {
        if (IsEmpty() || Peek() <= value)
        {
            Push(value); // Push the element if the stack is empty or if it's in the right place
        }
        else
        {
            int temp = Pop();   // Remove the top element
            SortedInsert(value); // Recursively insert the new value
            Push(temp);          // Restore the removed element
        }
    }
}

class Program
{
    static void Main()
    {
        Stack stack = new Stack(10); // Stack with capacity 10

        // Push elements into the stack
        stack.Push(30);
        stack.Push(10);
        stack.Push(50);
        stack.Push(20);
        stack.Push(40);

        Console.WriteLine("Original Stack:");
        stack.Display();

        // Sort the stack using recursion
        stack.SortStack();

        Console.WriteLine("\nSorted Stack:");
        stack.Display();
    }
}
