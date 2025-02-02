using System;

public class Circle
{
    // Field (Attribute)
    private double radius;

    // Constructor
    public Circle(double radius)
    {
        this.radius = radius;
    }

    // Method to calculate area
    public double CalculateArea()
    {
        return Math.PI * radius * radius;
    }

    // Method to calculate circumference
    public double CalculateCircumference()
    {
        return 2 * Math.PI * radius;
    }

    // Method to display area and circumference
    public void DisplayDetails()
    {
        Console.WriteLine("Circle Radius: " + radius);
        Console.WriteLine("Area: " + CalculateArea());
        Console.WriteLine("Circumference: " + CalculateCircumference());
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Create a Circle object
        Circle circle = new Circle(5);

        // Display circle details
        circle.DisplayDetails();
    }
}