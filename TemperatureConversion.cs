// Program to convert temperature from Celsius to Fahrenheit
using System;

class TemperatureConversion {
    public static void Main(string[] args) {
        // Prompt user for the temperature in Celsius
        Console.Write("Enter the temperature in Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        // Convert Celsius to Fahrenheit using the formula
        double fahrenheitResult = (celsius * 9 / 5) + 32;

        // Output the result
        Console.WriteLine("The " + celsius + " Celsius is " + fahrenheitResult + " Fahrenheit");
    }
}
