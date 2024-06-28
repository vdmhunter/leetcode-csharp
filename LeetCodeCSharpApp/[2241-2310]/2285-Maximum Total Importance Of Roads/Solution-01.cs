namespace LeetCodeCSharpApp.MaximumTotalImportanceOfRoads01;

public class Solution
{
    public long MaximumImportance(int n, int[][] roads)
    {
        var degree = new int[n];

        foreach (int[] road in roads)
        {
            degree[road[0]]++;
            degree[road[1]]++;
        }

        var cities = new List<int>();

        for (var i = 0; i < n; i++)
            cities.Add(i);

        cities.Sort((a, b) => degree[b].CompareTo(degree[a]));
        var totalImportance = 0L;

        for (var i = 0; i < n; i++)
            totalImportance += (long)(n - i) * degree[cities[i]];

        return totalImportance;
    }
}
