using System;

public class Employee
{
    // Fields (Attributes)
    private string name;
    private int id;
    private double salary;

    // Constructor
    public Employee(string name, int id, double salary)
    {
        this.name = name;
        this.id = id;
        this.salary = salary;
    }

    // Method to display employee details
    public void DisplayDetails()
    {
        Console.WriteLine("Employee Name: " + name);
        Console.WriteLine("Employee ID: " + id);
        Console.WriteLine("Employee Salary: $" + salary);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Create an Employee object
        Employee employee = new Employee("John Doe", 101, 50000);

        // Display employee details
        employee.DisplayDetails();
    }
}