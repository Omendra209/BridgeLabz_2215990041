using System;

public class StudentGrades2DArray {
    public static void Main(string[] args) {
        // Taking input for the number of students
        Console.Write("Enter the number of students: ");
        int numStudents;
        
        // Using TryParse to validate the number of students
        while (!int.TryParse(Console.ReadLine(), out numStudents) || numStudents <= 0) {
            Console.WriteLine("Invalid input. Please enter a positive number for students.");
        }

        // Create a 2D array to store marks for Physics, Chemistry, and Maths
        double[,] marks = new double[numStudents, 3]; // Rows represent students, columns represent subjects
        double[] percentage = new double[numStudents]; // Store the percentage for each student
        string[] grades = new string[numStudents]; // Store the grade for each student

        // Taking input for marks for each student
        for (int i = 0; i < numStudents; i++) {
            Console.WriteLine("Enter marks for student " + (i + 1) + ":");
            
            // Input and validation for physics marks
            marks[i, 0] = GetValidMarks("Physics");

            // Input and validation for chemistry marks
            marks[i, 1] = GetValidMarks("Chemistry");

            // Input and validation for maths marks
            marks[i, 2] = GetValidMarks("Maths");

            // Calculate percentage
            percentage[i] = (marks[i, 0] + marks[i, 1] + marks[i, 2]) / 3;

            // Determine grade based on percentage
            if (percentage[i] >= 80) {
                grades[i] = "A";
            } else if (percentage[i] >= 70) {
                grades[i] = "B";
            } else if (percentage[i] >= 60) {
                grades[i] = "C";
            } else if (percentage[i] >= 50) {
                grades[i] = "D";
            } else if (percentage[i] >= 40) {
                grades[i] = "Level 1";
            } else {
                grades[i] = "Level 1-";
            }
        }

        // Display the results for each student
        Console.WriteLine("\nStudent Report:");
        Console.WriteLine("Student | Physics | Chemistry | Maths | Percentage | Grade");

        for (int i = 0; i < numStudents; i++) {
            Console.WriteLine((i + 1) + "        | " + marks[i, 0] + "      | " + marks[i, 1] + "        | " + marks[i, 2] + "    | " + percentage[i] + "%     | " + grades[i]);
        }
    }

    // Method to get valid marks using TryParse
    public static double GetValidMarks(string subject) {
        double marks;
        while (true) {
            Console.Write("Enter marks for " + subject + ": ");
            if (double.TryParse(Console.ReadLine(), out marks) && marks >= 0) {
                break; // Valid marks
            } else {
                Console.WriteLine("Invalid input. Please enter a positive numeric value.");
            }
        }
        return marks;
    }
}
