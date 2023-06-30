namespace LeetCodeCSharpApp.LastDayWhereYouCanStillCross01;

public class Solution
{
    private readonly int[][] _directions = { new[] { 1, 0 }, new[] { -1, 0 }, new[] { 0, 1 }, new[] { 0, -1 } };

    public int LatestDayToCross(int row, int col, int[][] cells)
    {
        var left = 1;
        var right = row * col;

        while (left < right)
        {
            var mid = right - (right - left) / 2;

            if (CanCross(row, col, cells, mid))
                left = mid;
            else
                right = mid - 1;
        }

        return left;
    }

    private bool CanCross(int row, int col, int[][] cells, int day)
    {
        var grid = new int[row][];

        for (var i = 0; i < row; i++)
            grid[i] = new int[col];

        for (var i = 0; i < day; i++)
        {
            var r = cells[i][0] - 1;
            var c = cells[i][1] - 1;
            grid[r][c] = 1;
        }

        for (var i = 0; i < col; i++)
            if (grid[0][i] == 0 && Dfs(grid, 0, i, row, col))
                return true;

        return false;
    }

    private bool Dfs(int[][] grid, int r, int c, int row, int col)
    {
        if (r < 0 || r >= row || c < 0 || c >= col || grid[r][c] != 0)
            return false;

        if (r == row - 1)
            return true;

        grid[r][c] = -1;

        foreach (var dir in _directions)
        {
            var newR = r + dir[0];
            var newC = c + dir[1];

            if (Dfs(grid, newR, newC, row, col))
                return true;
        }

        return false;
    }
}
