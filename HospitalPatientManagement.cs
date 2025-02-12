using System;
using System.Collections.Generic;

// Abstract class Patient
abstract class Patient
{
    protected int patientId;
    protected string name;
    protected int age;
    protected string diagnosis;

    public Patient(int id, string name, int age, string diagnosis)
    {
        this.patientId = id;
        this.name = name;
        this.age = age;
        this.diagnosis = diagnosis;
    }

    public abstract double CalculateBill();

    public void GetPatientDetails()
    {
        Console.WriteLine("Patient ID: " + patientId);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }
}

// Interface IMedicalRecord
interface IMedicalRecord
{
    void AddRecord(string record);
    void ViewRecords();
}

// InPatient subclass
class InPatient : Patient, IMedicalRecord
{
    private double dailyCharge;
    private int daysAdmitted;
    private List<string> medicalRecords = new List<string>();

    public InPatient(int id, string name, int age, string diagnosis, double dailyCharge, int daysAdmitted)
        : base(id, name, age, diagnosis)
    {
        this.dailyCharge = dailyCharge;
        this.daysAdmitted = daysAdmitted;
    }

    public override double CalculateBill()
    {
        return dailyCharge * daysAdmitted;
    }

    public void AddRecord(string record)
    {
        medicalRecords.Add(record);
    }

    public void ViewRecords()
    {
        Console.WriteLine("Medical Records for " + name + ":");
        foreach (var record in medicalRecords)
        {
            Console.WriteLine("- " + record);
        }
    }
}

// OutPatient subclass
class OutPatient : Patient, IMedicalRecord
{
    private double consultationFee;
    private List<string> medicalRecords = new List<string>();

    public OutPatient(int id, string name, int age, string diagnosis, double consultationFee)
        : base(id, name, age, diagnosis)
    {
        this.consultationFee = consultationFee;
    }

    public override double CalculateBill()
    {
        return consultationFee;
    }

    public void AddRecord(string record)
    {
        medicalRecords.Add(record);
    }

    public void ViewRecords()
    {
        Console.WriteLine("Medical Records for " + name + ":");
        foreach (var record in medicalRecords)
        {
            Console.WriteLine("- " + record);
        }
    }
}

// Main program
class Program
{
    static void Main()
    {
        Patient inPatient = new InPatient(101, "John Doe", 45, "Pneumonia", 500, 5);
        Patient outPatient = new OutPatient(102, "Jane Smith", 30, "Migraine", 100);

        inPatient.GetPatientDetails();
        Console.WriteLine("Total Bill: " + inPatient.CalculateBill());
        Console.WriteLine();

        outPatient.GetPatientDetails();
        Console.WriteLine("Total Bill: " + outPatient.CalculateBill());
    }
}
