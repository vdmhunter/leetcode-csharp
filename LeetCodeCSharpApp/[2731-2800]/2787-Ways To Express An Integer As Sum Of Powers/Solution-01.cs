namespace LeetCodeCSharpApp.WaysToExpressAnIntegerAsSumOfPowers01;

public class Solution
{
    private const int Mod = 1_000_000_007;

    public int NumberOfWays(int n, int x)
    {
        var max = 1;

        while (Math.Pow(max + 1, x) <= n)
            max++;

        var dp = new int[max + 1][];

        for (var i = 0; i <= max; i++)
        {
            dp[i] = new int[n + 1];
            dp[i][0] = 1;
        }

        for (var i = 1; i <= max; i++)
        {
            for (var j = 1; j <= n; j++)
                if (Math.Pow(i, x) > j)
                    dp[i][j] = dp[i - 1][j];
                else
                    dp[i][j] = (dp[i - 1][j] + dp[i - 1][j - (int)Math.Pow(i, x)]) % Mod;
        }

        return dp[max][n];
    }
}
