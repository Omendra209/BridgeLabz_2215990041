using System;

class Vehicle
{
    // Instance variables
    private string ownerName;
    private string vehicleType;

    // Class variable (shared among all instances)
    private static double registrationFee = 1000;

    // Default constructor
    public Vehicle()
    {
        this.ownerName = "Unknown";
        this.vehicleType = "Unknown";
    }

    // Parameterized constructor
    public Vehicle(string ownerName, string vehicleType)
    {
        this.ownerName = ownerName;
        this.vehicleType = vehicleType;
    }

    // Instance method to display vehicle details
    public void DisplayVehicleDetails()
    {
        Console.WriteLine("Owner Name: " + ownerName);
        Console.WriteLine("Vehicle Type: " + vehicleType);
        Console.WriteLine("Registration Fee: " + registrationFee);
        Console.WriteLine();
    }

    // Class method to update the registration fee
    public static void UpdateRegistrationFee(double newFee)
    {
        registrationFee = newFee;
    }
}

class Program
{
    static void PrintVehicleDetails(Vehicle vehicle)
    {
        vehicle.DisplayVehicleDetails();
    }

    static void Main()
    {
        // Creating vehicle objects with different constructors
        Vehicle v1 = new Vehicle("John Doe", "Car");
        Vehicle v2 = new Vehicle("Jane Smith", "Motorcycle");
        Vehicle v3 = new Vehicle(); // Default values

        // Displaying initial details
        Console.WriteLine("Before updating registration fee:");
        PrintVehicleDetails(v1);
        PrintVehicleDetails(v2);
        PrintVehicleDetails(v3);

        // Updating registration fee
        Vehicle.UpdateRegistrationFee(1200);

        // Displaying updated details
        Console.WriteLine("After updating registration fee:");
        PrintVehicleDetails(v1);
        PrintVehicleDetails(v2);
        PrintVehicleDetails(v3);
    }
}
