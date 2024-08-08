using System;
using System.Collections.Generic;

public class AthleticsApp
{
    private Dictionary<string, List<string>> competitors;
    private HashSet<string> sports;

    public AthleticsApp()
    {
        competitors = new Dictionary<string, List<string>>();
        sports = new HashSet<string>();
    }

    public void ProcessCompetitorData()
    {
        Console.WriteLine("Enter the number of competitors:");
        int numberOfCompetitors = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfCompetitors; i++)
        {
            Console.WriteLine("Enter the name of competitor {0}:", i + 1);
            string competitorName = Console.ReadLine();

            Console.WriteLine("Enter the sport type for competitor {0}:", i + 1);
            string sportType = Console.ReadLine();

            if (!competitors.ContainsKey(sportType))
            {
                competitors[sportType] = new List<string>();
                sports.Add(sportType);
            }

            competitors[sportType].Add(competitorName);
        }
    }

    public void DisplayResults()
    {
        Console.WriteLine("Number of sports: {0}", sports.Count);
        Console.WriteLine("Number of competitors selecting sports: {0}", competitors.Count);

        Console.WriteLine("Names of the competitors selecting sports:");
        foreach (var entry in competitors)
        {
            string sportType = entry.Key;
            List<string> competitorNames = entry.Value;

            Console.WriteLine("{0}: {1}", sportType, string.Join(", ", competitorNames));
        }
    }
}
