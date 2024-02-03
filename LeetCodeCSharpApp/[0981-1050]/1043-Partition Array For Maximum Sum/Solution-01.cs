namespace LeetCodeCSharpApp.PartitionArrayForMaximumSum01;

public class Solution
{
    public int MaxSumAfterPartitioning(int[] arr, int k)
    {
        var n = arr.Length;
        var dp = new int[n + 1];

        for (var i = 1; i <= n; i++)
        {
            int max = 0, best = 0;

            for (var j = 1; j <= k && i - j >= 0; j++)
            {
                max = Math.Max(max, arr[i - j]);
                best = Math.Max(best, dp[i - j] + max * j);
            }

            dp[i] = best;
        }

        return dp[n];
    }
}
