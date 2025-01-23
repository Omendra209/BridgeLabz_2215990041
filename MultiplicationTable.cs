using System;

class MultiplicationTable {
    public static void Main(string[] args) {
        // Prompt user to enter a number
        Console.Write("Enter a number to find its multiplication table from 6 to 9: ");
        int number = int.Parse(Console.ReadLine());

        // Loop to print the multiplication table from 6 to 9
        for (int i = 6; i <= 9; i++) {
            // Print the multiplication result for each value of i
            Console.WriteLine(number + " * " + i + " = " + (number * i));
        }
    }
}
