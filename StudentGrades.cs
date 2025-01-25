using System;

public class StudentGrades {
    public static void Main(string[] args) {
        // Taking input for the number of students
        Console.Write("Enter the number of students: ");
        int numStudents = int.Parse(Console.ReadLine());

        // Arrays to store marks, percentage, and grade for each student
        double[] physicsMarks = new double[numStudents];
        double[] chemistryMarks = new double[numStudents];
        double[] mathsMarks = new double[numStudents];
        double[] percentage = new double[numStudents];
        string[] grades = new string[numStudents];

        // Taking input for marks for each student
        for (int i = 0; i < numStudents; i++) {
            Console.WriteLine("Enter marks for student " + (i + 1) + ":");
            
            // Input and validation for physics marks
            physicsMarks[i] = GetValidMarks("Physics");

            // Input and validation for chemistry marks
            chemistryMarks[i] = GetValidMarks("Chemistry");

            // Input and validation for maths marks
            mathsMarks[i] = GetValidMarks("Maths");

            // Calculate percentage
            percentage[i] = (physicsMarks[i] + chemistryMarks[i] + mathsMarks[i]) / 3;

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
            Console.WriteLine((i + 1) + "        | " + physicsMarks[i] + "      | " + chemistryMarks[i] + "        | " + mathsMarks[i] + "    | " + percentage[i] + "%     | " + grades[i]);
        }
    }

    // Method to get valid marks (positive value)
    public static double GetValidMarks(string subject) {
        double marks;
        while (true) {
            Console.Write("Enter marks for " + subject + ": ");
            marks = double.Parse(Console.ReadLine());

            if (marks >= 0) {
                break; // Valid marks
            } else {
                Console.WriteLine("Marks cannot be negative. Please enter a valid value.");
            }
        }
        return marks;
    }
}
