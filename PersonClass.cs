using System;

public class Person
{
    public string name;
    public int age;

    // Default constructor
    public Person()
    {
        name = "Unknown";
        age = 0;
    }

    // Parameterized constructor
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    // Copy constructor
    public Person(Person other)
    {
        this.name = other.name;
        this.age = other.age;
    }

    // Method to display person details
    public void DisplayPersonDetails()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }
}

class Program
{
    static void Main()
    {
        Person person1 = new Person("Alice", 30);
        person1.DisplayPersonDetails();

        Person person2 = new Person(person1); // Copy constructor
        person2.DisplayPersonDetails();
    }
}
