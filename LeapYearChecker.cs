using System;

class LeapYearChecker
{
    // Method to check if a year is a leap year
    public static bool IsLeapYear(int year)
    {
        // Check if the year is less than 1582
        if (year < 1582)
        {
            Console.WriteLine("Leap Year calculation is only valid for years 1582 and later.");
            return false;
        }

        // Check the leap year conditions
        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            return true; // It's a leap year
        }
        return false; // Not a leap year
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Get user input for the year
        Console.Write("Enter a year: ");
        if (!int.TryParse(Console.ReadLine(), out int year))
        {
            Console.WriteLine("Please enter a valid integer for the year.");
            return; // Exit if input is not a valid integer
        }

        // Check if the year is a leap year
        bool isLeapYear = LeapYearChecker.IsLeapYear(year);

        // Display the result
        if (isLeapYear)
        {
            Console.WriteLine(year + " is a Leap Year.");
        }
        else
        {
            Console.WriteLine(year + " is not a Leap Year.");
        }
    }
}