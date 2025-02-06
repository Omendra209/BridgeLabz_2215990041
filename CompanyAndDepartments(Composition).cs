using System;
using System.Collections.Generic;

// Employee class that represents an employee within a department
public class Employee
{
    public string Name { get; set; }
    public string Position { get; set; }

    // Constructor to initialize employee with name and position
    public Employee(string name, string position)
    {
        Name = name;
        Position = position;
    }

    // Method to display employee details
    public void DisplayEmployee()
    {
        Console.WriteLine("Employee Name: " + Name + ", Position: " + Position);
    }
}

// Department class that contains a list of employees
public class Department
{
    public string DepartmentName { get; set; }
    private List<Employee> employees;

    // Constructor to initialize department and employees
    public Department(string departmentName)
    {
        DepartmentName = departmentName;
        employees = new List<Employee>();
    }

    // Method to add an employee to the department
    public void AddEmployee(Employee employee)
    {
        employees.Add(employee);
        Console.WriteLine("Employee " + employee.Name + " added to " + DepartmentName + " department.");
    }

    // Method to display employees in the department
    public void DisplayEmployees()
    {
        Console.WriteLine("Employees in " + DepartmentName + " Department:");
        foreach (var employee in employees)
        {
            employee.DisplayEmployee();
        }
    }

    // Destructor to remove employees when department is deleted
    ~Department()
    {
        Console.WriteLine(DepartmentName + " department is being deleted, all employees are removed.");
    }
}

// Company class that contains multiple departments
public class Company
{
    public string CompanyName { get; set; }
    private List<Department> departments;

    // Constructor to initialize company and departments
    public Company(string companyName)
    {
        CompanyName = companyName;
        departments = new List<Department>();
    }

    // Method to add a department to the company
    public void AddDepartment(Department department)
    {
        departments.Add(department);
        Console.WriteLine("Department " + department.DepartmentName + " added to " + CompanyName + ".");
    }

    // Method to display all departments and their employees
    public void DisplayDepartments()
    {
        Console.WriteLine("Departments in " + CompanyName + ":");
        foreach (var department in departments)
        {
            department.DisplayEmployees();
        }
    }

    // Destructor to remove departments and employees when company is deleted
    ~Company()
    {
        Console.WriteLine(CompanyName + " company is being deleted, all departments and employees are removed.");
    }
}

// Main program to demonstrate the composition relationship and user interaction
public class Program
{
    public static void Main()
    {
        Company company = new Company("Tech Innovations");
        Department dept1 = new Department("HR");
        Department dept2 = new Department("Engineering");

        Employee emp1 = new Employee("John Doe", "HR Manager");
        Employee emp2 = new Employee("Jane Smith", "Software Engineer");

        // Adding departments to the company
        company.AddDepartment(dept1);
        company.AddDepartment(dept2);

        // Adding employees to departments
        dept1.AddEmployee(emp1);
        dept2.AddEmployee(emp2);

        int choice = 0;
        string name = string.Empty;
        string position = string.Empty;

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Display all departments and employees");
            Console.WriteLine("2. Add a new department");
            Console.WriteLine("3. Add a new employee");
            Console.WriteLine("4. Display employees in a department");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    // Display all departments and their employees
                    company.DisplayDepartments();
                    break;

                case 2:
                    // Add a new department to the company
                    Console.Write("Enter department name: ");
                    string deptName = Console.ReadLine();
                    Department newDept = new Department(deptName);
                    company.AddDepartment(newDept);
                    break;

                case 3:
                    // Add a new employee to a department
                    Console.Write("Enter employee name: ");
                    name = Console.ReadLine();
                    Console.Write("Enter employee position: ");
                    position = Console.ReadLine();
                    Console.Write("Enter department name: ");
                    string departmentName = Console.ReadLine();

                    // Find the department by name and add the employee
                    Department deptToAddEmployee = null;
                    foreach (var dept in company.Departments)
                    {
                        if (dept.DepartmentName == departmentName)
                        {
                            deptToAddEmployee = dept;
                            break;
                        }
                    }

                    if (deptToAddEmployee != null)
                    {
                        Employee newEmployee = new Employee(name, position);
                        deptToAddEmployee.AddEmployee(newEmployee);
                    }
                    else
                    {
                        Console.WriteLine("Department not found.");
                    }
                    break;

                case 4:
                    // Display employees in a specific department
                    Console.Write("Enter department name to view employees: ");
                    string deptToDisplay = Console.ReadLine();

                    Department deptToView = null;
                    foreach (var dept in company.Departments)
                    {
                        if (dept.DepartmentName == deptToDisplay)
                        {
                            deptToView = dept;
                            break;
                        }
                    }

                    if (deptToView != null)
                    {
                        deptToView.DisplayEmployees();
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