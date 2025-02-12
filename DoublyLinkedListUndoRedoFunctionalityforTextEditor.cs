using System;

class TextNode
{
    public string TextContent;  // Stores the text state
    public TextNode Prev;       // Pointer to previous state
    public TextNode Next;       // Pointer to next state

    // Constructor to initialize text content
    public TextNode(string text)
    {
        TextContent = text;
        Prev = null;
        Next = null;
    }
}

class TextEditor
{
    private TextNode head;      // Head of the doubly linked list
    private TextNode current;   // Pointer to the current state
    private int maxSize = 10;   // Maximum number of undo/redo states
    private int count = 0;      // Current number of states

    // Add a new state to the text editor (Typing or performing an action)
    public void AddState(string newText)
    {
        TextNode newState = new TextNode(newText);

        if (current != null)
        {
            newState.Prev = current;
            current.Next = newState;
        }
        else
        {
            head = newState;
        }

        current = newState;
        count++;

        // Limit history size
        if (count > maxSize)
        {
            head = head.Next;
            head.Prev = null;
            count--;
        }
    }

    // Undo: Move to the previous state
    public void Undo()
    {
        if (current != null && current.Prev != null)
        {
            current = current.Prev;
            Console.WriteLine("Undo performed. Current Text: " + current.TextContent);
        }
        else
        {
            Console.WriteLine("No more undo steps available.");
        }
    }

    // Redo: Move to the next state
    public void Redo()
    {
        if (current != null && current.Next != null)
        {
            current = current.Next;
            Console.WriteLine("Redo performed. Current Text: " + current.TextContent);
        }
        else
        {
            Console.WriteLine("No more redo steps available.");
        }
    }

    // Display the current text state
    public void DisplayCurrentState()
    {
        if (current != null)
        {
            Console.WriteLine("Current Text: " + current.TextContent);
        }
        else
        {
            Console.WriteLine("No text available.");
        }
    }
}

class Program
{
    static void Main()
    {
        TextEditor editor = new TextEditor();

        while (true)
        {
            Console.WriteLine("\nText Editor - Undo/Redo Functionality:");
            Console.WriteLine("1. Type new text");
            Console.WriteLine("2. Undo");
            Console.WriteLine("3. Redo");
            Console.WriteLine("4. View Current Text");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            string text;

            switch (choice)
            {
                case 1:
                    Console.Write("Enter new text: ");
                    text = Console.ReadLine();
                    editor.AddState(text);
                    break;

                case 2:
                    editor.Undo();
                    break;

                case 3:
                    editor.Redo();
                    break;

                case 4:
                    editor.DisplayCurrentState();
                    break;

                case 5:
                    return;

                default:
                    Console.WriteLine("Invalid choice! Please try again.");
                    break;
            }
        }
    }
}
