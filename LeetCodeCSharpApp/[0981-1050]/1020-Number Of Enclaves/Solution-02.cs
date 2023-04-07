namespace LeetCodeCSharpApp.NumberOfEnclaves02;

public class Solution
{
    public int NumEnclaves(int[][] grid)
    {
        var m = grid.Length;
        var n = grid[0].Length;

        for (var i = 0; i < m; i++)
            for (var j = 0; j < n; j++)
                if ((i == 0 || j == 0 || i == m - 1 || j == n - 1) && grid[i][j] == 1)
                    Bfs(grid, i, j);

        return grid.Sum(row => row.Sum());
    }

    private static void Bfs(int[][] grid, int i, int j)
    {
        var queue = new Queue<int[]>();
        queue.Enqueue(new[] { i, j });

        while (queue.Any())
        {
            var curr = queue.Dequeue();
            var x = curr[0];
            var y = curr[1];

            if (grid[x][y] == 0) continue;

            grid[x][y] = 0;
            var directions = new[] { new[] { -1, 0 }, new[] { 1, 0 }, new[] { 0, -1 }, new[] { 0, 1 } };

            foreach (var direction in directions)
            {
                var newX = x + direction[0];
                var newY = y + direction[1];

                if (newX >= 0 && newX < grid.Length &&
                    newY >= 0 && newY < grid[0].Length && grid[newX][newY] == 1)
                {
                    queue.Enqueue(new[] { newX, newY });
                }
            }
        }
    }
}
