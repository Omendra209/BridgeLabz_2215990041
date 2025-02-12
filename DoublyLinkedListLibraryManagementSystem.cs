using System;

class BookNode
{
    public int BookID;          // Unique Book ID
    public string Title;        // Book Title
    public string Author;       // Author Name
    public string Genre;        // Book Genre
    public bool IsAvailable;    // Availability Status
    public BookNode Next;       // Pointer to next book
    public BookNode Prev;       // Pointer to previous book

    // Constructor to initialize book details
    public BookNode(int bookID, string title, string author, string genre, bool isAvailable)
    {
        BookID = bookID;
        Title = title;
        Author = author;
        Genre = genre;
        IsAvailable = isAvailable;
        Next = null;
        Prev = null;
    }
}

class LibraryManagement
{
    private BookNode head; // First book in the doubly linked list

    // Add a book at the beginning
    public void AddBookAtBeginning(int bookID, string title, string author, string genre, bool isAvailable)
    {
        BookNode newBook = new BookNode(bookID, title, author, genre, isAvailable);
        if (head != null)
        {
            newBook.Next = head;
            head.Prev = newBook;
        }
        head = newBook;
    }

    // Add a book at the end
    public void AddBookAtEnd(int bookID, string title, string author, string genre, bool isAvailable)
    {
        BookNode newBook = new BookNode(bookID, title, author, genre, isAvailable);
        if (head == null)
        {
            head = newBook;
            return;
        }

        BookNode temp = head;
        while (temp.Next != null)
        {
            temp = temp.Next;
        }
        temp.Next = newBook;
        newBook.Prev = temp;
    }

    // Remove a book by Book ID
    public void RemoveBook(int bookID)
    {
        if (head == null)
        {
            Console.WriteLine("Library is empty.");
            return;
        }

        BookNode temp = head;
        while (temp != null && temp.BookID != bookID)
        {
            temp = temp.Next;
        }

        if (temp == null)
        {
            Console.WriteLine("Book not found.");
            return;
        }

        if (temp.Prev != null)
            temp.Prev.Next = temp.Next;
        if (temp.Next != null)
            temp.Next.Prev = temp.Prev;
        if (temp == head)
            head = temp.Next;

        Console.WriteLine("Book removed successfully.");
    }

    // Search for a book by Title
    public void SearchByTitle(string title)
    {
        BookNode temp = head;
        while (temp != null)
        {
            if (temp.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Book Found: ID: " + temp.BookID + ", Author: " + temp.Author + ", Genre: " + temp.Genre + ", Available: " + temp.IsAvailable);
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Book not found.");
    }

    // Search for books by Author
    public void SearchByAuthor(string author)
    {
        BookNode temp = head;
        bool found = false;
        while (temp != null)
        {
            if (temp.Author.Equals(author, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Book Found: ID: " + temp.BookID + ", Title: " + temp.Title + ", Genre: " + temp.Genre + ", Available: " + temp.IsAvailable);
                found = true;
            }
            temp = temp.Next;
        }
        if (!found)
        {
            Console.WriteLine("No books found by this author.");
        }
    }

    // Update the availability status of a book
    public void UpdateAvailability(int bookID, bool newStatus)
    {
        BookNode temp = head;
        while (temp != null)
        {
            if (temp.BookID == bookID)
            {
                temp.IsAvailable = newStatus;
                Console.WriteLine("Book availability updated.");
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Book not found.");
    }

    // Display all books in forward order
    public void DisplayBooksForward()
    {
        if (head == null)
        {
            Console.WriteLine("Library is empty.");
            return;
        }

        BookNode temp = head;
        while (temp != null)
        {
            Console.WriteLine("ID: " + temp.BookID + ", Title: " + temp.Title + ", Author: " + temp.Author + ", Genre: " + temp.Genre + ", Available: " + temp.IsAvailable);
            temp = temp.Next;
        }
    }

    // Display all books in reverse order
    public void DisplayBooksReverse()
    {
        if (head == null)
        {
            Console.WriteLine("Library is empty.");
            return;
        }

        BookNode temp = head;
        while (temp.Next != null)
        {
            temp = temp.Next;
        }

        while (temp != null)
        {
            Console.WriteLine("ID: " + temp.BookID + ", Title: " + temp.Title + ", Author: " + temp.Author + ", Genre: " + temp.Genre + ", Available: " + temp.IsAvailable);
            temp = temp.Prev;
        }
    }

    // Count the total number of books in the library
    public void CountBooks()
    {
        int count = 0;
        BookNode temp = head;
        while (temp != null)
        {
            count++;
            temp = temp.Next;
        }
        Console.WriteLine("Total number of books in the library: " + count);
    }
}

class Program
{
    static void Main()
    {
        LibraryManagement library = new LibraryManagement();

        while (true)
        {
            Console.WriteLine("\nLibrary Management Menu:");
            Console.WriteLine("1. Add Book at Beginning");
            Console.WriteLine("2. Add Book at End");
            Console.WriteLine("3. Remove Book");
            Console.WriteLine("4. Search by Title");
            Console.WriteLine("5. Search by Author");
            Console.WriteLine("6. Update Availability");
            Console.WriteLine("7. Display Books (Forward)");
            Console.WriteLine("8. Display Books (Reverse)");
            Console.WriteLine("9. Count Books");
            Console.WriteLine("10. Exit");
            Console.Write("Enter your choice: ");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            int bookID;
            string title, author, genre;
            bool isAvailable;

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Book ID: ");
                    bookID = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Title: ");
                    title = Console.ReadLine();
                    Console.Write("Enter Author: ");
                    author = Console.ReadLine();
                    Console.Write("Enter Genre: ");
                    genre = Console.ReadLine();
                    Console.Write("Is Available (true/false): ");
                    isAvailable = Convert.ToBoolean(Console.ReadLine());

                    library.AddBookAtBeginning(bookID, title, author, genre, isAvailable);
                    break;

                case 2:
                    Console.Write("Enter Book ID: ");
                    bookID = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Title: ");
                    title = Console.ReadLine();
                    Console.Write("Enter Author: ");
                    author = Console.ReadLine();
                    Console.Write("Enter Genre: ");
                    genre = Console.ReadLine();
                    Console.Write("Is Available (true/false): ");
                    isAvailable = Convert.ToBoolean(Console.ReadLine());

                    library.AddBookAtEnd(bookID, title, author, genre, isAvailable);
                    break;

                case 3:
                    Console.Write("Enter Book ID to Remove: ");
                    bookID = Convert.ToInt32(Console.ReadLine());
                    library.RemoveBook(bookID);
                    break;

                case 4:
                    Console.Write("Enter Book Title: ");
                    title = Console.ReadLine();
                    library.SearchByTitle(title);
                    break;

                case 5:
                    Console.Write("Enter Author Name: ");
                    author = Console.ReadLine();
                    library.SearchByAuthor(author);
                    break;

                case 6:
                    Console.Write("Enter Book ID: ");
                    bookID = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Is Available (true/false): ");
                    isAvailable = Convert.ToBoolean(Console.ReadLine());
                    library.UpdateAvailability(bookID, isAvailable);
                    break;

                case 7:
                    library.DisplayBooksForward();
                    break;

                case 8:
                    library.DisplayBooksReverse();
                    break;

                case 9:
                    library.CountBooks();
                    break;

                case 10:
                    return;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }
}
