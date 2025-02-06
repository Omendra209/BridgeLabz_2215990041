using System;
using System.Collections.Generic;

// Patient class represents a patient who can consult multiple doctors
public class Patient
{
    public string Name { get; set; }
    public int Age { get; set; }
    private List<Doctor> doctors;

    // Constructor to initialize patient details
    public Patient(string name, int age)
    {
        Name = name;
        Age = age;
        doctors = new List<Doctor>();
    }

    // Method to consult a doctor
    public void Consult(Doctor doctor)
    {
        doctors.Add(doctor);
        doctor.Consult(this);
    }

    // Method to display patient details
    public void DisplayPatient()
    {
        Console.WriteLine("Patient Name: " + Name + ", Age: " + Age);
    }

    // Method to display the doctors that the patient has consulted
    public void DisplayDoctors()
    {
        Console.WriteLine(Name + " has consulted the following doctors:");
        foreach (var doctor in doctors)
        {
            doctor.DisplayDoctor();
        }
    }
}

// Doctor class represents a doctor who can consult multiple patients
public class Doctor
{
    public string Name { get; set; }
    public string Specialty { get; set; }
    private List<Patient> patients;

    // Constructor to initialize doctor details
    public Doctor(string name, string specialty)
    {
        Name = name;
        Specialty = specialty;
        patients = new List<Patient>();
    }

    // Method to consult a patient
    public void Consult(Patient patient)
    {
        patients.Add(patient);
        Console.WriteLine(Name + " is consulting with " + patient.Name + " for a " + Specialty + " issue.");
    }

    // Method to display doctor details
    public void DisplayDoctor()
    {
        Console.WriteLine("Doctor Name: " + Name + ", Specialty: " + Specialty);
    }

    // Method to display all patients a doctor has consulted
    public void DisplayPatients()
    {
        Console.WriteLine(Name + " has consulted the following patients:");
        foreach (var patient in patients)
        {
            patient.DisplayPatient();
        }
    }
}

// Hospital class represents the hospital containing doctors and patients
public class Hospital
{
    public string HospitalName { get; set; }
    private List<Doctor> doctors;
    private List<Patient> patients;

    // Constructor to initialize hospital name, doctors, and patients list
    public Hospital(string hospitalName)
    {
        HospitalName = hospitalName;
        doctors = new List<Doctor>();
        patients = new List<Patient>();
    }

    // Method to add a doctor to the hospital
    public void AddDoctor(Doctor doctor)
    {
        doctors.Add(doctor);
        Console.WriteLine(doctor.Name + " has been added to " + HospitalName + " hospital.");
    }

    // Method to add a patient to the hospital
    public void AddPatient(Patient patient)
    {
        patients.Add(patient);
        Console.WriteLine(patient.Name + " has been added to " + HospitalName + " hospital.");
    }

    // Method to display all doctors and patients in the hospital
    public void DisplayHospitalInfo()
    {
        Console.WriteLine("Hospital: " + HospitalName);
        Console.WriteLine("Doctors in the hospital:");
        foreach (var doctor in doctors)
        {
            doctor.DisplayDoctor();
        }
        Console.WriteLine("Patients in the hospital:");
        foreach (var patient in patients)
        {
            patient.DisplayPatient();
        }
    }
}

// Main program to demonstrate the relationships and user interaction
public class Program
{
    public static void Main()
    {
        // Creating a hospital
        Hospital hospital = new Hospital("City Hospital");

        // Creating doctors
        Doctor doctor1 = new Doctor("Dr. Alice", "Cardiology");
        Doctor doctor2 = new Doctor("Dr. Bob", "Neurology");

        // Creating patients
        Patient patient1 = new Patient("John Doe", 30);
        Patient patient2 = new Patient("Jane Smith", 25);

        // Adding doctors and patients to the hospital
        hospital.AddDoctor(doctor1);
        hospital.AddDoctor(doctor2);
        hospital.AddPatient(patient1);
        hospital.AddPatient(patient2);

        // Simulating consultations
        patient1.Consult(doctor1); // John Doe consults Dr. Alice
        patient1.Consult(doctor2); // John Doe consults Dr. Bob
        patient2.Consult(doctor1); // Jane Smith consults Dr. Alice

        // Display hospital information (doctors and patients)
        hospital.DisplayHospitalInfo();

        int choice = 0;
        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Display all hospital information");
            Console.WriteLine("2. Display doctors for a patient");
            Console.WriteLine("3. Display patients for a doctor");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    // Display all hospital information (doctors and patients)
                    hospital.DisplayHospitalInfo();
                    break;

                case 2:
                    // Display all doctors a patient has consulted
                    Console.Write("Enter patient name to view their doctors: ");
                    string patientName = Console.ReadLine();

                    Patient patientToDisplay = null;
                    foreach (var patient in hospital.patients)
                    {
                        if (patient.Name == patientName)
                        {
                            patientToDisplay = patient;
                            break;
                        }
                    }

                    if (patientToDisplay != null)
                    {
                        patientToDisplay.DisplayDoctors();
                    }
                    else
                    {
                        Console.WriteLine("Patient not found.");
                    }
                    break;

                case 3:
                    // Display all patients a doctor has consulted
                    Console.Write("Enter doctor name to view their patients: ");
                    string doctorName = Console.ReadLine();

                    Doctor doctorToDisplay = null;
                    foreach (var doctor in hospital.doctors)
                    {
                        if (doctor.Name == doctorName)
                        {
                            doctorToDisplay = doctor;
                            break;
                        }
                    }

                    if (doctorToDisplay != null)
                    {
                        doctorToDisplay.DisplayPatients();
                    }
                    else
                    {
                        Console.WriteLine("Doctor not found.");
                    }
                    break;

                case 0:
                    // Exit the program
                    Console.WriteLine("Exiting the program.");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}