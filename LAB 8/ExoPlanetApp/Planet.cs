using System;
using System.Collections.Generic;

public class Planet : IPlanet
{
    public List<int> GenerateMeasurements()
    {
        Random random = new Random();
        List<int> measurements = new List<int>();

        int previousValue = random.Next(-100, 101); // Initial random value
        measurements.Add(previousValue);

        int numMeasurements = random.Next(50, 101); // Number of measurements

        for (int i = 1; i < numMeasurements; i++)
        {
            int nextValue = random.Next(-100, 101);

            // Ensure continuity between positive and negative values
            while ((nextValue > 0 && previousValue <= 0) || (nextValue <= 0 && previousValue > 0))
            {
                nextValue = random.Next(-100, 101);
            }

            measurements.Add(nextValue);
            previousValue = nextValue;
        }

        return measurements;
    }

    public int CountLandPoints(List<int> measurements)
    {
        int landPointsCount = 0;

        foreach (int measurement in measurements)
        {
            if (measurement > 0)
            {
                landPointsCount++;
            }
        }

        return landPointsCount;
    }

    public int FindDeepestPointIndex(List<int> measurements)
    {
        int deepestPointIndex = 0;
        int deepestPoint = int.MaxValue;

        for (int i = 0; i < measurements.Count; i++)
        {
            if (measurements[i] < deepestPoint)
            {
                deepestPoint = measurements[i];
                deepestPointIndex = i;
            }
        }

        return deepestPointIndex;
    }

    public int FindHighestPointIndex(List<int> measurements)
    {
        int highestPointIndex = 0;
        int highestPoint = int.MinValue;

        for (int i = 0; i < measurements.Count; i++)
        {
            if (measurements[i] > highestPoint)
            {
                highestPoint = measurements[i];
                highestPointIndex = i;
            }
        }

        return highestPointIndex;
    }

    public int CalculateBelowSeaLevelLength(List<int> measurements)
    {
        int belowSeaLevelLength = 0;

        foreach (int measurement in measurements)
        {
            if (measurement < 0)
            {
                belowSeaLevelLength++;
            }
            else
            {
                break;
            }
        }

        return belowSeaLevelLength;
    }

    public int CalculateAboveSeaLevelLength(List<int> measurements)
    {
        int aboveSeaLevelLength = 0;

        foreach (int measurement in measurements)
        {
            if (measurement >= 0)
            {
                aboveSeaLevelLength++;
            }
            else
            {
                break;
            }
        }

        return aboveSeaLevelLength;
    }
}
