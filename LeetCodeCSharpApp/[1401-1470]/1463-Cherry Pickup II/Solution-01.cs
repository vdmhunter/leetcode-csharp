namespace LeetCodeCSharpApp.CherryPickupII01;

public class Solution
{
    public int CherryPickup(int[][] grid)
    {
        int m = grid.Length, n = grid[0].Length;
        var dp = new int?[m][][];

        for (var i = 0; i < m; i++)
        {
            dp[i] = new int?[n][];

            for (var j = 0; j < n; j++)
                dp[i][j] = new int?[n];
        }

        return Dfs(grid, m, n, 0, 0, n - 1, dp);
    }

    private static int Dfs(int[][] grid, int m, int n, int r, int c1, int c2, int?[][][] dp)
    {
        if (r == m)
            return 0;
        if (dp[r][c1][c2].HasValue)
            return dp[r][c1][c2]!.Value;

        var result = 0;

        for (var i = -1; i <= 1; i++)
        {
            for (var j = -1; j <= 1; j++)
            {
                int nc1 = c1 + i, nc2 = c2 + j;

                if (nc1 >= 0 && nc1 < n && nc2 >= 0 && nc2 < n)
                    result = Math.Max(result, Dfs(grid, m, n, r + 1, nc1, nc2, dp));
            }
        }

        var cherries = c1 == c2 ? grid[r][c1] : grid[r][c1] + grid[r][c2];

        return (int)(dp[r][c1][c2] = result + cherries);
    }
}
