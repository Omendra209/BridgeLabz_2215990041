using System;

class Book
{
    // Public variable (accessible anywhere)
    public string ISBN;

    // Protected variable (accessible in derived classes)
    protected string title;

    // Private variable (only accessible within the class)
    private string author;

    // Constructor to initialize book details
    public Book(string ISBN, string title, string author)
    {
        this.ISBN = ISBN;
        this.title = title;
        this.author = author;
    }

    // Public method to get author
    public string GetAuthor()
    {
        return author;
    }

    // Public method to set author with validation
    public void SetAuthor(string newAuthor)
    {
        if (!string.IsNullOrWhiteSpace(newAuthor))
        {
            author = newAuthor;
        }
        else
        {
            Console.WriteLine("Invalid author name. Please provide a valid name.");
        }
    }

    // Display book details
    public void DisplayBookDetails()
    {
        Console.WriteLine("ISBN: " + ISBN);
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine();
    }
}

// Subclass demonstrating the use of protected and public members
class EBook : Book
{
    private double fileSize;

    // Constructor
    public EBook(string ISBN, string title, string author, double fileSize)
        : base(ISBN, title, author)
    {
        this.fileSize = fileSize;
    }

    // Method to display eBook details
    public void DisplayEBookDetails()
    {
        Console.WriteLine("ISBN: " + ISBN); // Accessing public member
        Console.WriteLine("Title: " + title); // Accessing protected member
        Console.WriteLine("File Size: " + fileSize + " MB");
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        // Creating Book object
        Book b1 = new Book("123-4567890123", "The Great Gatsby", "F. Scott Fitzgerald");
        b1.DisplayBookDetails();

        // Modifying author name
        b1.SetAuthor("Anonymous");
        Console.WriteLine("Updated Author: " + b1.GetAuthor());
        Console.WriteLine();

        // Creating EBook object
        EBook eb1 = new EBook("987-6543210987", "Digital Fortress", "Dan Brown", 5.2);
        eb1.DisplayEBookDetails();
    }
}
