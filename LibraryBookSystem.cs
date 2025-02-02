using System;

public class Book
{
    public string title;
    public string author;
    public decimal price;
    public bool availability;

    // Default constructor
    public Book()
    {
        title = "Unknown";
        author = "Unknown";
        price = 0.0m;
        availability = true;
    }

    // Parameterized constructor
    public Book(string title, string author, decimal price, bool availability)
    {
        this.title = title;
        this.author = author;
        this.price = price;
        this.availability = availability;
    }

    // Method to borrow the book
    public void BorrowBook()
    {
        if (availability)
        {
            availability = false;
            Console.WriteLine("You have borrowed the book: " + title);
        }
        else
        {
            Console.WriteLine("Sorry, the book is already borrowed.");
        }
    }

    // Method to display book details
    public void DisplayBookDetails()
    {
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine("Price: " + price.ToString("C"));
        Console.WriteLine("Availability: " + (availability ? "Available" : "Not Available"));
    }
}

class Program
{
    static void Main()
    {
        Book book1 = new Book("The Catcher in the Rye", "J.D. Salinger", 10.99m, true);
        book1.DisplayBookDetails();
        book1.BorrowBook();
        book1.DisplayBookDetails();
    }
}
