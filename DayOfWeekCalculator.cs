using System;

class DayOfWeekCalculator
{
    static void Main(string[] args)
    {
        // Check if the user has provided enough arguments
        if (args.Length != 3)
        {
            Console.WriteLine("Please provide the date as three arguments: month day year.");
            return;
        }

        // Parse the input arguments
        int month = int.Parse(args[0]);
        int day = int.Parse(args[1]);
        int year = int.Parse(args[2]);

        // Calculate intermediate values based on the formulas
        int y0 = year - (14 - month) / 12;
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
        int m0 = month + 12 * ((14 - month) / 12) - 2;
        int d0 = (day + x + 31 * m0 / 12) % 7;

        // Output the result
        Console.WriteLine("The day of the week for the date {0}/{1}/{2} is {3}.", month, day, year, d0);
    }
}
