using System;

public class CarRental
{
    public string customerName;
    public string carModel;
    public int rentalDays;
    public decimal rentalRate = 50.0m; // Rate per day

    // Default constructor
    public CarRental()
    {
        customerName = "Unknown";
        carModel = "Generic Car";
        rentalDays = 1;
    }

    // Parameterized constructor
    public CarRental(string customerName, string carModel, int rentalDays)
    {
        this.customerName = customerName;
        this.carModel = carModel;
        this.rentalDays = rentalDays;
    }

    // Method to calculate total cost
    public decimal CalculateTotalCost()
    {
        return rentalDays * rentalRate;
    }

    // Method to display rental details
    public void DisplayRentalDetails()
    {
        Console.WriteLine("Customer Name: " + customerName);
        Console.WriteLine("Car Model: " + carModel);
        Console.WriteLine("Rental Days: " + rentalDays);
        Console.WriteLine("Total Cost: " + CalculateTotalCost().ToString("C"));
    }
}

class Program
{
    static void Main()
    {
        CarRental rental1 = new CarRental("Sarah Smith", "Toyota Camry", 5);
        rental1.DisplayRentalDetails();
    }
}
