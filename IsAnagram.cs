using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter String 1 : ");
        string input1 = Console.ReadLine();
        input1 = input1.Replace(" ", "").ToLower();

        Console.WriteLine("Enter String 2 : ");
        string input2 = Console.ReadLine();
        input2 = input2.Replace(" ", "").ToLower();

        if (IsAnagram(input1, input2))
        {
            Console.WriteLine("Strings are Anagram");
        }
        else
        {
            Console.WriteLine("Strings are not Anagram");
        }
    }

    static bool IsAnagram(string input1, string input2)
    {
        if (input1.Length != input2.Length)
        {
            return false;
        }

        int[] charCount = new int[256];

        for (int i = 0; i < input1.Length; i++)
        {
            charCount[input1[i]]++;
        }

        for (int i = 0; i < input2.Length; i++)
        {
            charCount[input2[i]]--;
        }

        for (int i = 0; i < 256; i++)
        {
            if (charCount[i] != 0)
            {
                return false;
            }
        }

        return true;
    }
}
