using System;

public class BMI_Calculator {
    public static void Main(string[] args) {
        // Take input for the number of persons
        Console.Write("Enter the number of persons: ");
        int numPersons = int.Parse(Console.ReadLine());

        // Arrays to store weight, height, BMI, and weight status
        double[] weight = new double[numPersons];
        double[] height = new double[numPersons];
        double[] bmi = new double[numPersons];
        string[] status = new string[numPersons];

        // Take input for weight and height for each person
        for (int i = 0; i < numPersons; i++) {
            Console.WriteLine("Enter details for person " + (i + 1) + ":");
            Console.Write("Weight (kg): ");
            weight[i] = double.Parse(Console.ReadLine());

            Console.Write("Height (m): ");
            height[i] = double.Parse(Console.ReadLine());

            // Calculate BMI
            bmi[i] = weight[i] / (height[i] * height[i]);

            // Determine weight status based on BMI value
            if (bmi[i] < 18.5) {
                status[i] = "Underweight";
            } else if (bmi[i] >= 18.5 && bmi[i] <= 24.9) {
                status[i] = "Normal";
            } else if (bmi[i] >= 25.0 && bmi[i] <= 39.9) {
                status[i] = "Overweight";
            } else {
                status[i] = "Obese";
            }
        }

        // Display the results
        Console.WriteLine("\nBMI Report:");
        Console.WriteLine("Person No | Weight (kg) | Height (m) | BMI     | Status");

        for (int i = 0; i < numPersons; i++) {
            Console.WriteLine((i + 1) + "         | " + weight[i] + "          | " + height[i] + "       | " + String.Format("{0:0.00}", bmi[i]) + " | " + status[i]);
        }
    }
}
