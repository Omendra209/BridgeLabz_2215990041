using System;

public class Book
{
    // Fields (Attributes)
    private string title;
    private string author;
    private double price;

    // Constructor
    public Book(string title, string author, double price)
    {
        this.title = title;
        this.author = author;
        this.price = price;
    }

    // Method to display book details
    public void DisplayDetails()
    {
        Console.WriteLine("Book Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine("Price: $" + price);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Create a Book object
        Book book = new Book("The Great Gatsby", "F. Scott Fitzgerald", 15.99);

        // Display book details
        book.DisplayDetails();
    }
}