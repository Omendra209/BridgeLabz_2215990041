using System;

class Program
{
    static void Main()
    {
        // Prompt user to enter a string
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();
        
        // Call method to toggle case of each character
        string result = ToggleCase(input);
        
        // Display the modified string
        Console.WriteLine("Toggled case string: " + result);
    }

    static string ToggleCase(string str)
    {
        // Initialize a character array to store modified characters
        char[] charArray = str.ToCharArray();
        
        // Iterate through each character in the array
        for (int i = 0; i < charArray.Length; i++)
        {
            // Check if character is uppercase, convert to lowercase
            if (char.IsUpper(charArray[i]))
            {
                charArray[i] = char.ToLower(charArray[i]);
            }
            // Check if character is lowercase, convert to uppercase
            else if (char.IsLower(charArray[i]))
            {
                charArray[i] = char.ToUpper(charArray[i]);
            }
        }
        
        // Convert character array back to string and return
        return new string(charArray);
    }
}
