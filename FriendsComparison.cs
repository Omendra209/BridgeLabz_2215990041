using System;

class FriendsComparison
{
    static void Main(string[] args)
    {
        // Prompt the user to input the age and height of Amar
        Console.WriteLine("Enter the age of Amar:");
        int ageAmar = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the height of Amar (in cm):");
        int heightAmar = int.Parse(Console.ReadLine());

        // Prompt the user to input the age and height of Akbar
        Console.WriteLine("Enter the age of Akbar:");
        int ageAkbar = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the height of Akbar (in cm):");
        int heightAkbar = int.Parse(Console.ReadLine());

        // Prompt the user to input the age and height of Anthony
        Console.WriteLine("Enter the age of Anthony:");
        int ageAnthony = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the height of Anthony (in cm):");
        int heightAnthony = int.Parse(Console.ReadLine());

        // Determine the youngest friend based on age
        int youngestAge = Math.Min(ageAmar, Math.Min(ageAkbar, ageAnthony));
        string youngestFriend;
        if (youngestAge == ageAmar)
        {
            youngestFriend = "Amar";
        }
        else if (youngestAge == ageAkbar)
        {
            youngestFriend = "Akbar";
        }
        else
        {
            youngestFriend = "Anthony";
        }

        // Determine the tallest friend based on height
        int tallestHeight = Math.Max(heightAmar, Math.Max(heightAkbar, heightAnthony));
        string tallestFriend;
        if (tallestHeight == heightAmar)
        {
            tallestFriend = "Amar";
        }
        else if (tallestHeight == heightAkbar)
        {
            tallestFriend = "Akbar";
        }
        else
        {
            tallestFriend = "Anthony";
        }

        // Display the results
        Console.WriteLine(youngestFriend + " is the youngest friend with an age of " + youngestAge + " years.");
        Console.WriteLine(tallestFriend + " is the tallest friend with a height of " + tallestHeight + " cm.");
    }
}