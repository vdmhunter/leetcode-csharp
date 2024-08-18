namespace LeetCodeCSharpApp.MinimumCostToConvertStringI01;

public class Solution
{
    public long MinimumCost(string source, string target, char[] original, char[] changed, int[] cost)
    {
        var adjacencyList = new List<int[]>[26];

        for (var i = 0; i < 26; i++)
            adjacencyList[i] = [];

        int conversionCount = original.Length;

        for (var i = 0; i < conversionCount; i++)
            adjacencyList[original[i] - 'a'].Add([changed[i] - 'a', cost[i]]);

        var minConversionCosts = new long[26][];

        for (var i = 0; i < 26; i++)
            minConversionCosts[i] = Dijkstra(i, adjacencyList);

        var totalCost = 0L;
        int stringLength = source.Length;

        for (var i = 0; i < stringLength; i++)
        {
            if (source[i] == target[i])
                continue;

            long charConversionCost = minConversionCosts[source[i] - 'a'][target[i] - 'a'];

            if (charConversionCost == -1)
                return -1;

            totalCost += charConversionCost;
        }

        return totalCost;
    }

    private static long[] Dijkstra(int startChar, List<int[]>[] adjacencyList)
    {
        var priorityQueue = new PriorityQueue<(long, int), long>();
        priorityQueue.Enqueue((0L, startChar), 0L);

        var minCosts = new long[26];
        Array.Fill(minCosts, -1L);

        while (priorityQueue.Count > 0)
        {
            (long currentCost, int currentChar) = priorityQueue.Dequeue();

            if (minCosts[currentChar] != -1L && minCosts[currentChar] < currentCost)
                continue;

            foreach (int[] conversion in adjacencyList[currentChar])
            {
                int targetChar = conversion[0];
                long conversionCost = conversion[1];
                long newTotalCost = currentCost + conversionCost;

                if (minCosts[targetChar] != -1L && newTotalCost >= minCosts[targetChar])
                    continue;

                minCosts[targetChar] = newTotalCost;
                priorityQueue.Enqueue((newTotalCost, targetChar), newTotalCost);
            }
        }

        return minCosts;
    }
}
