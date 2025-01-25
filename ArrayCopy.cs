using System;

public class ArrayCopy {
    public static void Main(string[] args) {
        // Prompt user for the number of rows and columns
        Console.Write("Enter number of rows: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Enter number of columns: ");
        int columns = int.Parse(Console.ReadLine());

        // Create the 2D array (matrix) with the given dimensions
        int[,] matrix = new int[rows, columns];

        // Take user input for the elements of the 2D array
        Console.WriteLine("Enter elements of the matrix:");

        // Fill the 2D array with user input using nested loops
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < columns; j++) {
                Console.Write("Element at (" + i + ", " + j + "): ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Create a 1D array to hold all elements of the 2D array
        int[] oneDArray = new int[rows * columns];

        // Copy elements from the 2D array into the 1D array
        int index = 0;
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < columns; j++) {
                oneDArray[index] = matrix[i, j];
                index++; // Increment index after copying each element
            }
        }

        // Output the 1D array
        Console.WriteLine("\nElements of the 1D array:");
        for (int i = 0; i < oneDArray.Length; i++) {
            Console.Write(oneDArray[i] + " ");
        }
    }
}
