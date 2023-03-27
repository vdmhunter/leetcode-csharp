namespace LeetCodeCSharpApp.MinimumPathSum01;

public class Solution
{
    public int MinPathSum(int[][] grid)
    {
        for (var i = 0; i < grid.Length; i++)
            for (var j = 0; j < grid[i].Length; j++)
            {
                switch (i)
                {
                    case 0 when j == 0:
                        continue;
                    case 0:
                        grid[i][j] += grid[i][j - 1];
                        continue;
                }

                if (j == 0)
                {
                    grid[i][j] += grid[i - 1][j];

                    continue;
                }

                grid[i][j] += Math.Min(grid[i][j - 1], grid[i - 1][j]);
            }

        return grid[^1][grid[0].Length - 1];
    }
}
