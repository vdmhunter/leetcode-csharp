namespace LeetCodeCSharpApp.MaxAreaOfIsland02;

/// <summary>
/// Depth-First Search (Iterative)
/// </summary>
public class Solution
{
    private readonly int[] _dc = { 0, 0, 1, -1 };
    private readonly int[] _dr = { 1, -1, 0, 0 };
    private int[][] _grid = null!;
    private bool[][] _seen = null!;

    public int MaxAreaOfIsland(int[][] grid)
    {
        _grid = grid;
        _seen = new bool[grid.Length][];

        for (var i = 0; i < grid.Length; i++)
            _seen[i] = new bool[grid[0].Length];

        var result = 0;

        for (var r = 0; r < grid.Length; r++)
            for (var c = 0; c < grid[0].Length; c++)
                if (grid[r][c] == 1 && !_seen[r][c])
                    result = Math.Max(result, Area(r, c));

        return result;
    }

    private int Area(int r, int c)
    {
        if (!IsInGrid(r, c) || _grid[r][c] != 1 || _seen[r][c])
            return 0;

        _seen[r][c] = true;
        var shape = 1;

        for (var k = 0; k < 4; k++)
            shape += Area(r + _dr[k], c + _dc[k]);

        return shape;
    }

    private bool IsInGrid(int nr, int nc)
    {
        return !(nr < 0 || nr >= _grid.Length || nc < 0 || nc >= _grid[0].Length);
    }
}
