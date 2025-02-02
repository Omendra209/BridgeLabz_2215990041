using System;

public class Circle
{
    public double radius;

    // Default constructor
    public Circle() : this(1.0) { }  // Chaining to parameterized constructor with a default radius of 1.0

    // Parameterized constructor
    public Circle(double radius)
    {
        this.radius = radius;
    }

    // Method to display circle details
    public void DisplayCircleDetails()
    {
        Console.WriteLine("Radius: " + radius);
    }
}

class Program
{
    static void Main()
    {
        Circle defaultCircle = new Circle();
        defaultCircle.DisplayCircleDetails();

        Circle customCircle = new Circle(5.0);
        customCircle.DisplayCircleDetails();
    }
}
