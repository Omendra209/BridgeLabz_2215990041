using System;

class SpringSeason
{
    // Method to check if the date is in the Spring season
    public bool IsSpringSeason(int month, int day)
    {
        // Check if the date is between March 20 and June 20
        if ((month == 3 && day >= 20) || (month == 4) || (month == 5) || (month == 6 && day <= 20))
        {
            return true; // It's Spring season
        }
        return false; // Not Spring season
    }

    static void Main(string[] args)
    {
        // Check if the correct number of arguments is provided
        if (args.Length != 2)
        {
            Console.WriteLine("Please provide two integer values: month and day.");
            return;
        }

        // Parse the command line arguments
        int month = Convert.ToInt32(args[0]);
        int day = Convert.ToInt32(args[1]);

        // Instantiate the SpringSeason class
        SpringSeason springSeason = new SpringSeason();

        // Check if the date is in the Spring season
        if (springSeason.IsSpringSeason(month, day))
        {
            Console.WriteLine("It's a Spring Season.");
        }
        else
        {
            Console.WriteLine("Not a Spring Season.");
        }
    }
}