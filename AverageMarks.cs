// Creating a class with the name AverageMarks to find the average percent mark in PCM.
using System;
class AverageMarks {
    public static void Main(string[] args) {
     
        // Create a string variable 'name' and assign value "Harry"
        string name = "Sam";
     
        // Create three int variables for marks in maths, physics, and chemistry and assign values 94,95,96
        int maths = 94;
        int physics = 95;
        int chemistry = 96;
     
        // Create an int variable 'numberOfSubject' and assign value 3
        int numberOfSubject = 3;
     
        // Create variable 'average' and assign average mark
        double average = (maths+physics+chemistry)/3;
        
        // Display average mark
        Console.WriteLine(""+name+"'s average mark in PCM is "+average);
    }
}

