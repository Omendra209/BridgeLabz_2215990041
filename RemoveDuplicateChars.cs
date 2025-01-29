using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the String: ");
        string input = Console.ReadLine();
        string result = RemoveDuplicateChars(input);
        Console.WriteLine("String after removing Duplicate Characters: " + result);
    }
    static string RemoveDuplicateChars(string input)
    {
        string result = "\0";
        byte flag = 1;
        foreach (char item in input)
        {
            foreach (char c in result)
            {
                if (item==c)
                {
                    flag = 0;
                    break;
                }
                flag = 1;
            }
            if (flag==1)
            {
                result += item;
            }
        }
        return result;
    }
}
