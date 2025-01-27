using System;

class WindChillCalculator
{
    // Method to calculate the wind chill temperature
    public double CalculateWindChill(double temperature, double windSpeed)
    {
        // Wind chill formula
        double windChill = 35.74 + (0.6215 * temperature) + ((0.4275 * temperature - 35.75) * Math.Pow(windSpeed, 0.16));
        return windChill;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Instantiate the WindChillCalculator class
        WindChillCalculator calculator = new WindChillCalculator();

        // Get user input for temperature and wind speed
        Console.Write("Enter the temperature (in Fahrenheit): ");
        double temperature = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the wind speed (in miles per hour): ");
        double windSpeed = Convert.ToDouble(Console.ReadLine());

        // Calculate the wind chill temperature
        double windChill = calculator.CalculateWindChill(temperature, windSpeed);

        // Display the result
        Console.WriteLine("The wind chill temperature is: " + windChill + " °F.");
    }
}