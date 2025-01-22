// Creating a class with the name PenDistribution to find how many pens each student will get if the pens must be divided equally.
using System;
class PenDistribution {
    public static void Main(string[] args) {
     
        // Create variables for total number of pen and student
        int totalPen = 14;
        int numberOfStudents = 3;
     
        // Create variable for storing pen per student
        int penPerStudent = totalPen/numberOfStudents;
        
        // Create variable for storing remaining pen
        int remainingPen = totalPen%numberOfStudents;
        
        // Display result
        Console.WriteLine("The Pen Per Student is "+penPerStudent+" and the remaining pen not distributed is "+remainingPen);
    }
}