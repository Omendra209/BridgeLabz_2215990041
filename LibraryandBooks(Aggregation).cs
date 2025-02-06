using System;
using System.Collections.Generic;

// Book class with attributes for Title and Author
public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }

    // Constructor to initialize book with title and author
    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }
}

// Library class that aggregates Book objects
public class Library
{
    // List to hold books in the library
    private List<Book> books = new List<Book>();

    // Method to add a book to the library
    public void AddBook(Book book)
    {
        books.Add(book);
        Console.WriteLine("Book '{0}' by {1} added to the library.", book.Title, bookAuthor);
    }

    // Method to display all books in the library
    public void DisplayBooks()
    {
        Console.WriteLine("Books in the Library:");
        foreach (var book in books)
        {
            Console.WriteLine("Title: {0}, Author: {1},book.Title,bookAuthor");
        }
    }
}

// Main program to demonstrate the aggregation relationship with switch-case UI
public class Program
{
    public static void Main()
    {
        // Creating Library objects
        Library library1 = new Library();
        Library library2 = new Library();

        // Loop for repeated user interaction
        while (true)
        {
            Console.WriteLine("\nLibrary Management System");
            Console.WriteLine("1. Add Book to Library");
            Console.WriteLine("2. Display Books in Library 1");
            Console.WriteLine("3. Display Books in Library 2");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Book Title: ");
                    string title = Console.ReadLine();
                    Console.Write("Enter Book Author: ");
                    string author = Console.ReadLine();
                    Console.WriteLine("Choose Library (1 or 2): ");
                    int libraryChoice = int.Parse(Console.ReadLine());

                    // Create new book
                    Book newBook = new Book(title, author);

                    // Add the book to the chosen library
                    if (libraryChoice == 1)
                    {
                        library1.AddBook(newBook);
                    }
                    else if (libraryChoice == 2)
                    {
                        library2.AddBook(newBook);
                    }
                    else
                    {
                        Console.WriteLine("Invalid library choice!");
                    }
                    break;

                case 2:
                    library1.DisplayBooks();
                    break;

                case 3:
                    library2.DisplayBooks();
                    break;

                case 0:
                    Console.WriteLine("Exiting Program...");
                    return; // Exit the program

                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }
}