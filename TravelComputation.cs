// Program to compute the total distance and time for a trip based on user inputs
using System;

class TravelComputation {
    public static void Main(string[] args) {
        // Prompt user for the traveler's name
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        // Prompt user for the cities
        Console.Write("Enter the starting city: ");
        string fromCity = Console.ReadLine();

        Console.Write("Enter the city you are traveling via: ");
        string viaCity = Console.ReadLine();

        Console.Write("Enter the destination city: ");
        string toCity = Console.ReadLine();

        // Prompt user for distances
        Console.Write("Enter the distance from " + fromCity + " to " + viaCity + " (in km): ");
        double distanceFromToVia = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the distance from " + viaCity + " to " + toCity + " (in km): ");
        double distanceViaToFinalCity = Convert.ToDouble(Console.ReadLine());

        // Prompt user for time taken for each segment
        Console.Write("Enter the time taken from " + fromCity + " to " + viaCity + " (hours and minutes, separated by space): ");
        string[] timeFromToViaInput = Console.ReadLine().Split();
        int timeFromToVia = Convert.ToInt32(timeFromToViaInput[0]) * 60 + Convert.ToInt32(timeFromToViaInput[1]);

        Console.Write("Enter the time taken from " + viaCity + " to " + toCity + " (hours and minutes, separated by space): ");
        string[] timeViaToFinalCityInput = Console.ReadLine().Split();
        int timeViaToFinalCity = Convert.ToInt32(timeViaToFinalCityInput[0]) * 60 + Convert.ToInt32(timeViaToFinalCityInput[1]);

        // Compute the total distance and total time
        double totalDistance = distanceFromToVia + distanceViaToFinalCity;
        int totalTime = timeFromToVia + timeViaToFinalCity;

        // Output the travel details
        Console.WriteLine("The Total Distance travelled by "+name+" from "+fromCity+" to "+toCity+" via "+viaCity+" is "+totalDistance+" km and the Total Time taken is "+totalTime+" minutes");
    }
}
