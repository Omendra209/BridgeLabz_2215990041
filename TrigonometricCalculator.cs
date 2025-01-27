using System;

class TrigonometricCalculator
{
    // Method to calculate various trigonometric functions
    public double[] CalculateTrigonometricFunctions(double angle)
    {
        // Convert angle from degrees to radians
        double radians = angle * (Math.PI / 180);

        // Calculate sine, cosine, and tangent
        double sine = Math.Sin(radians);
        double cosine = Math.Cos(radians);
        double tangent = Math.Tan(radians);

        // Return the results in an array
        return new double[] { sine, cosine, tangent };
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Instantiate the TrigonometricCalculator class
        TrigonometricCalculator calculator = new TrigonometricCalculator();

        // Get user input for the angle in degrees
        Console.Write("Enter the angle in degrees: ");
        double angle = Convert.ToDouble(Console.ReadLine());

        // Calculate the trigonometric functions
        double[] results = calculator.CalculateTrigonometricFunctions(angle);

        // Display the results
        Console.WriteLine("Sine: " + results[0]);
        Console.WriteLine("Cosine: " + results[1]);
        Console.WriteLine("Tangent: " + results[2]);
    }
}