namespace LeetCodeCSharpApp.AsFarFromLandAsPossible01;

public class Solution
{
    public int MaxDistance(int[][] grid)
    {
        var length = grid.Length;
        var dp = new int[length, length];

        for (var i = 0; i < length; i++)
            for (var j = 0; j < length; j++)
                dp[i, j] = grid[i][j] == 1 ? 0 : int.MaxValue;

        for (var i = 0; i < length; i++)
            for (var j = 0; j < length; j++)
                if (grid[i][j] == 0)
                {
                    if (j > 0 && dp[i, j - 1] != int.MaxValue)
                        dp[i, j] = Math.Min(dp[i, j], 1 + dp[i, j - 1]);

                    if (i > 0 && dp[i - 1, j] != int.MaxValue)
                        dp[i, j] = Math.Min(dp[i, j], 1 + dp[i - 1, j]);
                }

        var result = 0;

        for (var i = length - 1; i >= 0; i--)
            for (var j = length - 1; j >= 0; j--)
                if (grid[i][j] == 0)
                {
                    if (j < length - 1 && dp[i, j + 1] != int.MaxValue)
                        dp[i, j] = Math.Min(dp[i, j], 1 + dp[i, j + 1]);

                    if (i < length - 1 && dp[i + 1, j] != int.MaxValue)
                        dp[i, j] = Math.Min(dp[i, j], 1 + dp[i + 1, j]);

                    if (dp[i, j] != int.MaxValue && result < dp[i, j])
                        result = dp[i, j];
                }

        if (result == 0)
            return -1;

        return result;
    }
}
