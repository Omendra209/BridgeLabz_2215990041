using System;
using System.Collections.Generic;

// Course class represents a course offered by the school
public class Course
{
    public string CourseName { get; set; }
    private List<Student> enrolledStudents;

    // Constructor to initialize the course name and enrolled students list
    public Course(string courseName)
    {
        CourseName = courseName;
        enrolledStudents = new List<Student>();
    }

    // Method to enroll a student in the course
    public void EnrollStudent(Student student)
    {
        enrolledStudents.Add(student);
        student.EnrollInCourse(this);
        Console.WriteLine(student.Name + " has been enrolled in the course: " + CourseName);
    }

    // Method to display all students enrolled in the course
    public void DisplayEnrolledStudents()
    {
        Console.WriteLine("Students enrolled in " + CourseName + ":");
        foreach (var student in enrolledStudents)
        {
            Console.WriteLine(student.Name);
        }
    }
}

// Student class represents a student enrolled in the school
public class Student
{
    public string Name { get; set; }
    private List<Course> courses;

    // Constructor to initialize student name and courses list
    public Student(string name)
    {
        Name = name;
        courses = new List<Course>();
    }

    // Method to enroll in a course
    public void EnrollInCourse(Course course)
    {
        courses.Add(course);
    }

    // Method to display all courses the student is enrolled in
    public void DisplayCourses()
    {
        Console.WriteLine(Name + " is enrolled in the following courses:");
        foreach (var course in courses)
        {
            Console.WriteLine(course.CourseName);
        }
    }
}

// School class represents a school that contains students
public class School
{
    public string SchoolName { get; set; }
    private List<Student> students;

    // Constructor to initialize school name and students list
    public School(string schoolName)
    {
        SchoolName = schoolName;
        students = new List<Student>();
    }

    // Method to add a student to the school
    public void AddStudent(Student student)
    {
        students.Add(student);
        Console.WriteLine(student.Name + " has been added to the school: " + SchoolName);
    }

    // Method to display all students in the school
    public void DisplayStudents()
    {
        Console.WriteLine("Students in " + SchoolName + ":");
        foreach (var student in students)
        {
            Console.WriteLine(student.Name);
        }
    }
}

// Main program to demonstrate the relationships and user interaction
public class Program
{
    public static void Main()
    {
        // Creating school
        School school = new School("Green Valley High");

        // Creating students
        Student student1 = new Student("John Doe");
        Student student2 = new Student("Jane Smith");

        // Adding students to the school
        school.AddStudent(student1);
        school.AddStudent(student2);

        // Creating courses
        Course course1 = new Course("Math 101");
        Course course2 = new Course("Science 101");

        // Enrolling students in courses
        course1.EnrollStudent(student1);
        course2.EnrollStudent(student1);
        course1.EnrollStudent(student2);

        // Displaying students enrolled in each course
        course1.DisplayEnrolledStudents();
        course2.DisplayEnrolledStudents();

        // Displaying courses each student is enrolled in
        student1.DisplayCourses();
        student2.DisplayCourses();

        int choice = 0;

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Display all students in the school");
            Console.WriteLine("2. Display all courses of a student");
            Console.WriteLine("3. Display all enrolled students in a course");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    // Display all students in the school
                    school.DisplayStudents();
                    break;

                case 2:
                    // Display all courses of a student
                    Console.Write("Enter student name to view their courses: ");
                    string studentName = Console.ReadLine();
                    Student studentToView = null;
                    foreach (var student in school.Students)
                    {
                        if (student.Name == studentName)
                        {
                            studentToView = student;
                            break;
                        }
                    }
                    if (studentToView != null)
                    {
                        studentToView.DisplayCourses();
                    }
                    else
                    {
                        Console.WriteLine("Student not found.");
                    }
                    break;

                case 3:
                    // Display all students in a course
                    Console.Write("Enter course name to view enrolled students: ");
                    string courseName = Console.ReadLine();
                    Course courseToView = null;
                    foreach (var course in school.Courses)
                    {
                        if (course.CourseName == courseName)
                        {
                            courseToView = course;
                            break;
                        }
                    }
                    if (courseToView != null)
                    {
                        courseToView.DisplayEnrolledStudents();
                    }
                    else
                    {
                        Console.WriteLine("Course not found.");
                    }
                    break;

                case 0:
                    // Exit the program
                    Console.WriteLine("Exiting the program.");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}