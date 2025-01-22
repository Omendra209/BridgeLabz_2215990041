// Program to divide chocolates among children
using System;

class ChocolateDivision {
    public static void Main(string[] args) {
        // Prompt user for the number of chocolates
        Console.Write("Enter the total number of chocolates: ");
        int numberOfChocolates = Convert.ToInt32(Console.ReadLine());

        // Prompt user for the number of children
        Console.Write("Enter the number of children: ");
        int numberOfChildren = Convert.ToInt32(Console.ReadLine());

        // Calculate the number of chocolates each child gets and the remainder
        int chocolatesPerChild = numberOfChocolates / numberOfChildren;
        int remainingChocolates = numberOfChocolates % numberOfChildren;

        // Output the results
        Console.WriteLine("The number of chocolates each child gets is " + chocolatesPerChild + " and the number of remaining chocolates is " + remainingChocolates + ".");
    }
}
