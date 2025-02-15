using System;
using System.Text;

class ReverseString
{
    // Method to reverse a string using StringBuilder
    public static string Reverse(string input)
    {
        StringBuilder sb = new StringBuilder();

        // Iterate from the end to the beginning and append characters
        for (int i = input.Length - 1; i >= 0; i--)
        {
            sb.Append(input[i]);
        }

        return sb.ToString(); // Convert StringBuilder to string and return
    }

    public static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine(); // Read user input

        string reversedString = Reverse(input); // Reverse the string

        Console.WriteLine("Reversed String: " + reversedString); // Display the result
    }
}
