using System;
using System.Collections.Generic;

// Faculty class represents a faculty member, who can exist independently of any department
public class Faculty
{
    public string Name { get; set; }
    public string Position { get; set; }

    // Constructor to initialize faculty details
    public Faculty(string name, string position)
    {
        Name = name;
        Position = position;
    }

    // Method to display faculty details
    public void DisplayFaculty()
    {
        Console.WriteLine("Faculty Name: " + Name + ", Position: " + Position);
    }
}

// Department class represents a department in the university
public class Department
{
    public string DepartmentName { get; set; }
    private List<Faculty> facultyMembers;

    // Constructor to initialize department name and faculty members list
    public Department(string departmentName)
    {
        DepartmentName = departmentName;
        facultyMembers = new List<Faculty>();
    }

    // Method to add a faculty member to the department
    public void AddFaculty(Faculty faculty)
    {
        facultyMembers.Add(faculty);
        Console.WriteLine(faculty.Name + " has been added to " + DepartmentName + " department.");
    }

    // Method to display all faculty members in the department
    public void DisplayFacultyMembers()
    {
        Console.WriteLine("Faculty members in " + DepartmentName + " Department:");
        foreach (var faculty in facultyMembers)
        {
            faculty.DisplayFaculty();
        }
    }

    // Destructor to remove faculty when department is deleted (demonstrating composition)
    ~Department()
    {
        Console.WriteLine(DepartmentName + " department is being deleted, all faculty are removed.");
    }
}

// University class represents the university which has multiple departments
public class University
{
    public string UniversityName { get; set; }
    private List<Department> departments;

    // Constructor to initialize university name and departments list
    public University(string universityName)
    {
        UniversityName = universityName;
        departments = new List<Department>();
    }

    // Method to add a department to the university
    public void AddDepartment(Department department)
    {
        departments.Add(department);
        Console.WriteLine(department.DepartmentName + " department added to " + UniversityName + ".");
    }

    // Method to display all departments and their faculty members
    public void DisplayDepartments()
    {
        Console.WriteLine("Departments in " + UniversityName + ":");
        foreach (var department in departments)
        {
            department.DisplayFacultyMembers();
        }
    }

    // Destructor to remove departments when university is deleted (demonstrating composition)
    ~University()
    {
        Console.WriteLine(UniversityName + " university is being deleted, all departments are removed.");
    }
}

// Main program to demonstrate the relationships and user interaction
public class Program
{
    public static void Main()
    {
        // Creating university
        University university = new University("Tech University");

        // Creating departments
        Department department1 = new Department("Computer Science");
        Department department2 = new Department("Mechanical Engineering");

        // Creating faculty members
        Faculty faculty1 = new Faculty("Dr. Alice", "Professor");
        Faculty faculty2 = new Faculty("Dr. Bob", "Associate Professor");
        Faculty faculty3 = new Faculty("Dr. Charlie", "Lecturer");

        // Adding faculty to departments
        department1.AddFaculty(faculty1);
        department1.AddFaculty(faculty2);
        department2.AddFaculty(faculty3);

        // Adding departments to the university
        university.AddDepartment(department1);
        university.AddDepartment(department2);

        int choice = 0;
        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Display all departments and their faculty members");
            Console.WriteLine("2. Add a department to the university");
            Console.WriteLine("3. Add a faculty member to a department");
            Console.WriteLine("4. Display all faculty members in a department");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    // Display all departments and their faculty members
                    university.DisplayDepartments();
                    break;

                case 2:
                    // Add a new department to the university
                    Console.Write("Enter department name: ");
                    string deptName = Console.ReadLine();
                    Department newDept = new Department(deptName);
                    university.AddDepartment(newDept);
                    break;

                case 3:
                    // Add a new faculty member to a department
                    Console.Write("Enter faculty name: ");
                    string facultyName = Console.ReadLine();
                    Console.Write("Enter faculty position: ");
                    string position = Console.ReadLine();
                    Console.Write("Enter department name: ");
                    string deptForFaculty = Console.ReadLine();

                    Department deptToAddFaculty = null;
                    foreach (var dept in university.Departments)
                    {
                        if (dept.DepartmentName == deptForFaculty)
                        {
                            deptToAddFaculty = dept;
                            break;
                        }
                    }

                    if (deptToAddFaculty != null)
                    {
                        Faculty newFaculty = new Faculty(facultyName, position);
                        deptToAddFaculty.AddFaculty(newFaculty);
                    }
                    else
                    {
                        Console.WriteLine("Department not found.");
                    }
                    break;

                case 4:
                    // Display all faculty members in a specific department
                    Console.Write("Enter department name to view faculty: ");
                    string departmentName = Console.ReadLine();

                    Department deptToDisplay = null;
                    foreach (var dept in university.Departments)
                    {
                        if (dept.DepartmentName == departmentName)
                        {
                            deptToDisplay = dept;
                            break;
                        }
                    }

                    if (deptToDisplay != null)
                    {
                        deptToDisplay.DisplayFacultyMembers();
                    }
                    else
                    {
                        Console.WriteLine("Department not found.");
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