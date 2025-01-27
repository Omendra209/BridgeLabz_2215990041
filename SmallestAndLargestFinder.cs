using System;

class SmallestAndLargestFinder
{
    // Method to find the smallest and largest of three numbers
    public static int[] FindSmallestAndLargest(int number1, int number2, int number3)
    {
        int smallest = number1;
        int largest = number1;

        // Compare with the second number
        if (number2 < smallest)
        {
            smallest = number2;
        }
        if (number2 > largest)
        {
            largest = number2;
        }

        // Compare with the third number
        if (number3 < smallest)
        {
            smallest = number3;
        }
        if (number3 > largest)
        {
            largest = number3;
        }

        return new int[] { smallest, largest }; // Return an array with smallest and largest
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Get user input for three numbers
        Console.Write("Enter the first number: ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the third number: ");
        int number3 = Convert.ToInt32(Console.ReadLine());

        // Find the smallest and largest numbers
        int[] result = SmallestAndLargestFinder.FindSmallestAndLargest(number1, number2, number3);

        // Display the results
        Console.WriteLine("The smallest number is: " + result[0]);
        Console.WriteLine("The largest number is: " + result[1]);
    }
}