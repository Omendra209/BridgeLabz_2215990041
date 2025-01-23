// Program to find the sum of n natural numbers using for loop and compare it with the formula
using System;

class SumOfNaturalNumbersForLoop {
    public static void Main(string[] args) {
        // Prompt user for input
        Console.Write("Enter a natural number: ");
        int n = int.Parse(Console.ReadLine());

        // Check if the number is a natural number
        if (n <= 0) {
            Console.WriteLine(n+" is not a natural number.");
        } else {
            // Calculate sum using for loop
            int sumForLoop = 0;
            for (int i = 1; i <= n; i++) {
                sumForLoop += i;
            }

            // Calculate sum using formula n*(n+1)/2
            int sumFormula = n * (n + 1) / 2;

            // Display results
            Console.WriteLine("The sum of the first "+n+" natural numbers using for loop is: "+sumForLoop);
            Console.WriteLine("The sum of the first "+n+" natural numbers using the formula n*(n+1)/2 is: "+sumFormula);

            // Compare the results
            if (sumForLoop == sumFormula) {
                Console.WriteLine("The results match, both methods are correct!");
            } else {
                Console.WriteLine("The results do not match.");
            }
        }
    }
}