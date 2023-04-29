namespace LeetCodeCSharpApp.OutOfBoundaryPaths03;

/// <summary>
/// Dynamic Programming
/// </summary>
public class Solution
{
    private const int M = 1000000007;

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
                    if (i == m - 1)
                        count = (count + dp[i, j]) % M;

                    if (j == n - 1)
                        count = (count + dp[i, j]) % M;

                    if (i == 0)
                        count = (count + dp[i, j]) % M;

                    if (j == 0)
                        count = (count + dp[i, j]) % M;

                    temp[i, j] =
                    (
                        ((i > 0 ? dp[i - 1, j] : 0) + (i < m - 1 ? dp[i + 1, j] : 0)) % M +
                        ((j > 0 ? dp[i, j - 1] : 0) + (j < n - 1 ? dp[i, j + 1] : 0)) % M
                    ) % M;
                }

            dp = temp;
        }

        return count;
    }
}
