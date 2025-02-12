using System;
using System.Collections.Generic;

// Abstract class Vehicle
abstract class Vehicle
{
    protected string vehicleNumber;
    protected string type;
    protected double rentalRate;

    public Vehicle(string vehicleNumber, string type, double rentalRate)
    {
        this.vehicleNumber = vehicleNumber;
        this.type = type;
        this.rentalRate = rentalRate;
    }

    public abstract double CalculateRentalCost(int days);
    public virtual void DisplayDetails()
    {
        Console.WriteLine("Vehicle Number: " + vehicleNumber);
        Console.WriteLine("Type: " + type);
        Console.WriteLine("Rental Rate: " + rentalRate);
    }
}

// Interface IInsurable
interface IInsurable
{
    double CalculateInsurance();
    string GetInsuranceDetails();
}

// Car class
class Car : Vehicle, IInsurable
{
    public Car(string vehicleNumber, double rentalRate) : base(vehicleNumber, "Car", rentalRate) { }

    public override double CalculateRentalCost(int days)
    {
        return days * rentalRate;
    }

    public double CalculateInsurance()
    {
        return rentalRate * 0.1;
    }

    public string GetInsuranceDetails()
    {
        return "Car insurance covers basic damages.";
    }
}

// Bike class
class Bike : Vehicle
{
    public Bike(string vehicleNumber, double rentalRate) : base(vehicleNumber, "Bike", rentalRate) { }

    public override double CalculateRentalCost(int days)
    {
        return days * rentalRate * 0.8;
    }
}

// Truck class
class Truck : Vehicle, IInsurable
{
    public Truck(string vehicleNumber, double rentalRate) : base(vehicleNumber, "Truck", rentalRate) { }

    public override double CalculateRentalCost(int days)
    {
        return days * rentalRate * 1.5;
    }

    public double CalculateInsurance()
    {
        return rentalRate * 0.2;
    }

    public string GetInsuranceDetails()
    {
        return "Truck insurance covers extended cargo damage.";
    }
}

// Main Program
class Program
{
    static void Main()
    {
        List<Vehicle> vehicles = new List<Vehicle>
        {
            new Car("C123", 50),
            new Bike("B456", 30),
            new Truck("T789", 100)
        };

        foreach (var vehicle in vehicles)
        {
            vehicle.DisplayDetails();
            Console.WriteLine("Rental Cost for 5 days: " + vehicle.CalculateRentalCost(5));

            if (vehicle is IInsurable insurable)
            {
                Console.WriteLine("Insurance Cost: " + insurable.CalculateInsurance());
                Console.WriteLine("Insurance Details: " + insurable.GetInsuranceDetails());
            }

            Console.WriteLine();
        }
    }
}
