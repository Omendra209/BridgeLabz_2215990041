using System;

public class Book
{
    public string title;
    public string author;
    public decimal price;

    // Default constructor
    public Book()
    {
        title = "Unknown";
        author = "Unknown";
        price = 0.0m;
    }

    // Parameterized constructor
    public Book(string title, string author, decimal price)
    {
        this.title = title;
        this.author = author;
        this.price = price;
    }

    // Method to display book details
    public void DisplayBookDetails()
    {
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine("Price: " + price.ToString("C"));
    }
}

class Program
{
    static void Main()
    {
        Book defaultBook = new Book();
        defaultBook.DisplayBookDetails();

        Book customBook = new Book("The Alchemist", "Paulo Coelho", 15.99m);
        customBook.DisplayBookDetails();
    }
}
