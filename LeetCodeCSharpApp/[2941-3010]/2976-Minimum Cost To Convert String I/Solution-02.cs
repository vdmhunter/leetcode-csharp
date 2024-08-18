namespace LeetCodeCSharpApp.MinimumCostToConvertStringI02;

public class Solution
{
    public long MinimumCost(string source, string target, char[] original, char[] changed, int[] cost)
    {
        long[][] minCost = InitializeMinCostMatrix(original, changed, cost);
        ApplyFloydWarshall(minCost);

        return CalculateTotalCost(source, target, minCost);
    }

    private static long[][] InitializeMinCostMatrix(char[] original, char[] changed, int[] cost)
    {
        var minCost = new long[26][];

        for (var i = 0; i < 26; i++)
        {
            minCost[i] = new long[26];
            Array.Fill(minCost[i], int.MaxValue);
        }

        for (var i = 0; i < original.Length; i++)
        {
            int startChar = original[i] - 'a';
            int endChar = changed[i] - 'a';
            minCost[startChar][endChar] = Math.Min(minCost[startChar][endChar], cost[i]);
        }

        return minCost;
    }

    private static void ApplyFloydWarshall(long[][] minCost)
    {
        for (var k = 0; k < 26; k++)
            for (var i = 0; i < 26; i++)
                for (var j = 0; j < 26; j++)
                    minCost[i][j] = Math.Min(minCost[i][j], minCost[i][k] + minCost[k][j]);
    }

    private static long CalculateTotalCost(string source, string target, long[][] minCost)
    {
        var totalCost = 0L;

        for (var i = 0; i < source.Length; i++)
        {
            if (source[i] == target[i])
                continue;

            int sourceChar = source[i] - 'a';
            int targetChar = target[i] - 'a';

            if (minCost[sourceChar][targetChar] >= int.MaxValue)
                return -1;

            totalCost += minCost[sourceChar][targetChar];
        }

        return totalCost;
    }
}
