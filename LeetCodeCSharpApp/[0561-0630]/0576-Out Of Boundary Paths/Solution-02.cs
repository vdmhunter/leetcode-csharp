namespace LeetCodeCSharpApp.OutOfBoundaryPaths02;

/// <summary>
/// Recursion with Memoization
/// </summary>
public class Solution
{
    private const int M = 1000000007;

    public int FindPaths(int m, int n, int maxMove, int startRow, int startColumn)
    {
        var memo = new int[m, n, maxMove + 1];

        for (var i = 0; i < m; i++)
            for (var j = 0; j < n; j++)
                for (var k = 0; k < maxMove + 1; k++)
                    memo[i, j, k] = -1;

        return FindPaths(m, n, maxMove, startRow, startColumn, memo);
    }

    private int FindPaths(int m, int n, int maxMove, int startRow, int startColumn, int[,,] memo)
    {
        if (startRow == m || startColumn == n || startRow < 0 || startColumn < 0)
            return 1;

        if (maxMove == 0)
            return 0;

        if (memo[startRow, startColumn, maxMove] >= 0)
            return memo[startRow, startColumn, maxMove];

        memo[startRow, startColumn, maxMove] =
        (
            (FindPaths(m, n, maxMove - 1, startRow - 1, startColumn, memo) +
             FindPaths(m, n, maxMove - 1, startRow + 1, startColumn, memo)) % M +
            (FindPaths(m, n, maxMove - 1, startRow, startColumn - 1, memo) +
             FindPaths(m, n, maxMove - 1, startRow, startColumn + 1, memo)) % M
        ) % M;

        return memo[startRow, startColumn, maxMove];
    }
}
