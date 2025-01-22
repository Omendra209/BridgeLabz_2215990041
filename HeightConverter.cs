// Program to convert height in centimeters to feet and inches
using System;

class HeightConverter {
    public static void Main(string[] args) {
        // Prompt user for their height in centimeters
        Console.Write("Enter your height in centimeters: ");
        double heightCm = Convert.ToDouble(Console.ReadLine());

        // Conversion factors
        double cmPerInch = 2.54;
        int inchesPerFoot = 12;

        // Convert height to inches
        double totalInches = heightCm / cmPerInch;

        // Convert inches to feet and remaining inches
        int feet = (int)(totalInches / inchesPerFoot);
        double inches = totalInches % inchesPerFoot;

        // Output the results
        Console.WriteLine($"Your height in cm is {heightCm} while in feet is {feet} and inches is {inches}.");
    }
}
