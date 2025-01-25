using System;

public class YoungestTallest {
    public static void Main(string[] args) {
        // Define arrays to store the ages and heights of the three friends
        int[] ages = new int[3];
        double[] heights = new double[3];

        // Names of the friends
        string[] names = { "Amar", "Akbar", "Anthony" };

        // Taking user input for ages and heights
        for (int i = 0; i < 3; i++) {
            Console.Write("Enter age for " + names[i] + ": ");
            ages[i] = int.Parse(Console.ReadLine());

            Console.Write("Enter height for " + names[i] + " (in meters): ");
            heights[i] = double.Parse(Console.ReadLine());
        }

        // Find the youngest friend
        int youngestIndex = 0;
        for (int i = 1; i < 3; i++) {
            if (ages[i] < ages[youngestIndex]) {
                youngestIndex = i;
            }
        }

        // Find the tallest friend
        int tallestIndex = 0;
        for (int i = 1; i < 3; i++) {
            if (heights[i] > heights[tallestIndex]) {
                tallestIndex = i;
            }
        }

        // Display the youngest and the tallest friend
        Console.WriteLine("\nThe youngest friend is: " + names[youngestIndex] + " with age " + ages[youngestIndex]);
        Console.WriteLine("The tallest friend is: " + names[tallestIndex] + " with height " + heights[tallestIndex] + " meters");
    }
}
