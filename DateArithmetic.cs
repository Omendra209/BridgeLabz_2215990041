using System;

class Program
{
    static void Main()
    {
        // Prompt the user to enter a date
        Console.Write("Enter a date (yyyy-MM-dd): ");
        string inputDate = Console.ReadLine();

        // Convert the input string to DateTime
        DateTime startDate;
        if (DateTime.TryParse(inputDate, out startDate))
        {
            // Add 7 days, 1 month, and 2 years to the start date
            DateTime resultDate = startDate.AddDays(7).AddMonths(1).AddYears(2);

            // Subtract 3 weeks (21 days) from the result date
            resultDate = resultDate.AddDays(-21);

            // Display the final result
            Console.WriteLine("Original Date: " + startDate.ToString("yyyy-MM-dd"));
            Console.WriteLine("Final Date after arithmetic: " + resultDate.ToString("yyyy-MM-dd"));
        }
        else
        {
            Console.WriteLine("Invalid date format. Please use the format yyyy-MM-dd.");
        }
    }
}