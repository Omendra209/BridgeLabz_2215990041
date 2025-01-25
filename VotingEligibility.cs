using System;

class VotingEligibility
{
    static void Main(string[] args)
    {
        // Define an array to hold the ages of 10 students
        int[] ages = new int[10];

        // Take user input for the age of each student
        Console.WriteLine("Enter the ages of 10 students:");
        for (int i = 0; i < ages.Length; i++)
        {
            Console.Write("Student " + (i + 1) + " age: ");
            ages[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nVoting Eligibility Results:");
        
        // Loop through the array and check voting eligibility
        for (int i = 0; i < ages.Length; i++)
        {
            if (ages[i] < 0)
            {
                Console.WriteLine("Student " + (i + 1) + ": Invalid age entered (" + ages[i] + ").");
            }
            else if (ages[i] >= 18)
            {
                Console.WriteLine("Student " + (i + 1) + ": The student with the age " + ages[i] + " can vote.");
            }
            else
            {
                Console.WriteLine("Student " + (i + 1) + ": The student with the age " + ages[i] + " cannot vote.");
            }
        }
    }
}
