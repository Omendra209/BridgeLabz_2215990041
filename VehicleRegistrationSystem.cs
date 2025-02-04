using System;

class Vehicle
{
    // Static variable shared by all instances of Vehicle for Registration Fee
    public static double RegistrationFee = 100.0; // Common registration fee for all vehicles

    // Readonly variable for RegistrationNumber (cannot be changed after assignment)
    private readonly string registrationNumber;

    // Instance variables for vehicle details
    private string ownerName;
    private string vehicleType;

    // Static method to update the registration fee for all vehicles
    public static void UpdateRegistrationFee(double newFee)
    {
        RegistrationFee = newFee;
        Console.WriteLine("Registration fee updated to: $" + RegistrationFee);
    }

    // Constructor to initialize the vehicle details
    public Vehicle(string ownerName, string vehicleType, string registrationNumber)
    {
        this.ownerName = ownerName;          // Initialize owner name
        this.vehicleType = vehicleType;      // Initialize vehicle type
        this.registrationNumber = registrationNumber; // Initialize registration number (readonly)
    }

    // Method to display vehicle registration details
    public void DisplayVehicleDetails()
    {
        Console.WriteLine("Owner Name: " + ownerName);
        Console.WriteLine("Vehicle Type: " + vehicleType);
        Console.WriteLine("Registration Number: " + registrationNumber);
        Console.WriteLine("Registration Fee: $" + RegistrationFee);
    }
}

public class VehicleRegistrationSystem
{
    public static void Main()
    {
        // Creating instances of Vehicle
        Vehicle vehicle1 = new Vehicle("John Doe", "Car", "ABC123");
        Vehicle vehicle2 = new Vehicle("Jane Smith", "Motorcycle", "XYZ789");

        // Display vehicle registration details before updating the fee
        Console.WriteLine("Before updating the registration fee:\n");
        vehicle1.DisplayVehicleDetails();
        vehicle2.DisplayVehicleDetails();

        // Update the registration fee for all vehicles
        Vehicle.UpdateRegistrationFee(150.0);

        // Display vehicle registration details after updating the fee
        Console.WriteLine("\nAfter updating the registration fee:\n");
        vehicle1.DisplayVehicleDetails();
        vehicle2.DisplayVehicleDetails();

        // Using 'is' operator to check if the objects are instances of Vehicle class
        if (vehicle1 is Vehicle)
        {
            Console.WriteLine("\nvehicle1 is an instance of Vehicle class.");
        }

        if (vehicle2 is Vehicle)
        {
            Console.WriteLine("vehicle2 is an instance of Vehicle class.");
        }
    }
}
