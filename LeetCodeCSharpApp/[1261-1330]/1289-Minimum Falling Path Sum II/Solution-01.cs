namespace LeetCodeCSharpApp.MinimumFallingPathSumII01;

public class Solution
{
    public int MinFallingPathSum(int[][] grid)
    {
        for (var i = 1; i < grid.Length; i++)
        {
            int[] r = grid[i - 1].OrderBy(x => x).Take(2).ToArray();

            for (var j = 0; j < grid[0].Length; j++)
                grid[i][j] += grid[i - 1][j] == r[0] ? r[1] : r[0];
        }

        return grid[^1].Min();
    }
}
