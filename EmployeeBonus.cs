using System;

public class EmployeeBonus {
    public static void Main(string[] args) {
        // Define arrays to store the employees' salaries, years of service, bonus, and new salary
        double[] oldSalary = new double[10];
        double[] yearsOfService = new double[10];
        double[] bonus = new double[10];
        double[] newSalary = new double[10];

        // Variables to track the total bonus payout and total salary
        double totalBonus = 0;
        double totalOldSalary = 0;
        double totalNewSalary = 0;

        // Loop to take input for salaries and years of service
        for (int i = 0; i < 10; i++) {
            bool validInput = false;
            while (!validInput) {
                // Prompt the user for the salary and years of service
                Console.Write("Enter salary for employee " + (i + 1) + ": ");
                validInput = double.TryParse(Console.ReadLine(), out oldSalary[i]) && oldSalary[i] > 0;

                if (!validInput) {
                    Console.WriteLine("Invalid salary input. Please enter a valid positive number.");
                    continue;
                }

                Console.Write("Enter years of service for employee " + (i + 1) + ": ");
                validInput = double.TryParse(Console.ReadLine(), out yearsOfService[i]) && yearsOfService[i] >= 0;

                if (!validInput) {
                    Console.WriteLine("Invalid years of service input. Please enter a valid positive number.");
                }
            }
        }

        // Loop to calculate bonus, new salary, and accumulate total payouts
        for (int i = 0; i < 10; i++) {
            // Calculate the bonus based on years of service
            if (yearsOfService[i] > 5) {
                bonus[i] = oldSalary[i] * 0.05; // 5% bonus
            } else {
                bonus[i] = oldSalary[i] * 0.02; // 2% bonus
            }

            // Calculate new salary after bonus
            newSalary[i] = oldSalary[i] + bonus[i];

            // Accumulate total bonus, old salary, and new salary
            totalBonus += bonus[i];
            totalOldSalary += oldSalary[i];
            totalNewSalary += newSalary[i];
        }

        // Print the total bonus payout, total old salary, and total new salary
        Console.WriteLine("\nTotal bonus payout: " + totalBonus);
        Console.WriteLine("Total old salary: " + totalOldSalary);
        Console.WriteLine("Total new salary after bonus: " + totalNewSalary);

        // Optionally, print the details for each employee
        Console.WriteLine("\nEmployee Details:");
        for (int i = 0; i < 10; i++) {
            Console.WriteLine("Employee " + (i + 1) + ": Old Salary = " + oldSalary[i] + ", Years of Service = " + yearsOfService[i] + ", Bonus = " + bonus[i] + ", New Salary = " + newSalary[i]);
        }
    }
}