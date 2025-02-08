using System;

// Base class representing an Employee
public class Employee
{
    public string Name { get; set; }
    public int Id { get; set; }
    public double Salary { get; set; }

    public Employee(string name, int id, double salary)
    {
        Name = name;
        Id = id;
        Salary = salary;
    }

    // Virtual method to be overridden by subclasses
    public virtual void DisplayDetails()
    {
        Console.WriteLine("Name: {0}, ID: {1}, Salary: {2}", Name, Id, Salary);
    }
}

// Subclass Manager
public class Manager : Employee
{
    public int TeamSize { get; set; }

    public Manager(string name, int id, double salary, int teamSize) : base(name, id, salary)
    {
        TeamSize = teamSize;
    }

    public override void DisplayDetails()
    {
        Console.WriteLine("Name: {0}, ID: {1}, Salary: {2}, Team Size: {3}", Name, Id, Salary, TeamSize);
    }
}

// Subclass Developer
public class Developer : Employee
{
    public string ProgrammingLanguage { get; set; }

    public Developer(string name, int id, double salary, string programmingLanguage) : base(name, id, salary)
    {
        ProgrammingLanguage = programmingLanguage;
    }

    public override void DisplayDetails()
    {
        Console.WriteLine("Name: {0}, ID: {1}, Salary: {2}, Programming Language: {3}", Name, Id, Salary, ProgrammingLanguage);
    }
}

// Subclass Intern
public class Intern : Employee
{
    public string InternshipDuration { get; set; }

    public Intern(string name, int id, double salary, string internshipDuration) : base(name, id, salary)
    {
        InternshipDuration = internshipDuration;
    }

    public override void DisplayDetails()
    {
        Console.WriteLine("Name: {0}, ID: {1}, Salary: {2}, Internship Duration: {3}", Name, Id, Salary, InternshipDuration);
    }
}

// Main Program
public class Program
{
    public static void Main()
    {
        Employee manager = new Manager("Alice", 101, 75000, 10);
        Employee developer = new Developer("Bob", 102, 60000, "C#");
        Employee intern = new Intern("Charlie", 103, 20000, "6 months");

        manager.DisplayDetails();
        developer.DisplayDetails();
        intern.DisplayDetails();
    }
}
