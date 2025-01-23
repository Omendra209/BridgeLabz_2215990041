// Program to check voting eligibility based on age
using System;

class VotingEligibilityChecker {
    public static void Main(string[] args) {
        // Prompt the user for age input
        Console.Write("Enter the age of the person: ");
        int age = int.Parse(Console.ReadLine());

        // Check if the person's age is 18 or older
        if (age >= 18) {
            // Display the result for eligible voter
            Console.WriteLine("The person's age is " + age + " and can vote.");
        } else {
            // Display the result for ineligible voter
            Console.WriteLine("The person's age is " + age + " and cannot vote.");
        }
    }
}
