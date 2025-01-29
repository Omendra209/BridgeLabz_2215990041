using System;

class Program
{
    static void Main()
    {
        // Prompt the user to enter a string
        Console.Write("Enter a string to check if it is a palindrome: ");
        string input = Console.ReadLine();

        //Convert the String to lowercase for case-insensitive comparison
        input = input.ToLower();
        
        // Call the function to check if the string is a palindrome
        bool isPalindrome = CheckPalindrome(input);
        
        // Output the result
        if (isPalindrome)
            Console.WriteLine("The string is a palindrome.");
        else
            Console.WriteLine("The string is not a palindrome.");
    }

    static bool CheckPalindrome(string input)
    {
        // Initialize pointers for the start and end of the string
        int start = 0;
        int end = input.Length - 1;
        
        // Loop until the start pointer is less than the end pointer
        while (start < end)
        {
            // Compare characters at the start and end positions
            if (input[start] != input[end])
            {
                // If characters don't match, the string is not a palindrome
                return false;
            }
            
            // Move the start pointer forward and the end pointer backward
            start++;
            end--;
        }
        
        // If the loop completes, the string is a palindrome
        return true;
    }
}