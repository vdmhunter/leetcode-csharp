// ReSharper disable InconsistentNaming

namespace LeetCodeCSharpApp.StoneGameIII01;

public class Solution
{
    public string StoneGameIII(int[] stoneValue)
    {
        var n = stoneValue.Length;
        var dp = new int[n + 1];

        for (var i = n - 1; i >= 0; i--)
        {
            dp[i] = -1 * (int)Math.Pow(2, 32);

            for (int k = 0, take = 0; k < 3 && i + k < n; k++)
            {
                take += stoneValue[i + k];
                dp[i] = Math.Max(dp[i], take - dp[i + k + 1]);
            }
        }

        return dp[0] switch
        {
            > 0 => "Alice",
            < 0 => "Bob",
            _ => "Tie"
        };
    }
}

