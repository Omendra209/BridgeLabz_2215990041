using System;

class Student
{
    // Public variable (accessible anywhere)
    public int rollNumber;

    // Protected variable (accessible in derived classes)
    protected string name;

    // Private variable (only accessible within the class)
    private double CGPA;

    // Constructor to initialize student details
    public Student(int rollNumber, string name, double CGPA)
    {
        this.rollNumber = rollNumber;
        this.name = name;
        this.CGPA = CGPA;
    }

    // Public method to get CGPA
    public double GetCGPA()
    {
        return CGPA;
    }

    // Public method to set CGPA with validation
    public void SetCGPA(double newCGPA)
    {
        if (newCGPA >= 0.0 && newCGPA <= 10.0)
        {
            CGPA = newCGPA;
        }
        else
        {
            Console.WriteLine("Invalid CGPA value. Please enter a value between 0 and 10.");
        }
    }

    // Display student details
    public void DisplayStudentDetails()
    {
        Console.WriteLine("Roll Number: " + rollNumber);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("CGPA: " + CGPA);
        Console.WriteLine();
    }
}

// Subclass demonstrating the use of protected members
class PostgraduateStudent : Student
{
    private string specialization;

    // Constructor
    public PostgraduateStudent(int rollNumber, string name, double CGPA, string specialization)
        : base(rollNumber, name, CGPA)
    {
        this.specialization = specialization;
    }

    // Method to display postgraduate student details
    public void DisplayPostgraduateDetails()
    {
        Console.WriteLine("Roll Number: " + rollNumber);
        Console.WriteLine("Name: " + name); // Accessing protected member
        Console.WriteLine("Specialization: " + specialization);
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        // Creating Student object
        Student s1 = new Student(101, "Alice", 8.5);
        s1.DisplayStudentDetails();

        // Modifying CGPA
        s1.SetCGPA(9.2);
        Console.WriteLine("Updated CGPA: " + s1.GetCGPA());
        Console.WriteLine();

        // Creating PostgraduateStudent object
        PostgraduateStudent pg1 = new PostgraduateStudent(201, "Bob", 9.0, "Computer Science");
        pg1.DisplayPostgraduateDetails();
    }
}
