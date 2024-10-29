namespace LeetCodeCSharpApp.MaximumNumberOfMovesInAGrid01;

public class Solution
{
    public int MaxMoves(int[][] grid)
    {
        int rows = grid.Length, cols = grid[0].Length;
        var dp = new int[rows, 2];

        for (var i = 0; i < rows; i++)
            dp[i, 0] = 1;

        var maxMoves = 0;

        for (var j = 1; j < cols; j++)
        {
            for (var i = 0; i < rows; i++)
            {
                dp[i, 1] = CalculateMaxMoves(grid, dp, i, j);
                maxMoves = Math.Max(maxMoves, dp[i, 1] - 1);
            }

            UpdateDpForNextColumn(dp, rows);
        }

        return maxMoves;
    }

    private static int CalculateMaxMoves(int[][] grid, int[,] dp, int row, int col)
    {
        var maxMove = 0;

        if (grid[row][col] > grid[row][col - 1] && dp[row, 0] > 0)
            maxMove = Math.Max(maxMove, dp[row, 0] + 1);

        if (row - 1 >= 0 && grid[row][col] > grid[row - 1][col - 1] && dp[row - 1, 0] > 0)
            maxMove = Math.Max(maxMove, dp[row - 1, 0] + 1);

        if (row + 1 < grid.Length && grid[row][col] > grid[row + 1][col - 1] && dp[row + 1, 0] > 0)
            maxMove = Math.Max(maxMove, dp[row + 1, 0] + 1);

        return maxMove;
    }

    private static void UpdateDpForNextColumn(int[,] dp, int rows)
    {
        for (var i = 0; i < rows; i++)
        {
            dp[i, 0] = dp[i, 1];
            dp[i, 1] = 0;
        }
    }
}
