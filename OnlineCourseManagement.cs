using System;

class Course
{
    // Instance variables
    private string courseName;
    private int duration; // Duration in months
    private double fee;

    // Class variable (shared among all instances)
    private static string instituteName = "Default Institute";

    // Constructor to initialize course details
    public Course(string name, int duration, double fee)
    {
        this.courseName = name;
        this.duration = duration;
        this.fee = fee;
    }

    // Instance method to display course details
    public void DisplayCourseDetails()
    {
        Console.WriteLine("Course Name: " + courseName);
        Console.WriteLine("Duration: " + duration + " months");
        Console.WriteLine("Fee: " + fee);
        Console.WriteLine("Institute: " + instituteName);
        Console.WriteLine();
    }

    // Class method to update the institute name
    public static void UpdateInstituteName(string newName)
    {
        instituteName = newName;
    }
}

class Program
{
    static void PrintCourseDetails(Course course)
    {
        course.DisplayCourseDetails();
    }

    static void Main()
    {
        // Creating course objects
        Course c1 = new Course("C# Programming", 3, 5000);
        Course c2 = new Course("Java Programming", 4, 6000);

        // Displaying initial details
        Console.WriteLine("Before updating institute name:");
        PrintCourseDetails(c1);
        PrintCourseDetails(c2);

        // Updating institute name
        Course.UpdateInstituteName("Tech Academy");

        // Displaying updated details
        Console.WriteLine("After updating institute name:");
        PrintCourseDetails(c1);
        PrintCourseDetails(c2);
    }
}