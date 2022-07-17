namespace LeetCodeCSharpApp.MaxAreaOfIsland01;

/// <summary>
/// Depth-First Search (Recursive)
/// </summary>
public class Solution
{
    private int[][]? _grid;
    private bool[][]? _seen;

    public int MaxAreaOfIsland(int[][] grid)
    {
        _grid = grid;
        _seen = new bool[grid.Length][];
        for (var i = 0; i < grid.Length; i++)
            _seen[i] = new bool[grid[0].Length];

        var ans = 0;

        for (var r = 0; r < grid.Length; r++)
            for (var c = 0; c < grid[0].Length; c++)
                ans = Math.Max(ans, Area(r, c));

        return ans;
    }

    private int Area(int r, int c)
    {
        if (r < 0 || r >= _grid!.Length || c < 0 || c >= _grid[0].Length || _seen![r][c] || _grid[r][c] == 0)
            return 0;

        _seen[r][c] = true;

        return 1 + Area(r + 1, c) + Area(r - 1, c) + Area(r, c - 1) + Area(r, c + 1);
    }
}
