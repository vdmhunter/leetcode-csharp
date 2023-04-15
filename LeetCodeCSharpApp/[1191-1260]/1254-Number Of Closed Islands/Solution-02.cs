namespace LeetCodeCSharpApp.NumberOfClosedIslands02;

/// <summary>
/// BFS
/// </summary>
public class Solution
{
    public int ClosedIsland(int[][] grid)
    {
        var numRows = grid.Length;
        var numCols = grid[0].Length;
        var numClosedIslands = 0;

        var visited = new bool[numRows, numCols];

        int[] dx = { 0, 0, -1, 1 };
        int[] dy = { -1, 1, 0, 0 };

        for (var i = 0; i < numRows; i++)
            for (var j = 0; j < numCols; j++)
                if (grid[i][j] == 0 && !visited[i, j])
                    ExploreIsland(i, j, visited, dx, dy, numRows, numCols, grid, ref numClosedIslands);

        return numClosedIslands;
    }

    private void ExploreIsland(int row, int col, bool[,]? visited, int[] dx, int[] dy, int numRows, int numCols,
        int[][] grid, ref int numClosedIslands)
    {
        var queue = new Queue<int[]>();
        queue.Enqueue(new[] { row, col });
        visited![row, col] = true;

        var isClosed = true;

        while (queue.Count > 0)
        {
            var curr = queue.Dequeue();

            for (var i = 0; i < 4; i++)
                isClosed = IsClosed(curr, i);
        }

        if (isClosed)
            numClosedIslands++;

        #region IsClosed

        bool IsClosed(int[] curr1, int i)
        {
            var x = curr1[0] + dx[i];
            var y = curr1[1] + dy[i];

            if (x >= 0 && y >= 0 && x < numRows && y < numCols)
            {
                if (grid[x][y] != 0 || visited[x, y])
                    return isClosed;

                queue.Enqueue(new[] { x, y });
                visited[x, y] = true;
            }
            else
                isClosed = false;

            return isClosed;
        }

        #endregion
    }
}
