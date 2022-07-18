namespace LeetCodeCSharpApp.NumberOfIslands01;

/// <summary>
/// DFS
/// </summary>
public class Solution
{
    public int NumIslands(char[][] grid)
    {
        var count = 0;
        
        for (var i = 0; i < grid.Length; i++)
            for (var j = 0; j < grid[0].Length; j++)
                if (grid[i][j] == '1')
                {
                    DfsFill(grid, i, j);
                    count++;
                }

        return count;
    }

    private void DfsFill(char[][] grid, int i, int j)
    {
        if (i >= 0 && j >= 0 && i < grid.Length && j < grid[0].Length && grid[i][j] == '1')
        {
            grid[i][j] = '0';
            
            DfsFill(grid, i + 1, j);
            DfsFill(grid, i - 1, j);
            DfsFill(grid, i, j + 1);
            DfsFill(grid, i, j - 1);
        }
    }
}
