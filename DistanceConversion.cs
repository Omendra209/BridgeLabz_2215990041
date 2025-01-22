// Creating a class named DistanceConversion to convert distance from kilometers to miles. Hint: 1km = 1.6 miles
using System;
class DistanceConversion {
    public static void Main(string[] args) {
     
        // Create variable for distance to convert
        double distanceToConvert = 10.8;
     
        // Create variable for storing converted distance
        double convertedDistance = distanceToConvert*1.6;
        
        // Display distance
        Console.WriteLine("The distance "+distanceToConvert+"km in miles is "+convertedDistance);
    }
}