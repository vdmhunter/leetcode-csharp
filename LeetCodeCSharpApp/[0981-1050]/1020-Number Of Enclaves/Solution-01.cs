namespace LeetCodeCSharpApp.NumberOfEnclaves01;

public class Solution
{
    public int NumEnclaves(int[][] grid)
    {
        var m = grid.Length;
        var n = grid[0].Length;

        for (var i = 0; i < m; i++)
            for (var j = 0; j < n; j++)
                if ((i == 0 || j == 0 || i == m - 1 || j == n - 1) && grid[i][j] == 1)
                    Dfs(grid, i, j);

        return grid.Sum(row => row.Sum());
    }

    private static void Dfs(int[][] grid, int i, int j)
    {
        grid[i][j] = 0;
        int[][] directions = { new[] { -1, 0 }, new[] { 1, 0 }, new[] { 0, -1 }, new[] { 0, 1 } };

        foreach (var direction in directions)
        {
            var x = i + direction[0];
            var y = j + direction[1];

            if (x >= 0 && x < grid.Length && y >= 0 && y < grid[0].Length && grid[x][y] == 1)
                Dfs(grid, x, y);
        }
    }
}
