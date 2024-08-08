using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        IPlanet planet = new Planet();

        // Generate random measurements representing relief conditions
        List<int> measurements = planet.GenerateMeasurements();

        // Number of land points along the equator
        int landPointsCount = planet.CountLandPoints(measurements);
        Console.WriteLine("Number of land points along the equator: " + landPointsCount);

        // Index of the deepest and highest points
        int deepestPointIndex = planet.FindDeepestPointIndex(measurements);
        int highestPointIndex = planet.FindHighestPointIndex(measurements);
        Console.WriteLine("Deepest point index: " + deepestPointIndex);
        Console.WriteLine("Highest point index: " + highestPointIndex);

        // Length of measurement below and above sea level
        int belowSeaLevelLength = planet.CalculateBelowSeaLevelLength(measurements);
        int aboveSeaLevelLength = planet.CalculateAboveSeaLevelLength(measurements);
        Console.WriteLine("Length of measurement below sea level: " + belowSeaLevelLength);
        Console.WriteLine("Length of measurement above sea level: " + aboveSeaLevelLength);

        Console.ReadLine();
    }
}
