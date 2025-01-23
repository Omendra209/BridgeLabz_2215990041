using System;

class BMI_Calculator
{
    static void Main(string[] args)
    {
        // Prompt the user for weight input in kg
        Console.WriteLine("Enter your weight in kilograms (kg):");
        double weight = double.Parse(Console.ReadLine());

        // Prompt the user for height input in cm
        Console.WriteLine("Enter your height in centimeters (cm):");
        double heightInCm = double.Parse(Console.ReadLine());

        // Convert height from cm to meters
        double heightInMeters = heightInCm / 100;

        // Calculate BMI using the formula: BMI = weight / (height * height)
        double bmi = weight / (heightInMeters * heightInMeters);

        // Display the BMI
        Console.WriteLine($"Your BMI is: {bmi:F2}");

        // Determine and display the weight status based on the BMI value
        if (bmi <= 18.4)
        {
            Console.WriteLine("Status: Underweight");
        }
        else if (bmi >= 18.5 && bmi <= 24.9)
        {
            Console.WriteLine("Status: Normal");
        }
        else if (bmi >= 25.0 && bmi <= 39.9)
        {
            Console.WriteLine("Status: Overweight");
        }
        else if (bmi >= 40.0)
        {
            Console.WriteLine("Status: Obese");
        }
    }
}