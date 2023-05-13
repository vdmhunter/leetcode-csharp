namespace LeetCodeCSharpApp.AsFarFromLandAsPossible01;

public class Solution
{
    public int MaxDistance(int[][] grid)
    {
        var length = grid.Length;
        var dp = InitializeDP(grid, length);

        UpdateDPFromTopLeft(grid, length, dp);
        var result = UpdateDPFromBottomRight(grid, length, dp);

        return result == 0 ? -1 : result;
    }

    private static int[,] InitializeDP(int[][] grid, int length)
    {
        var dp = new int[length, length];

        for (var i = 0; i < length; i++)
            for (var j = 0; j < length; j++)
                dp[i, j] = grid[i][j] == 1 ? 0 : int.MaxValue;

        return dp;
    }

    private static void UpdateDPFromTopLeft(int[][] grid, int length, int[,] dp)
    {
        for (var i = 0; i < length; i++)
            for (var j = 0; j < length; j++)
                if (grid[i][j] == 0)
                    UpdateDP(dp, i, j, -1);
    }

    private static int UpdateDPFromBottomRight(int[][] grid, int length, int[,] dp)
    {
        var result = 0;

        for (var i = length - 1; i >= 0; i--)
            for (var j = length - 1; j >= 0; j--)
                if (grid[i][j] == 0)
                {
                    UpdateDP(dp, i, j, 1);
                    result = Math.Max(result, dp[i, j]);
                }

        return result == int.MaxValue ? 0 : result;
    }

    private static void UpdateDP(int[,] dp, int i, int j, int offset)
    {
        if (j + offset >= 0 && j + offset < dp.GetLength(1) && dp[i, j + offset] != int.MaxValue)
            dp[i, j] = Math.Min(dp[i, j], 1 + dp[i, j + offset]);

        if (i + offset >= 0 && i + offset < dp.GetLength(0) && dp[i + offset, j] != int.MaxValue)
            dp[i, j] = Math.Min(dp[i, j], 1 + dp[i + offset, j]);
    }
}
