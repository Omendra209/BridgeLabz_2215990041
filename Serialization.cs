using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public double Salary { get; set; }

    public Employee(int id, string name, string department, double salary)
    {
        Id = id;
        Name = name;
        Department = department;
        Salary = salary;
    }
}

class EmployeeManager
{
    static string filePath = "employees.json";

    static void Main()
    {
        List<Employee> employees = new List<Employee>();

        try
        {
            employees.Add(new Employee(1, "John Doe", "HR", 50000));
            employees.Add(new Employee(2, "Jane Smith", "IT", 70000));
            employees.Add(new Employee(3, "Alice Johnson", "Finance", 60000));

            SerializeEmployees(employees);
            Console.WriteLine("Employees saved successfully.\n");

            List<Employee> retrievedEmployees = DeserializeEmployees();
            Console.WriteLine("Retrieved Employees:");
            foreach (Employee emp in retrievedEmployees)
            {
                Console.WriteLine("ID: " + emp.Id + ", Name: " + emp.Name + ", Department: " + emp.Department + ", Salary: " + emp.Salary);
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }

    static void SerializeEmployees(List<Employee> employees)
    {
        string jsonString = JsonSerializer.Serialize(employees, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(filePath, jsonString);
    }

    static List<Employee> DeserializeEmployees()
    {
        if (!File.Exists(filePath))
        {
            Console.WriteLine("No data found.");
            return new List<Employee>();
        }

        string jsonString = File.ReadAllText(filePath);
        return JsonSerializer.Deserialize<List<Employee>>(jsonString) ?? new List<Employee>();
    }
}
