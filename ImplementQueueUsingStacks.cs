using System;

class Stack
{
    private int[] arr; // Array to store stack elements
    private int top;   // Pointer to track the top of the stack
    private int size;  // Maximum size of the stack

    // Constructor to initialize stack
    public Stack(int capacity)
    {
        arr = new int[capacity];
        size = capacity;
        top = -1; // Stack is empty initially
    }

    // Manually push an element into the stack
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

    // Manually pop an element from the stack
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

    // Check if the stack is empty
    public bool IsEmpty()
    {
        return top == -1;
    }

    // Get the top element without removing it
    public int Peek()
    {
        if (top == -1)
        {
            return -1; // Stack is empty
        }
        return arr[top];
    }
}

class QueueUsingStacks
{
    private Stack stack1; // Stack used for enqueue operation
    private Stack stack2; // Stack used for dequeue operation

    // Constructor to initialize stacks with a fixed capacity
    public QueueUsingStacks(int capacity)
    {
        stack1 = new Stack(capacity);
        stack2 = new Stack(capacity);
    }

    // Enqueue operation: Push element onto stack1
    public void Enqueue(int item)
    {
        stack1.Push(item);
        Console.WriteLine("Enqueued: " + item);
    }

    // Dequeue operation: Move elements from stack1 to stack2 if empty, then pop from stack2
    public int Dequeue()
    {
        if (stack1.IsEmpty() && stack2.IsEmpty())
        {
            Console.WriteLine("Queue is empty.");
            return -1; // Indicating empty queue
        }

        // If stack2 is empty, move all elements from stack1 to stack2
        if (stack2.IsEmpty())
        {
            while (!stack1.IsEmpty())
            {
                stack2.Push(stack1.Pop());
            }
        }

        return stack2.Pop(); // Pop from stack2
    }

    // Display queue elements from front to rear
    public void DisplayQueue()
    {
        if (stack1.IsEmpty() && stack2.IsEmpty())
        {
            Console.WriteLine("Queue is empty.");
            return;
        }

        Console.Write("Queue elements (Front to Rear): ");

        // Display elements from stack2 (as it holds the front elements in correct order)
        Stack tempStack = new Stack(100);
        while (!stack2.IsEmpty())
        {
            int value = stack2.Pop();
            Console.Write(value + " ");
            tempStack.Push(value);
        }

        // Restore stack2 elements back
        while (!tempStack.IsEmpty())
        {
            stack2.Push(tempStack.Pop());
        }

        // Display stack1 elements (in order)
        while (!stack1.IsEmpty())
        {
            tempStack.Push(stack1.Pop());
        }

        while (!tempStack.IsEmpty())
        {
            int value = tempStack.Pop();
            Console.Write(value + " ");
            stack1.Push(value);
        }

        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        QueueUsingStacks queue = new QueueUsingStacks(100); // Queue with capacity 100

        while (true)
        {
            Console.WriteLine("\nQueue Using Two Stacks:");
            Console.WriteLine("1. Enqueue");
            Console.WriteLine("2. Dequeue");
            Console.WriteLine("3. Display Queue");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    Console.Write("Enter value to enqueue: ");
                    int value;
                    if (int.TryParse(Console.ReadLine(), out value))
                    {
                        queue.Enqueue(value);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input.");
                    }
                    break;

                case 2:
                    int dequeuedValue = queue.Dequeue();
                    if (dequeuedValue != -1)
                    {
                        Console.WriteLine("Dequeued: " + dequeuedValue);
                    }
                    break;

                case 3:
                    queue.DisplayQueue();
                    break;

                case 4:
                    return;

                default:
                    Console.WriteLine("Invalid choice! Please try again.");
                    break;
            }
        }
    }
}
