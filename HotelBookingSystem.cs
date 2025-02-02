using System;

public class HotelBooking
{
    public string guestName;
    public string roomType;
    public int nights;

    // Default constructor
    public HotelBooking()
    {
        guestName = "Guest";
        roomType = "Standard";
        nights = 1;
    }

    // Parameterized constructor
    public HotelBooking(string guestName, string roomType, int nights)
    {
        this.guestName = guestName;
        this.roomType = roomType;
        this.nights = nights;
    }

    // Copy constructor
    public HotelBooking(HotelBooking other)
    {
        this.guestName = other.guestName;
        this.roomType = other.roomType;
        this.nights = other.nights;
    }

    // Method to display booking details
    public void DisplayBookingDetails()
    {
        Console.WriteLine("Guest Name: " + guestName);
        Console.WriteLine("Room Type: " + roomType);
        Console.WriteLine("Nights: " + nights);
    }
}

class Program
{
    static void Main()
    {
        HotelBooking booking1 = new HotelBooking("John Doe", "Suite", 3);
        booking1.DisplayBookingDetails();

        HotelBooking booking2 = new HotelBooking(booking1); // Copy constructor
        booking2.DisplayBookingDetails();
    }
}
