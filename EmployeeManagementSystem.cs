using System;
using System.Collections.Generic;

// Interface for department handling
public interface IDepartment
{
    void AssignDepartment(string department);
    string GetDepartmentDetails();
}

// Abstract class Employee
public abstract class Employee
{
    public int EmployeeId { get; private set; }
    public string Name { get; private set; }
    public double BaseSalary { get; protected set; }

    public Employee(int employeeId, string name, double baseSalary)
    {
        EmployeeId = employeeId;
        Name = name;
        BaseSalary = baseSalary;
    }

    public abstract double CalculateSalary();

    public void DisplayDetails()
    {
        Console.WriteLine("ID: {0}, Name: {1}, Salary: {2}", EmployeeId, Name, CalculateSalary());
    }
}

// Full-time employee class
public class FullTimeEmployee : Employee, IDepartment
{
    private string Department;

    public FullTimeEmployee(int employeeId, string name, double baseSalary)
        : base(employeeId, name, baseSalary) { }

    public override double CalculateSalary()
    {
        return BaseSalary;
    }

    public void AssignDepartment(string department)
    {
        Department = department;
    }

    public string GetDepartmentDetails()
    {
        return "Department: " + Department;
    }
}

// Part-time employee class
public class PartTimeEmployee : Employee, IDepartment
{
    private string Department;
    private int WorkHours;
    private double HourlyRate;

    public PartTimeEmployee(int employeeId, string name, double hourlyRate, int workHours)
        : base(employeeId, name, 0)
    {
        HourlyRate = hourlyRate;
        WorkHours = workHours;
    }

    public override double CalculateSalary()
    {
        return WorkHours * HourlyRate;
    }

    public void AssignDepartment(string department)
    {
        Department = department;
    }

    public string GetDepartmentDetails()
    {
        return "Department: " + Department;
    }
}

// Main program
public class Program
{
    public static void Main()
    {
        List<Employee> employees = new List<Employee>();
        employees.Add(new FullTimeEmployee(1, "Alice", 5000));
        employees.Add(new PartTimeEmployee(2, "Bob", 20, 80));

        foreach (Employee emp in employees)
        {
            emp.DisplayDetails();
        }
    }
}
