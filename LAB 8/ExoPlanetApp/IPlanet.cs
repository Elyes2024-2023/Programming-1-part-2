using System.Collections.Generic;

public interface IPlanet
{
    List<int> GenerateMeasurements();
    int CountLandPoints(List<int> measurements);
    int FindDeepestPointIndex(List<int> measurements);
    int FindHighestPointIndex(List<int> measurements);
    int CalculateBelowSeaLevelLength(List<int> measurements);
    int CalculateAboveSeaLevelLength(List<int> measurements);
}
