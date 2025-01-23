using System;

class StudentGrade
{
    static void Main(string[] args)
    {
        // Prompt the user to input marks for three subjects
        Console.WriteLine("Enter marks for Physics:");
        double physics = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter marks for Chemistry:");
        double chemistry = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter marks for Math:");
        double math = double.Parse(Console.ReadLine());

        // Calculate the total and percentage
        double totalMarks = physics + chemistry + math;
        double percentage = totalMarks / 3;

        // Variables to store grade and remarks
        string grade = "";
        string remarks = "";

        // Determine the grade and remarks based on percentage
        if (percentage >= 80)
        {
            grade = "A";
            remarks = "Level 4, above agency-normalized standards";
        }
        else if (percentage >= 70)
        {
            grade = "B";
            remarks = "Level 3, at agency-normalized standards";
        }
        else if (percentage >= 60)
        {
            grade = "C";
            remarks = "Level 2, below but approaching agency-normalized standards";
        }
        else if (percentage >= 50)
        {
            grade = "D";
            remarks = "Level 2, well below agency-normalized standards";
        }
        else if (percentage >= 40)
        {
            grade = "E";
            remarks = "Level 1, too below agency-normalized standards";
        }
        else
        {
            grade = "R";
            remarks = "Remedial standards";
        }

        // Display the results
        Console.WriteLine("Total Marks: " + totalMarks);
        Console.WriteLine("Percentage: " + percentage.ToString("F2") + "%");
        Console.WriteLine("Grade: " + grade);
        Console.WriteLine("Remarks: " + remarks);
    }
}