namespace LeetCodeCSharpApp.NumberOfClosedIslands01;

/// <summary>
/// DFS
/// </summary>
public class Solution
{
    public int ClosedIsland(int[][] grid)
    {
        int rows = grid.Length, cols = grid[0].Length, count = 0;

        for (var i = 0; i < rows; i++)
            for (var j = 0; j < cols; j++)
                if (grid[i][j] == 0 && Dfs(grid, i, j))
                    count++;

        return count;
    }

    private static bool Dfs(int[][] grid, int i, int j)
    {
        int rows = grid.Length, cols = grid[0].Length;

        if (i < 0 || j < 0 || i >= rows || j >= cols)
            return false;

        if (grid[i][j] == 1)
            return true;

        grid[i][j] = 1;
        bool left = Dfs(grid, i, j - 1), right = Dfs(grid, i, j + 1);
        bool up = Dfs(grid, i - 1, j), down = Dfs(grid, i + 1, j);

        return left && right && up && down;
    }
}
