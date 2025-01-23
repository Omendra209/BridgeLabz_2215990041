using System;

public class LeapYearChecker {
    public static void Main(string[] args) {
        // Prompt the user to enter a year and validate input.
        // Use int.TryParse to ensure only valid integers are accepted.
        Console.Write("Enter a year (>= 1582): ");
		int year;
        if (!int.TryParse(Console.ReadLine(), out year)) {
            Console.WriteLine("Invalid input. Please enter a valid integer year.");
            return;
        }

        // Check if the entered year is within the Gregorian calendar (>= 1582).
        if (year < 1582) {
            Console.WriteLine("The year must be 1582 or later.");
            return;
        }

        // First approach: Using multiple if-else statements.
        Console.WriteLine("Using multiple if-else statements:");
        if (year % 4 == 0) { 
            // Check divisibility by 4.
            if (year % 100 == 0) { 
                // If divisible by 100, check divisibility by 400.
                if (year % 400 == 0) {
                    Console.WriteLine(year + " is a Leap Year.");
                } else {
                    Console.WriteLine(year + " is not a Leap Year.");
                }
            } else {
                Console.WriteLine(year + " is a Leap Year.");
            }
        } else {
            Console.WriteLine(year + " is not a Leap Year.");
        }

        // Second approach: Using a single if statement with logical operators.
        Console.WriteLine("Using a single if statement:");
        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0)) {
            Console.WriteLine(year + " is a Leap Year.");
        } else {
            Console.WriteLine(year + " is not a Leap Year.");
        }
    }
}