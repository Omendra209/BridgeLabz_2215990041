using System;

class Student
{
    // Static variable shared by all instances of Student class for University Name
    public static string UniversityName = "XYZ University";

    // Static variable to track the total number of students enrolled
    private static int totalStudents = 0;

    // Readonly variable for RollNumber (cannot be changed after assignment)
    private readonly int rollNumber;

    // Instance variables for student details
    private string name;
    private string grade;

    // Static method to display the total number of students enrolled
    public static void DisplayTotalStudents()
    {
        Console.WriteLine("Total Students Enrolled: " + totalStudents);
    }

    // Constructor to initialize student details (Name, RollNumber, and Grade)
    public Student(string name, int rollNumber, string grade)
    {
        this.name = name;           // Initialize student name
        this.rollNumber = rollNumber; // Initialize student roll number (readonly)
        this.grade = grade;           // Initialize student grade

        totalStudents++;             // Increment the total student count
    }

    // Method to display student details
    public void DisplayStudentDetails()
    {
        Console.WriteLine("University Name: " + UniversityName);
        Console.WriteLine("Student Name: " + name);
        Console.WriteLine("Roll Number: " + rollNumber);
        Console.WriteLine("Grade: " + grade);
    }

    // Method to update the grade if the object is an instance of Student class
    public void UpdateGrade(string newGrade)
    {
        if (this is Student) // Check if this object is an instance of Student
        {
            grade = newGrade;  // Update the grade
            Console.WriteLine("Grade updated to: " + grade);
        }
        else
        {
            Console.WriteLine("Object is not an instance of the Student class.");
        }
    }
}

public class UniversityStudentManagement
{
    public static void Main()
    {
        // Creating instances of Student
        Student student1 = new Student("Alice", 101, "A");
        Student student2 = new Student("Bob", 102, "B");

        // Display the total number of students enrolled
        Student.DisplayTotalStudents();

        // Display student details
        student1.DisplayStudentDetails();
        student2.DisplayStudentDetails();

        // Updating the grade of student1
        student1.UpdateGrade("A+");
        student2.UpdateGrade("A");

        // Checking if the objects are instances of Student class using 'is' operator
        if (student1 is Student)
        {
            Console.WriteLine("student1 is an instance of Student class.");
        }

        if (student2 is Student)
        {
            Console.WriteLine("student2 is an instance of Student class.");
        }
    }
}
