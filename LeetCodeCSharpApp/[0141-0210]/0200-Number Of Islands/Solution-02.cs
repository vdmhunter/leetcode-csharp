namespace LeetCodeCSharpApp.NumberOfIslands02;

/// <summary>
/// BFS
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
                    BfsFill(grid, i, j);
                    count++;
                }

        return count;
    }

    private static void BfsFill(char[][] grid, int x, int y)
    {
        grid[x][y] = '0';
        
        var n = grid.Length;
        var m = grid[0].Length;
        var queue = new Queue<int>();
        var code = x * m + y;
        
        queue.Enqueue(code);
        
        while (queue.Count != 0)
        {
            code = queue.Dequeue();
            
            var i = code / m;
            var j = code % m;
            
            if (i > 0 && grid[i - 1][j] == '1') //search upward and mark adjacent '1's as '0'.
            {
                queue.Enqueue((i - 1) * m + j);
                grid[i - 1][j] = '0';
            }

            if (i < n - 1 && grid[i + 1][j] == '1') //down
            {
                queue.Enqueue((i + 1) * m + j);
                grid[i + 1][j] = '0';
            }

            if (j > 0 && grid[i][j - 1] == '1') //left
            {
                queue.Enqueue(i * m + j - 1);
                grid[i][j - 1] = '0';
            }

            if (j < m - 1 && grid[i][j + 1] == '1') //right
            {
                queue.Enqueue(i * m + j + 1);
                grid[i][j + 1] = '0';
            }
        }
    }
}
