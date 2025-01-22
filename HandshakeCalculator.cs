// Program to calculate the maximum number of handshakes among N students
using System;

class HandshakeCalculator {
    public static void Main(string[] args) {
        // Prompt user for the number of students
        Console.Write("Enter the number of students: ");
        int numberOfStudents = Convert.ToInt32(Console.ReadLine());

        // Calculate the maximum number of handshakes using the formula
        int maxHandshakes = (numberOfStudents * (numberOfStudents - 1)) / 2;

        // Output the result
        Console.WriteLine("The maximum number of possible handshakes is " + maxHandshakes);
    }
}
