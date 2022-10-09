namespace LeetCodeCSharpApp.PathsInMatrixWhoseSumIsDivisibleByK01;

public class Solution
{
    public int NumberOfPaths(int[][] grid, int k)
    {
        const int mod = 1_000_000_007;
        
        int m = grid.Length, n = grid[0].Length;

        var dp = new int[m, n, k];
        dp[0, 0, grid[0][0] % k] = 1;

        for (var i = 0; i < m; i++)
            for (var j = 0; j < n; j++)
                for (var s = 0; s < k; s++)
                    UpdateDp(j, i, (s + grid[i][j]) % k, s);

        void UpdateDp(int j, int i, int moddedSum, int s)
        {
            if (j > 0)
                dp[i, j, moddedSum] += dp[i, j - 1, s];

            if (i > 0)
                dp[i, j, moddedSum] += dp[i - 1, j, s];
            
            dp[i, j, moddedSum] %= mod;
        }

        return dp[m - 1, n - 1, 0];
    }
}
