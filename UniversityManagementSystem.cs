using System;
using System.Collections.Generic;

// Course class represents a course in the university
public class Course
{
    public string CourseName { get; set; }
    public int CourseID { get; set; }
    public Professor AssignedProfessor { get; set; }
    public List<Student> EnrolledStudents { get; set; }

    // Constructor to initialize course details
    public Course(int courseID, string courseName)
    {
        CourseID = courseID;
        CourseName = courseName;
        EnrolledStudents = new List<Student>();
    }

    // Method to enroll a student in the course
    public void EnrollStudent(Student student)
    {
        EnrolledStudents.Add(student);
        Console.WriteLine(student.Name + " enrolled in " + CourseName);
    }

    // Method to assign a professor to the course
    public void AssignProfessor(Professor professor)
    {
        AssignedProfessor = professor;
        Console.WriteLine(professor.Name + " is assigned to teach " + CourseName);
    }

    // Method to display course details and enrolled students
    public void DisplayCourseDetails()
    {
        Console.WriteLine("Course Name: " + CourseName);
        Console.WriteLine("Course ID: " + CourseID);
        Console.WriteLine("Professor: " + (AssignedProfessor != null ? AssignedProfessor.Name : "Not assigned"));
        Console.WriteLine("Enrolled Students:");
        foreach (var student in EnrolledStudents)
        {
            Console.WriteLine("- " + student.Name);
        }
    }
}

// Student class represents a student in the university
public class Student
{
    public string Name { get; set; }
    public int StudentID { get; set; }

    // Constructor to initialize student details
    public Student(int studentID, string name)
    {
        StudentID = studentID;
        Name = name;
    }

    // Method to enroll in a course
    public void EnrollCourse(Course course)
    {
        course.EnrollStudent(this);
    }
}

// Professor class represents a professor in the university
public class Professor
{
    public string Name { get; set; }
    public int ProfessorID { get; set; }

    // Constructor to initialize professor details
    public Professor(int professorID, string name)
    {
        ProfessorID = professorID;
        Name = name;
    }

    // Method to assign the professor to a course
    public void AssignToCourse(Course course)
    {
        course.AssignProfessor(this);
    }
}

// Main program to demonstrate the relationships and interactions
public class Program
{
    public static void Main()
    {
        // Creating professors
        Professor professor1 = new Professor(101, "Dr. Smith");
        Professor professor2 = new Professor(102, "Dr. Johnson");

        // Creating students
        Student student1 = new Student(201, "Alice");
        Student student2 = new Student(202, "Bob");

        // Creating courses
        Course course1 = new Course(301, "Computer Science 101");
        Course course2 = new Course(302, "Mathematics 101");

        // Assigning professors to courses
        professor1.AssignToCourse(course1);
        professor2.AssignToCourse(course2);

        // Students enrolling in courses
        student1.EnrollCourse(course1);
        student1.EnrollCourse(course2);
        student2.EnrollCourse(course1);

        // Displaying course details
        course1.DisplayCourseDetails();
        course2.DisplayCourseDetails();

        // Adding switch-case logic for user interaction
        int choice = 0;
        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Enroll a student in a course");
            Console.WriteLine("2. Assign a professor to a course");
            Console.WriteLine("3. Display course details");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    // Enroll a student in a course
                    Console.Write("Enter Student Name: ");
                    string studentName = Console.ReadLine();
                    Console.Write("Enter Course Name: ");
                    string courseName = Console.ReadLine();
                    Student studentToEnroll = null;
                    Course courseToEnroll = null;

                    // Find student and course
                    foreach (var student in new List<Student> { student1, student2 })
                    {
                        if (student.Name.Equals(studentName, StringComparison.OrdinalIgnoreCase))
                        {
                            studentToEnroll = student;
                            break;
                        }
                    }

                    foreach (var course in new List<Course> { course1, course2 })
                    {
                        if (course.CourseName.Equals(courseName, StringComparison.OrdinalIgnoreCase))
                        {
                            courseToEnroll = course;
                            break;
                        }
                    }

                    if (studentToEnroll != null && courseToEnroll != null)
                    {
                        studentToEnroll.EnrollCourse(courseToEnroll);
                    }
                    else
                    {
                        Console.WriteLine("Student or Course not found.");
                    }
                    break;

                case 2:
                    // Assign a professor to a course
                    Console.Write("Enter Professor Name: ");
                    string professorName = Console.ReadLine();
                    Console.Write("Enter Course Name: ");
                    courseName = Console.ReadLine();
                    Professor professorToAssign = null;
                    Course courseToAssign = null;

                    // Find professor and course
                    foreach (var professor in new List<Professor> { professor1, professor2 })
                    {
                        if (professor.Name.Equals(professorName, StringComparison.OrdinalIgnoreCase))
                        {
                            professorToAssign = professor;
                            break;
                        }
                    }

                    foreach (var course in new List<Course> { course1, course2 })
                    {
                        if (course.CourseName.Equals(courseName, StringComparison.OrdinalIgnoreCase))
                        {
                            courseToAssign = course;
                            break;
                        }
                    }

                    if (professorToAssign != null && courseToAssign != null)
                    {
                        professorToAssign.AssignToCourse(courseToAssign);
                    }
                    else
                    {
                        Console.WriteLine("Professor or Course not found.");
                    }
                    break;

                case 3:
                    // Display course details
                    Console.Write("Enter Course Name to view details: ");
                    courseName = Console.ReadLine();
                    Course courseToDisplay = null;

                    foreach (var course in new List<Course> { course1, course2 })
                    {
                        if (course.CourseName.Equals(courseName, StringComparison.OrdinalIgnoreCase))
                        {
                            courseToDisplay = course;
                            break;
                        }
                    }

                    if (courseToDisplay != null)
                    {
                        courseToDisplay.DisplayCourseDetails();
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