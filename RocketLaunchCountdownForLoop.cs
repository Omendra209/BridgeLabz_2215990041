// Program to count down for a rocket launch using a for loop
using System;

class RocketLaunchCountdownForLoop {
    public static void Main(string[] args) {
        // Prompt the user for the countdown start value
        Console.Write("Enter the countdown starting number: ");
        int counter = int.Parse(Console.ReadLine());

        // Perform the countdown using a for loop
        for (int i = counter; i > 0; i--) {
            // Print the current value of the counter
            Console.WriteLine(i);
        }

        // Print the launch message
        Console.WriteLine("Liftoff! Rocket has been launched.");
    }
}