namespace LeetCodeCSharpApp.New21Game01;

public class Solution
{
    public double New21Game(int n, int k, int maxPts)
    {
        if (k == 0)
            return 1.0D;

        if (n >= k - 1 + maxPts)
            return 1.0D;

        var dp = new double[n + 1];
        Array.Fill(dp, 0.0D);

        var probability = 0.0D;
        var windowSum = 1.0D;
        dp[0] = 1.0D;

        for (var i = 1; i <= n; i++)
        {
            dp[i] = windowSum / maxPts;

            if (i < k)
                windowSum += dp[i];
            else
                probability += dp[i];

            if (i >= maxPts)
                windowSum -= dp[i - maxPts];
        }

        return probability;
    }
}
