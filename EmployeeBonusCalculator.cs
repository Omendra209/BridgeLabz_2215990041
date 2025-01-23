using System;

class EmployeeBonusCalculator {
    public static void Main(string[] args) {
        // Prompt user for input: salary and years of service
        Console.Write("Enter the employee's salary: ");
        double salary = double.Parse(Console.ReadLine());

        Console.Write("Enter the number of years of service: ");
        int yearsOfService = int.Parse(Console.ReadLine());

        // Check if the employee is eligible for the bonus
        if (yearsOfService > 5) {
            // If years of service is more than 5, calculate 5% bonus
            double bonus = salary * 0.05;
            // Output the bonus amount
            Console.WriteLine("The bonus amount is INR " + bonus);
        } else {
            // If years of service is 5 or less, no bonus
            Console.WriteLine("The employee is not eligible for a bonus.");
        }
    }
}
