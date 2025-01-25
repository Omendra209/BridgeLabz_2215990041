using System;

class MeanHeightCalculator
{
    static void Main(string[] args)
    {
        // Define an array to store the heights of 11 players
        double[] heights = new double[11];
        double sum = 0.0;

        // Prompt the user to enter the heights
        Console.WriteLine("Enter the heights of 11 football players (in cm):");

        // Loop to get input values and calculate the sum
        for (int i = 0; i < 11; i++)
        {
            Console.Write("Enter height of player " + (i + 1) + ": ");
            heights[i] = double.Parse(Console.ReadLine());
            sum += heights[i]; // Add the height to the sum
        }

        // Calculate the mean height
        double mean = sum / 11;

        // Print the mean height
        Console.WriteLine("\nThe mean height of the football team is: " + mean + " cm");
    }
}
