namespace LeetCodeCSharpApp.OutOfBoundaryPaths03;

/// <summary>
/// Dynamic Programming
/// </summary>
public class Solution
{
    private const int Mod = 1_000_000_007;

    public int FindPaths(int m, int n, int maxMove, int startRow, int startColumn)
    {
        var dp = new int[m, n];
        dp[startRow, startColumn] = 1;
        var count = 0;

        for (var moves = 1; moves <= maxMove; moves++)
        {
            var temp = new int[m, n];

            for (var i = 0; i < m; i++)
                for (var j = 0; j < n; j++)
                {
                    count = UpdateCount(count, dp, i, j, m, n);
                    temp[i, j] = UpdateTemp(dp, i, j, m, n);
                }

            dp = temp;
        }

        return count;
    }

    private static int UpdateCount(int count, int[,] dp, int i, int j, int m, int n)
    {
        if (i == m - 1)
            count = (count + dp[i, j]) % Mod;

        if (j == n - 1)
            count = (count + dp[i, j]) % Mod;

        if (i == 0)
            count = (count + dp[i, j]) % Mod;

        if (j == 0)
            count = (count + dp[i, j]) % Mod;

        return count;
    }

    private static int UpdateTemp(int[,] dp, int i, int j, int m, int n)
    {
        return (
            ((i > 0 ? dp[i - 1, j] : 0) + (i < m - 1 ? dp[i + 1, j] : 0)) % Mod +
            ((j > 0 ? dp[i, j - 1] : 0) + (j < n - 1 ? dp[i, j + 1] : 0)) % Mod
        ) % Mod;
    }
}
