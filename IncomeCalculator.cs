// Program to calculate the total income by taking salary and bonus as input
using System;

class IncomeCalculator {
    public static void Main(string[] args) {
        // Prompt user for the salary
        Console.Write("Enter the salary (INR): ");
        double salary = Convert.ToDouble(Console.ReadLine());

        // Prompt user for the bonus
        Console.Write("Enter the bonus (INR): ");
        double bonus = Convert.ToDouble(Console.ReadLine());

        // Calculate the total income
        double totalIncome = salary + bonus;

        // Output the result
        Console.WriteLine("The salary is INR " + salary + " and bonus is INR " + bonus + ". Hence Total Income is INR " + totalIncome);
    }
}
