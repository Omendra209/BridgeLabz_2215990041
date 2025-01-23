// Program to check if the given date is in the Spring season
using System;

class SpringSeasonChecker {
    public static void Main(string[] args) {
        // Prompt the user for input
        Console.Write("Enter the month (as a number 1-12): ");
        int month = int.Parse(Console.ReadLine());
        
        Console.Write("Enter the day (as a number): ");
        int day = int.Parse(Console.ReadLine());

        // Check if the date falls in the Spring season
        if ((month == 3 && day >= 20 && day <= 31) || 
            (month == 4 && day >= 1 && day <= 30) || 
            (month == 5 && day >= 1 && day <= 31) || 
            (month == 6 && day >= 1 && day <= 20)) {
            // Display the result for Spring season
            Console.WriteLine("It's a Spring Season.");
        } else {
            // Display the result for non-Spring season
            Console.WriteLine("Not a Spring Season.");
        }
    }
}