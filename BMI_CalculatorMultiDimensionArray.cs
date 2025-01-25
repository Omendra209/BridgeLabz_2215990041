using System;

public class BMI_CalculatorMultiDimensionArray {
    public static void Main(string[] args) {
        // Take input for the number of persons
        Console.Write("Enter the number of persons: ");
        int numPersons = int.Parse(Console.ReadLine());

        // Create a 2D array to store weight, height, and BMI for all persons
        double[,] personData = new double[numPersons, 3]; // Columns: 0 - Weight, 1 - Height, 2 - BMI
        string[] weightStatus = new string[numPersons]; // Array to store weight status

        // Take input for weight and height for each person
        for (int i = 0; i < numPersons; i++) {
            Console.WriteLine("Enter details for person " + (i + 1) + ":");
            
            // Get valid weight input
            double weight = -1;
            while (weight <= 0) {
                Console.Write("Weight (kg): ");
                weight = double.Parse(Console.ReadLine());
                if (weight <= 0) {
                    Console.WriteLine("Please enter a valid positive weight.");
                }
            }
            personData[i, 0] = weight; // Store weight

            // Get valid height input
            double height = -1;
            while (height <= 0) {
                Console.Write("Height (m): ");
                height = double.Parse(Console.ReadLine());
                if (height <= 0) {
                    Console.WriteLine("Please enter a valid positive height.");
                }
            }
            personData[i, 1] = height; // Store height

            // Calculate BMI
            personData[i, 2] = personData[i, 0] / (personData[i, 1] * personData[i, 1]);

            // Determine weight status based on BMI
            if (personData[i, 2] < 18.5) {
                weightStatus[i] = "Underweight";
            } else if (personData[i, 2] >= 18.5 && personData[i, 2] <= 24.9) {
                weightStatus[i] = "Normal";
            } else if (personData[i, 2] >= 25.0 && personData[i, 2] <= 39.9) {
                weightStatus[i] = "Overweight";
            } else {
                weightStatus[i] = "Obese";
            }
        }

        // Display the results
        Console.WriteLine("\nBMI Report:");
        Console.WriteLine("Person No | Weight (kg) | Height (m) | BMI     | Status");

        for (int i = 0; i < numPersons; i++) {
            Console.WriteLine((i + 1) + "         | " + personData[i, 0] + "          | " + personData[i, 1] + "       | " + String.Format("{0:0.00}", personData[i, 2]) + " | " + weightStatus[i]);
        }
    }
}
