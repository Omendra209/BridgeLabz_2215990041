using System;
using System.Collections.Generic;

// Class representing a Subject
public class Subject
{
    public string Name { get; set; }
    public int Marks { get; set; }

    public Subject(string name, int marks)
    {
        Name = name;
        Marks = marks;
    }
}

// Class representing a Student
public class Student
{
    public string Name { get; set; }
    private List<Subject> subjects = new List<Subject>();

    public Student(string name)
    {
        Name = name;
    }

    public void AddSubject(string subjectName, int marks)
    {
        subjects.Add(new Subject(subjectName, marks));
    }

    public List<Subject> GetSubjects()
    {
        return subjects;
    }
}

// Class to calculate grades
public class GradeCalculator
{
    public static double CalculateAverage(Student student)
    {
        List<Subject> subjects = student.GetSubjects();
        int totalMarks = 0;
        foreach (Subject subject in subjects)
        {
            totalMarks += subject.Marks;
        }
        return subjects.Count > 0 ? (double)totalMarks / subjects.Count : 0;
    }

    public static string GetGrade(double average)
    {
        if (average >= 90)
            return "A";
        else if (average >= 80)
            return "B";
        else if (average >= 70)
            return "C";
        else if (average >= 60)
            return "D";
        else
            return "F";
    }
}

// Main Program
public class Program
{
    public static void Main()
    {
        Console.Write("Enter Student Name: ");
        string studentName = Console.ReadLine();
        Student student = new Student(studentName);

        while (true)
        {
            Console.WriteLine("Enter Subject Name (or type 'exit' to finish): ");
            string subjectName = Console.ReadLine();
            if (subjectName.ToLower() == "exit")
            {
                break;
            }

            Console.Write("Enter Marks: ");
            int marks = int.Parse(Console.ReadLine());
            student.AddSubject(subjectName, marks);
        }

        double average = GradeCalculator.CalculateAverage(student);
        string grade = GradeCalculator.GetGrade(average);

        Console.WriteLine("Student Name: {0}", student.Name);
        Console.WriteLine("Subjects and Marks:");
        foreach (Subject subject in student.GetSubjects())
        {
            Console.WriteLine("{0}: {1}", subject.Name, subject.Marks);
        }
        Console.WriteLine("Average Marks: {0}", average);
        Console.WriteLine("Final Grade: {0}", grade);
    }
}