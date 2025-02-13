using System;
using System.Collections.Generic;

// Node class for Linked List (for separate chaining)
class HashNode
{
    public int Key;
    public int Value;
    public HashNode Next;

    public HashNode(int key, int value)
    {
        Key = key;
        Value = value;
        Next = null;
    }
}

// Custom Hash Map class
class CustomHashMap
{
    private int capacity;
    private List<HashNode> bucketArray;

    public CustomHashMap(int size)
    {
        capacity = size;
        bucketArray = new List<HashNode>(capacity);

        for (int i = 0; i < capacity; i++)
        {
            bucketArray.Add(null);
        }
    }

    // Hash function to compute index
    private int GetBucketIndex(int key)
    {
        return Math.Abs(key) % capacity;
    }

    // Insert key-value pair
    public void Insert(int key, int value)
    {
        int index = GetBucketIndex(key);
        HashNode head = bucketArray[index];

        // Check if key already exists, update value if found
        while (head != null)
        {
            if (head.Key == key)
            {
                head.Value = value;
                return;
            }
            head = head.Next;
        }

        // Insert new node at head (separate chaining)
        HashNode newNode = new HashNode(key, value);
        newNode.Next = bucketArray[index];
        bucketArray[index] = newNode;
    }

    // Get value by key
    public int Get(int key)
    {
        int index = GetBucketIndex(key);
        HashNode head = bucketArray[index];

        while (head != null)
        {
            if (head.Key == key)
            {
                return head.Value;
            }
            head = head.Next;
        }

        return -1; // Return -1 if key is not found
    }

    // Remove key from hash map
    public void Remove(int key)
    {
        int index = GetBucketIndex(key);
        HashNode head = bucketArray[index];
        HashNode prev = null;

        while (head != null)
        {
            if (head.Key == key)
            {
                if (prev != null)
                {
                    prev.Next = head.Next;
                }
                else
                {
                    bucketArray[index] = head.Next;
                }
                return;
            }
            prev = head;
            head = head.Next;
        }
    }

    // Display the hash map
    public void Display()
    {
        for (int i = 0; i < capacity; i++)
        {
            Console.Write("Bucket " + i + ": ");
            HashNode head = bucketArray[i];
            while (head != null)
            {
                Console.Write("[" + head.Key + " -> " + head.Value + "] ");
                head = head.Next;
            }
            Console.WriteLine();
        }
    }

    public static void Main()
    {
        CustomHashMap map = new CustomHashMap(5);
        map.Insert(1, 10);
        map.Insert(2, 20);
        map.Insert(6, 30); // Collision with key 1 due to mod operation

        Console.WriteLine("Value for key 2: " + map.Get(2)); // Expected: 20
        map.Remove(2);
        Console.WriteLine("Value for key 2 after removal: " + map.Get(2)); // Expected: -1

        Console.WriteLine("HashMap contents:");
        map.Display();
    }
}
