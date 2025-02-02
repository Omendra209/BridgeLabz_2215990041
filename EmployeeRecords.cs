using System;

public class Employee
{
    // Public attribute for employeeID
    public int employeeID;

    // Protected attribute for department
    protected string department;

    // Private attribute for salary
    private decimal salary;

    // Constructor to initialize Employee object
    public Employee(int id, string dept, decimal sal)
    {
        employeeID = id;
        department = dept;
        salary = sal;
    }

    // Public method to modify salary
    public void ModifySalary(decimal newSalary)
    {
        if (newSalary >= 0) // Ensuring salary can't be negative
        {
            salary = newSalary;
            Console.WriteLine("Salary updated successfully.");
        }
        else
        {
            Console.WriteLine("Invalid salary. Salary cannot be negative.");
        }
    }

    // Method to display basic employee details
    public void DisplayEmployeeDetails()
    {
        Console.WriteLine("Employee ID: " + employeeID);
        Console.WriteLine("Department: " + department);
        Console.WriteLine("Salary: " + salary.ToString("C"));
    }
}

public class Manager : Employee
{
    // Constructor to initialize Manager object
    public Manager(int id, string dept, decimal sal) : base(id, dept, sal)
    {
    }

    // Method to access employeeID and department from the Manager subclass
    public void DisplayManagerDetails()
    {
        Console.WriteLine("Manager's Employee ID: " + employeeID);
        Console.WriteLine("Manager's Department: " + department);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating an Employee object
        Employee emp = new Employee(101, "Finance", 50000m);
        emp.DisplayEmployeeDetails();

        // Modifying the salary using the public method
        emp.ModifySalary(55000m);
        emp.DisplayEmployeeDetails();

        // Creating a Manager object
        Manager mgr = new Manager(102, "HR", 80000m);
        mgr.DisplayManagerDetails();
    }
}
