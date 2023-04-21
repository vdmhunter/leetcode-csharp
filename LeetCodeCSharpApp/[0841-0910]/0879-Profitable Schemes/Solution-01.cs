namespace LeetCodeCSharpApp.ProfitableSchemes01;

public class Solution
{
    private const int Mod = 1_000_000_007;

    public int ProfitableSchemes(int n, int minProfit, int[] group, int[] profit)
    {
        var result = 0;

        var dp = new int[minProfit + 1, n + 1];
        dp[0, 0] = 1;

        for (var k = 0; k < group.Length; k++)
        {
            int g = group[k], p = profit[k];

            for (var i = minProfit; i >= 0; i--)
                for (var j = n - g; j >= 0; j--)
                    dp[Math.Min(i + p, minProfit), j + g] = (dp[Math.Min(i + p, minProfit), j + g] + dp[i, j]) % Mod;
        }

        for (var i = 0; i <= n; i++)
            result = (result + dp[minProfit, i]) % Mod;

        return result;
    }
}
