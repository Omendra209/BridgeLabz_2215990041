// Program to compute the volume of Earth in cubic kilometers and cubic miles
using System;

class VolumeOfEarth {
    public static void Main(string[] args) {
        // Radius of Earth in kilometers
        double radiusEarth = 6378;

        // Conversion factor from cubic kilometers to cubic miles (1 km^3 = 0.239913 mi^3)
        double conversionFactor = 0.239913;

        // Formula to calculate the volume of a sphere: (4/3) * pi * r^3
        double volumeEarthKm = (4.0 / 3) * Math.PI * Math.Pow(radiusEarth, 3);

        // Convert the volume to cubic miles
        double volumeEarthMi = volumeEarthKm * conversionFactor;

        // Output the results
        Console.WriteLine($"The volume of Earth in cubic kilometers is {volumeEarthKm} and cubic miles is {volumeEarthMi}.");
    }
}
