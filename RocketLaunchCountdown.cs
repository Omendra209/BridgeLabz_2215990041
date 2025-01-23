// Program to count down for a rocket launch
using System;

class RocketLaunchCountdown {
    public static void Main(string[] args) {
        // Prompt the user for the countdown start value
        Console.Write("Enter the countdown starting number: ");
        int counter = int.Parse(Console.ReadLine());

        // Perform the countdown using a while loop
        while (counter > 0) {
            // Print the current value of the counter
            Console.WriteLine(counter);

            // Decrement the counter
            counter--;
        }

        // Print the launch message
        Console.WriteLine("Liftoff! Rocket has been launched.");
    }
}