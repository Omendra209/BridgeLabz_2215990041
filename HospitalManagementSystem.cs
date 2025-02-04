using System;

class Patient
{
    // Static variable shared by all instances of Patient class for Hospital Name
    public static string HospitalName = "City Hospital";

    // Static variable to track the total number of patients admitted
    private static int totalPatients = 0;

    // Readonly variable for PatientID (cannot be changed after assignment)
    private readonly int patientID;

    // Instance variables for patient details
    private string name;
    private int age;
    private string ailment;

    // Static method to get the total number of patients admitted
    public static void GetTotalPatients()
    {
        Console.WriteLine("Total Patients Admitted: " + totalPatients);
    }

    // Constructor to initialize the patient details
    public Patient(string name, int age, string ailment, int patientID)
    {
        this.name = name;                // Initialize patient name
        this.age = age;                   // Initialize patient age
        this.ailment = ailment;           // Initialize patient ailment
        this.patientID = patientID;       // Initialize patient ID (readonly)

        totalPatients++;                  // Increment total patient count
    }

    // Method to display patient details
    public void DisplayPatientDetails()
    {
        Console.WriteLine("Hospital Name: " + HospitalName);
        Console.WriteLine("Patient Name: " + name);
        Console.WriteLine("Patient Age: " + age);
        Console.WriteLine("Patient Ailment: " + ailment);
        Console.WriteLine("Patient ID: " + patientID);
    }
}

public class HospitalManagementSystem
{
    public static void Main()
    {
        // Creating instances of Patient
        Patient patient1 = new Patient("Alice", 30, "Fever", 101);
        Patient patient2 = new Patient("Bob", 45, "Asthma", 102);

        // Display the total number of patients admitted
        Patient.GetTotalPatients();

        // Display patient details
        patient1.DisplayPatientDetails();
        patient2.DisplayPatientDetails();

        // Using 'is' operator to check if the objects are instances of Patient class
        if (patient1 is Patient)
        {
            Console.WriteLine("\npatient1 is an instance of Patient class.");
        }

        if (patient2 is Patient)
        {
            Console.WriteLine("patient2 is an instance of Patient class.");
        }
    }
}
