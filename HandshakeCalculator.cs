using System;

class HandshakeCalculator
{
    // Method to calculate the maximum number of handshakes
    public int CalculateHandshakes(int numberOfStudents)
    {
        return (numberOfStudents * (numberOfStudents - 1)) / 2;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Instantiate the HandshakeCalculator class
        HandshakeCalculator calculator = new HandshakeCalculator();

        // Get integer input for the number of students
        Console.Write("Enter the number of students: ");
        int numberOfStudents = Convert.ToInt32(Console.ReadLine());

        // Calculate the maximum number of handshakes
        int handshakes = calculator.CalculateHandshakes(numberOfStudents);

        // Output the result
        Console.WriteLine("The maximum number of handshakes among " + numberOfStudents + " students is " + handshakes + ".");
    }
}