using System;

class Book
{

    public const string libraryName = "Library";
    private string title = "\0";
    private string author = "\0";
    private int isbn {  get; }

    // Static method to get total accounts
    public static void DisplayLibraryName()
    {
        Console.WriteLine(libraryName);
    }

    // Constructor using 'this' for clarity
    public Book(string title, string author, int isbn)
    {
        this.isbn = isbn;
        this.title = title;
        this.author = author;
    }

    // Method to display account details
    public void DisplayBookDetails()
    {
        Console.WriteLine("Book titile: " + title);
        Console.WriteLine("Book Author: " + author);
        Console.WriteLine("Book ISBN: " + isbn);
    }
}

public class LibraryManagementSystem
{
    public static void Main()
    {
        string title = "hello World";
        string author = "programming language";
        int isbn = 23;
        Book user1 = new Book(title, author, isbn);
        Book.DisplayLibraryName();
        if (user1 is Book)
        {
            user1.DisplayBookDetails();
        }
        else
        {
            Console.WriteLine("Object is not an instance of the Book Class");
        }
    }
}
