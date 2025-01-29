using System;

class Program
{
    static void Main()
    {
        // Sample input string
        string input = "Hello World";
        
        // Call the function to reverse the string
        string reversedString = ReverseString(input);
        
        // Output the reversed string
        Console.WriteLine("Reversed string: " + reversedString);
    }

    static string ReverseString(string input)
    {
        // Convert the input string to a character array
        char[] charArray = input.ToCharArray();
        
        // Initialize pointers for the start and end of the array
        int start = 0;
        int end = charArray.Length - 1;
        
        // Swap characters from the start and end until the middle is reached
        while (start < end)
        {
            // Swap the characters at the start and end positions
            char temp = charArray[start];
            charArray[start] = charArray[end];
            charArray[end] = temp;
            
            // Move the start pointer forward and the end pointer backward
            start++;
            end--;
        }
        
        // Convert the character array back to a string
        return new string(charArray);
    }
}