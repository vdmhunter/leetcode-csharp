namespace LeetCodeCSharpApp.WaysToExpressAnIntegerAsSumOfPowers02;

public class Solution
{
    private const int Mod = 1_000_000_007;

    public int NumberOfWays(int n, int x)
    {
        var dp = new int[301];
        dp[0] = 1;

        int v;

        for (var a = 1; (v = (int)Math.Pow(a, x)) <= n; a++)
            for (var i = n; i >= v; i--)
                dp[i] = (dp[i] + dp[i - v]) % Mod;

        return dp[n];
    }
}
