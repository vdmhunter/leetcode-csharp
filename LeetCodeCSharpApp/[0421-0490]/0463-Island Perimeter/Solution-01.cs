namespace LeetCodeCSharpApp.IslandPerimeter01;

public class Solution
{
    public int IslandPerimeter(int[][] grid)
    {
        var m = grid.Length;

        if (m == 0)
            return 0;

        var n = grid[0].Length;
        var result = 0;

        for (var i = 0; i < m; i++)
            for (var j = 0; j < n; j++)
                if (grid[i][j] == 1)
                    result += CalculatePerimeter(grid, i, j);

        return result;
    }

    private static int CalculatePerimeter(int[][] grid, int i, int j)
    {
        var perimeter = 0;
        var m = grid.Length;
        var n = grid[0].Length;

        if (IsBoundaryOrWater(grid, i - 1, j, m, n))
            perimeter++;

        if (IsBoundaryOrWater(grid, i + 1, j, m, n))
            perimeter++;

        if (IsBoundaryOrWater(grid, i, j - 1, m, n))
            perimeter++;

        if (IsBoundaryOrWater(grid, i, j + 1, m, n))
            perimeter++;

        return perimeter;
    }

    private static bool IsBoundaryOrWater(int[][] grid, int i, int j, int m, int n)
    {
        return i < 0 || j < 0 || i >= m || j >= n || grid[i][j] == 0;
    }
}