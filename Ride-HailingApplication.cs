using System;
using System.Collections.Generic;

// Abstract Class
abstract class Vehicle
{
    private string vehicleId;
    private string driverName;
    protected double ratePerKm;

    public Vehicle(string vehicleId, string driverName, double ratePerKm)
    {
        this.vehicleId = vehicleId;
        this.driverName = driverName;
        this.ratePerKm = ratePerKm;
    }

    public abstract double CalculateFare(double distance);

    public void GetVehicleDetails()
    {
        Console.WriteLine("Vehicle ID: " + vehicleId + ", Driver: " + driverName);
    }
}

// Interface for GPS functionality
interface IGPS
{
    string GetCurrentLocation();
    void UpdateLocation(string newLocation);
}

// Car Class
class Car : Vehicle, IGPS
{
    private string location;

    public Car(string vehicleId, string driverName, double ratePerKm) : base(vehicleId, driverName, ratePerKm) { }

    public override double CalculateFare(double distance)
    {
        return distance * ratePerKm;
    }

    public string GetCurrentLocation()
    {
        return location;
    }

    public void UpdateLocation(string newLocation)
    {
        location = newLocation;
    }
}

// Bike Class
class Bike : Vehicle, IGPS
{
    private string location;

    public Bike(string vehicleId, string driverName, double ratePerKm) : base(vehicleId, driverName, ratePerKm) { }

    public override double CalculateFare(double distance)
    {
        return distance * ratePerKm * 0.8; // Discounted rate for bikes
    }

    public string GetCurrentLocation()
    {
        return location;
    }

    public void UpdateLocation(string newLocation)
    {
        location = newLocation;
    }
}

// Auto Class
class Auto : Vehicle, IGPS
{
    private string location;

    public Auto(string vehicleId, string driverName, double ratePerKm) : base(vehicleId, driverName, ratePerKm) { }

    public override double CalculateFare(double distance)
    {
        return distance * ratePerKm * 0.9; // Slightly discounted rate for autos
    }

    public string GetCurrentLocation()
    {
        return location;
    }

    public void UpdateLocation(string newLocation)
    {
        location = newLocation;
    }
}

class Program
{
    static void Main()
    {
        List<Vehicle> vehicles = new List<Vehicle>
        {
            new Car("C001", "John Doe", 10),
            new Bike("B001", "Jane Smith", 5),
            new Auto("A001", "Mike Brown", 7)
        };

        double distance = 15; // Example distance

        foreach (Vehicle vehicle in vehicles)
        {
            vehicle.GetVehicleDetails();
            Console.WriteLine("Fare for " + distance + " km: $" + vehicle.CalculateFare(distance));
            Console.WriteLine();
        }
    }
}
