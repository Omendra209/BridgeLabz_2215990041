using System;

class FactorialCalculatorForLoop {
    public static void Main(string[] args) {
        // Prompt user to enter a positive integer
        Console.Write("Enter a positive integer: ");
        int number = int.Parse(Console.ReadLine());

        // Check if the entered number is a natural number
        if (number < 0) {
            // If number is negative, prompt the user to enter a positive integer
            Console.WriteLine("Please enter a positive integer.");
        } else {
            // Initialize factorial result to 1 (since factorial of 0 is 1)
            int factorial = 1;

            // Use a for loop to calculate the factorial
            for (int i = 1; i <= number; i++) {
                // Multiply the current factorial value by the loop variable i
                factorial *= i;
            }

            // Print the result
            Console.WriteLine("The factorial of " + number + " is " + factorial);
        }
    }
}
