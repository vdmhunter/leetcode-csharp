namespace LeetCodeCSharpApp.KInversePairsArray02;

/// <summary>
/// Dynamic Programming
/// </summary>
public class Solution
{
    public int KInversePairs(int n, int k)
    {
        var dp = new int[n + 1, k + 1];

        for (var i = 1; i <= n; i++)
            for (var j = 0; j <= k; j++)
                if (j == 0)
                    dp[i, j] = 1;
                else
                    for (var p = 0; p <= Math.Min(j, i - 1); p++)
                        dp[i, j] = (dp[i, j] + dp[i - 1, j - p]) % 1000000007;

        return dp[n, k];
    }
}
