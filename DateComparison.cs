using System;

class Program
{
    static void Main()
    {
        // Prompt the user to enter two dates
        Console.Write("Enter the first date (yyyy-MM-dd): ");
        string inputDate1 = Console.ReadLine();

        Console.Write("Enter the second date (yyyy-MM-dd): ");
        string inputDate2 = Console.ReadLine();

        // Convert the input strings to DateTime
        DateTime date1, date2;
        if (DateTime.TryParse(inputDate1, out date1) && DateTime.TryParse(inputDate2, out date2))
        {
            // Compare the dates
            int comparisonResult = DateTime.Compare(date1, date2);

            if (comparisonResult < 0)
            {
                Console.WriteLine("The first date is before the second date.");
            }
            else if (comparisonResult > 0)
            {
                Console.WriteLine("The first date is after the second date.");
            }
            else
            {
                Console.WriteLine("Both dates are the same.");
            }
        }
        else
        {
            Console.WriteLine("Invalid date format. Please enter dates in the format yyyy-MM-dd.");
        }
    }
}
