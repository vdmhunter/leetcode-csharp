namespace LeetCodeCSharpApp.PerfectSquares01;

public class Solution
{
    public int NumSquares(int n)
    {
        var dp = new int[n + 1];

        for (var i = 1; i <= n; i++)
        {
            dp[i] = i;

            for (var j = 1; j * j <= i; j++)
                dp[i] = Math.Min(dp[i], dp[i - j * j] + 1);
        }

        return dp[n];
    }
}
