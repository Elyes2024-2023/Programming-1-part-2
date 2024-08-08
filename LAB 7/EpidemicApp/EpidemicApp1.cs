using System;
using System.Collections.Generic;
using System.Linq;

public class EpidemicApp1
{
    public static void Main(string[] args)
    {
        List<Laboratory> laboratories = new List<Laboratory>();

        // Read the number of laboratories (N) and number of roads (M)
        int N = ReadNumberOfLaboratories();
        int M = ReadNumberOfRoads();

        // Use a loop to read the information for each laboratory
        for (int i = 0; i < N; i++)
        {
            Laboratory laboratory = new Laboratory();

            // Set the laboratory's ID
            laboratory.Id = i + 1;

            // Create a list to store the neighbors
            List<int> neighbors = new List<int>();

            // Use a loop to read the neighbors' information
            for (int j = 0; j < M; j++)
            {
                // Read the neighbor's ID and add it to the list
                int neighborId = ReadNeighborId();
                neighbors.Add(neighborId);
            }

            // Set the laboratory's neighbors
            laboratory.Neighbors = neighbors;

            // Add the laboratory to the list
            laboratories.Add(laboratory);
        }

        // Use another loop to calculate the farthest neighbor for each laboratory
        foreach (Laboratory laboratory in laboratories)
        {
            int farthestNeighbor = CalculateFarthestNeighbor(laboratory);
            laboratory.FarthestNeighbor = farthestNeighbor;
        }

        // Use LINQ to find the laboratories with the farthest neighbors
        int maxDistance = laboratories.Max(lab => lab.FarthestNeighbor);
        List<Laboratory> farthestLaboratories = laboratories.Where(lab => lab.FarthestNeighbor == maxDistance).ToList();

        // Display the results to the user
        foreach (Laboratory laboratory in farthestLaboratories)
        {
            Console.WriteLine($"Laboratory {laboratory.Id}: Farthest Neighbor Distance = {laboratory.FarthestNeighbor}");
        }
    }

    private static int ReadNumberOfLaboratories()
    {
        Console.WriteLine("Enter the number of laboratories:");
        string input = Console.ReadLine();
        int numberOfLaboratories = int.Parse(input);
        return numberOfLaboratories;
    }

    private static int ReadNumberOfRoads()
    {
        Console.WriteLine("Enter the number of roads:");
        string input = Console.ReadLine();
        int numberOfRoads = int.Parse(input);
        return numberOfRoads;
    }

    private static int ReadNeighborId()
    {
        Console.WriteLine("Enter the neighbor's ID:");
        string input = Console.ReadLine();
        int neighborId = int.Parse(input);
        return neighborId;
    }
    private static int CalculateFarthestNeighbor(Laboratory laboratory)
    {
        int farthestDistance = 0;

        foreach (int neighborId in laboratory.Neighbors)
        {
            // Calculate the distance between the laboratory and its neighbor
            int distance = CalculateDistance(laboratory.Id, neighborId);

            // Update the farthest distance if the calculated distance is greater
            if (distance > farthestDistance)
            {
                farthestDistance = distance;
            }
        }

        return farthestDistance;
    }

    private static int CalculateDistance(int laboratoryId, int neighborId)
    {
        // Your logic to calculate the distance between two laboratories
        // You can implement any suitable distance calculation algorithm here
        // and return the distance as an integer value.
        // For simplicity, you can assume a specific calculation or use a placeholder logic.
        return Math.Abs(laboratoryId - neighborId);
    }

}
