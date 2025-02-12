using System;
using System.Collections.Generic;

// Abstract class representing a library item
abstract class LibraryItem
{
    private string itemId;
    private string title;
    private string author;

    public LibraryItem(string itemId, string title, string author)
    {
        this.itemId = itemId;
        this.title = title;
        this.author = author;
    }

    public abstract int GetLoanDuration();

    public void GetItemDetails()
    {
        Console.WriteLine("Item ID: " + itemId);
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
    }
}

// Interface for reservable items
interface IReservable
{
    void ReserveItem();
    bool CheckAvailability();
}

// Book subclass
class Book : LibraryItem, IReservable
{
    public Book(string itemId, string title, string author) : base(itemId, title, author) { }

    public override int GetLoanDuration()
    {
        return 14; // Books can be borrowed for 14 days
    }

    public void ReserveItem()
    {
        Console.WriteLine("Book has been reserved.");
    }

    public bool CheckAvailability()
    {
        return true; // Assume books are available
    }
}

// Magazine subclass
class Magazine : LibraryItem
{
    public Magazine(string itemId, string title, string author) : base(itemId, title, author) { }

    public override int GetLoanDuration()
    {
        return 7; // Magazines can be borrowed for 7 days
    }
}

// DVD subclass
class DVD : LibraryItem, IReservable
{
    public DVD(string itemId, string title, string author) : base(itemId, title, author) { }

    public override int GetLoanDuration()
    {
        return 3; // DVDs can be borrowed for 3 days
    }

    public void ReserveItem()
    {
        Console.WriteLine("DVD has been reserved.");
    }

    public bool CheckAvailability()
    {
        return false; // Assume DVDs are currently unavailable
    }
}

class Program
{
    static void Main()
    {
        List<LibraryItem> items = new List<LibraryItem>();
        items.Add(new Book("B001", "The Great Gatsby", "F. Scott Fitzgerald"));
        items.Add(new Magazine("M001", "National Geographic", "Various"));
        items.Add(new DVD("D001", "Inception", "Christopher Nolan"));

        foreach (var item in items)
        {
            item.GetItemDetails();
            Console.WriteLine("Loan Duration: " + item.GetLoanDuration() + " days");
            Console.WriteLine();
        }
    }
}
