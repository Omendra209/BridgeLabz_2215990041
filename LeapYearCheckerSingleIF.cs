using System;

public class LeapYearCheckerSingleIF {
    public static void Main(string[] args) {
        // Prompt the user to enter a year and validate input
        Console.Write("Enter a year (>= 1582): ");
		int year;
        if (!int.TryParse(Console.ReadLine(), out year)) {
            Console.WriteLine("Invalid input. Please enter a valid integer year.");
            return; // Exit if the input is invalid
        }

        // Ensure the year is within the Gregorian calendar
        if (year < 1582) {
            Console.WriteLine("The year must be 1582 or later.");
            return; // Exit if the year is less than 1582
        }

        // Single if condition using logical operators to determine if it's a leap year
        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0)) {
            // Leap year condition: divisible by 4 but not 100, OR divisible by 400
            Console.WriteLine(year + " is a Leap Year.");
        } else {
            // If not meeting the above condition, it's not a leap year
            Console.WriteLine(year + " is not a Leap Year.");
        }
    }
}
