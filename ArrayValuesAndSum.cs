using System;

class ArrayValuesAndSum
{
    static void Main(string[] args)
    {
        // Define an array to store up to 10 elements
        double[] numbers = new double[10];

        // Define a variable to store the total and initialize to 0.0
        double total = 0.0;

        // Initialize the index to 0 for the array
        int index = 0;

        Console.WriteLine("Enter up to 10 numbers (enter 0 or a negative number to stop):");

        // Infinite loop to take user inputs
        while (true)
        {
            Console.Write("Enter a number: ");
            double input = double.Parse(Console.ReadLine());

            // Break the loop if the user enters 0 or a negative number
            if (input <= 0)
            {
                break;
            }

            // Break the loop if the array size limit is reached
            if (index == 10)
            {
                Console.WriteLine("Maximum of 10 numbers reached.");
                break;
            }

            // Assign the number to the array and increment the index
            numbers[index] = input;
            index++;
        }

        // Display all numbers and calculate the total
        Console.WriteLine("\nNumbers entered:");
        for (int i = 0; i < index; i++)
        {
            Console.WriteLine(numbers[i]);
            total += numbers[i];
        }

        // Display the total sum of the numbers
        Console.WriteLine("\nTotal of all numbers: " + total);
    }
}
