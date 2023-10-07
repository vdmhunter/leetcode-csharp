namespace LeetCodeCSharpApp.BuildArrayWhereYouCanFindTheMaximumExactlyKComparisons01;

public class Solution
{
    private const int Mod = 1_000_000_007;

    public int NumOfArrays(int n, int m, int k)
    {
        var dp = InitializeArray(m, k);
        var prefix = InitializeArray(m, k);
        var prevDp = InitializeArray(m, k);
        var prevPrefix = InitializeArray(m, k);

        InitializePrevDpAndPrefix(m, prevDp, prevPrefix);

        for (var i = 2; i <= n; i++)
        {
            CalculateDpAndPrefix(m, k, dp, prefix, prevDp, prevPrefix);
            CopyArrays(m, k, dp, prefix, prevDp, prevPrefix);
        }

        return prefix[m][k];
    }

    private static int[][] InitializeArray(int m, int k)
    {
        return Enumerable.Range(0, m + 1)
            .Select(_ => new int[k + 1])
            .ToArray();
    }

    private static void InitializePrevDpAndPrefix(int m, int[][] prevDp, int[][] prevPrefix)
    {
        for (var j = 1; j <= m; j++)
        {
            prevDp[j][1] = 1;
            prevPrefix[j][1] = j;
        }
    }

    private static void CalculateDpAndPrefix(int m, int k, int[][] dp, int[][] prefix, int[][] prevDp,
        int[][] prevPrefix)
    {
        for (var maxNum = 1; maxNum <= m; maxNum++)
            for (var cost = 1; cost <= k; cost++)
                CalculateValuesForCurrentCell(maxNum, cost, dp, prefix, prevDp, prevPrefix);
    }

    private static void CalculateValuesForCurrentCell(int maxNum, int cost, int[][] dp, int[][] prefix, int[][] prevDp,
        int[][] prevPrefix)
    {
        dp[maxNum][cost] = (int)((long)maxNum * prevDp[maxNum][cost] % Mod);

        if (maxNum > 1 && cost > 1)
            dp[maxNum][cost] = (dp[maxNum][cost] + prevPrefix[maxNum - 1][cost - 1]) % Mod;

        prefix[maxNum][cost] = (prefix[maxNum - 1][cost] + dp[maxNum][cost]) % Mod;
    }

    private static void CopyArrays(int m, int k, int[][] dp, int[][] prefix, int[][] prevDp, int[][] prevPrefix)
    {
        for (var j = 1; j <= m; j++)
        {
            Array.Copy(dp[j], prevDp[j], k + 1);
            Array.Copy(prefix[j], prevPrefix[j], k + 1);
        }
    }
}
