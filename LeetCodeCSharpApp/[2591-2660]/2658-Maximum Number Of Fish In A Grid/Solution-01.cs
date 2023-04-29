namespace LeetCodeCSharpApp.MaximumNumberOfFishInAGrid01;

public class Solution
{
    public int FindMaxFish(int[][] grid)
    {
        var result = 0;
        var m = grid.Length;
        var n = grid[0].Length;

        for (var i = 0; i < m; i++)
        {
            for (var j = 0; j < n; j++)
                if (grid[i][j] > 0)
                    result = Math.Max(result, Dfs(grid, i, j));
        }

        return result;
    }

    private static int Dfs(int[][] grid, int i, int j)
    {
        if (i < 0 || i >= grid.Length || j < 0 || j >= grid[0].Length || grid[i][j] == 0)
            return 0;

        var result = grid[i][j];
        grid[i][j] = 0;

        result += Dfs(grid, i + 1, j);
        result += Dfs(grid, i - 1, j);
        result += Dfs(grid, i, j + 1);
        result += Dfs(grid, i, j - 1);

        return result;
    }
}
