using System;
using System.IO;

class StudentData
{
    static string filePath = "students.dat";

    static void Main()
    {
        try
        {
            WriteStudentData();
            ReadStudentData();
        }
        catch (IOException ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }

    static void WriteStudentData()
    {
        using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
        using (BinaryWriter writer = new BinaryWriter(fs))
        {
            writer.Write(101);
            writer.Write("Alice Johnson");
            writer.Write(3.8);

            writer.Write(102);
            writer.Write("Bob Smith");
            writer.Write(3.5);
        }

        Console.WriteLine("Student data written successfully.");
    }

    static void ReadStudentData()
    {
        if (!File.Exists(filePath))
        {
            Console.WriteLine("No data found.");
            return;
        }

        using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
        using (BinaryReader reader = new BinaryReader(fs))
        {
            Console.WriteLine("Retrieved Student Data:");
            while (fs.Position < fs.Length)
            {
                int rollNumber = reader.ReadInt32();
                string name = reader.ReadString();
                double gpa = reader.ReadDouble();
                Console.WriteLine("Roll No: " + rollNumber + ", Name: " + name + ", GPA: " + gpa);
            }
        }
    }
}
