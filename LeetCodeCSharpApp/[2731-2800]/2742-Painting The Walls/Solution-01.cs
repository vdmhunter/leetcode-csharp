namespace LeetCodeCSharpApp.PaintingTheWalls01;

public class Solution
{
    public int PaintWalls(int[] cost, int[] time)
    {
        var n = cost.Length;
        var dp = new int[n + 1];

        for (var i = 0; i < dp.Length; i++)
            dp[i] = (int)1e9;

        dp[0] = 0;

        for (var i = 0; i < n; i++)
            for (var j = n; j > 0; j--)
                dp[j] = Math.Min(dp[j], dp[Math.Max(j - time[i] - 1, 0)] + cost[i]);

        return dp[n];
    }
}
