using System;

class Program
{
    static void Main()
    {
        // Take input for two strings
        Console.Write("Enter first string: ");
        string str1 = Console.ReadLine();
        
        Console.Write("Enter second string: ");
        string str2 = Console.ReadLine();

        // Compare strings lexicographically
        int result = CompareStrings(str1, str2);

        // Display result based on comparison
        if (result < 0)
        {
            Console.WriteLine(str1 + " comes before " + str2 + " in lexicographical order.");
        }
        else if (result > 0)
        {
            Console.WriteLine(str1 + " comes after " + str2 + " in lexicographical order.");
        }
        else
        {
            Console.WriteLine("Both strings are equal.");
        }
    }

    // Custom method to compare two strings lexicographically
    static int CompareStrings(string s1, string s2)
    {
        int minLength = Math.Min(s1.Length, s2.Length);

        for (int i = 0; i < minLength; i++)
        {
            if (s1[i] < s2[i])
                return -1;  // s1 comes before s2
            else if (s1[i] > s2[i])
                return 1;   // s1 comes after s2
        }

        // If all compared characters are same, shorter string comes first
        if (s1.Length < s2.Length)
            return -1;
        else if (s1.Length > s2.Length)
            return 1;

        return 0; // Both strings are equal
    }
}
