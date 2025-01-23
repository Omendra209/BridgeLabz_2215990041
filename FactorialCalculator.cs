using System;

class FactorialCalculator {
    public static void Main(string[] args) {
        // Prompt user for input
        Console.Write("Enter a positive integer: ");
        int number = int.Parse(Console.ReadLine());

        // Check if the number is positive
        if (number < 0) {
            Console.WriteLine("Please enter a positive integer.");
        } else {
            // Initialize factorial result to 1
            int factorial = 1;

            // Use a while loop to compute the factorial
            int i = 1;
            while (i <= number) {
                factorial *= i; // Multiply factorial by i
                i++; // Increment i
            }

            // Print the result
            Console.WriteLine("The factorial of " + number + " is " + factorial);
        }
    }
}
