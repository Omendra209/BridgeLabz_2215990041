using System;

class Employee
{
    // Static variable shared by all instances of Employee
    public static string CompanyName = "TechCorp";

    // Static variable to track total number of employees
    private static int totalEmployees = 0;

    // Readonly variable for employee ID
    private readonly int id;

    // Instance variables for employee name and designation
    private string name;
    private string designation;

    // Static method to display total number of employees
    public static void DisplayTotalEmployees()
    {
        Console.WriteLine("Total Employees: " + totalEmployees);
    }

    // Constructor to initialize the employee details
    public Employee(string name, int id, string designation)
    {
        this.name = name;            // Initialize employee's name
        this.id = id;                // Initialize employee's ID (readonly)
        this.designation = designation; // Initialize employee's designation

        totalEmployees++;            // Increment the total employees count
    }

    // Method to display employee details
    public void DisplayEmployeeDetails()
    {
        Console.WriteLine("Company Name: " + CompanyName);
        Console.WriteLine("Employee Name: " + name);
        Console.WriteLine("Employee ID: " + id);
        Console.WriteLine("Employee Designation: " + designation);
    }
}

public class EmployeeManagementSystem
{
    public static void Main()
    {
        // Creating instances of Employee
        Employee emp1 = new Employee("John Doe", 1, "Software Engineer");
        Employee emp2 = new Employee("Jane Smith", 2, "HR Manager");

        // Display the total number of employees
        Employee.DisplayTotalEmployees();

        // Checking if the object is an instance of Employee using 'is' operator
        if (emp1 is Employee)
        {
            emp1.DisplayEmployeeDetails(); // Display details of emp1 if it's an Employee instance
        }

        if (emp2 is Employee)
        {
            emp2.DisplayEmployeeDetails(); // Display details of emp2 if it's an Employee instance
        }
    }
}
