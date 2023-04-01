namespace LeetCodeCSharpApp.CheckKnightTourConfiguration01;

public class Solution
{
    public bool CheckValidGrid(int[][] grid)
    {
        var n = grid.Length;
        int[] dx = { -2, -2, -1, -1, 1, 1, 2, 2 };
        int[] dy = { -1, 1, -2, 2, -2, 2, -1, 1 };
        var visited = new bool[n, n];

        // Start the tour from the top-left cell
        int x = 0, y = 0;
        visited[x, y] = true;

        // Check if the knight can move to each of the remaining cells in the grid
        for (var i = 1; i < n * n; i++)
        {
            int nextX = -1, nextY = -1;

            // Find the next cell that the knight can move to
            FindNextMove(grid, x, dx, y, dy, n, visited, i, ref nextX, ref nextY);

            // If there's no valid cell to move to, the configuration is invalid
            if (nextX == -1 || nextY == -1)
                return false;

            // Move to the next cell and mark it as visited
            x = nextX;
            y = nextY;
            visited[x, y] = true;
        }

        // If all cells are visited, the configuration is valid
        return true;
    }

    private static void FindNextMove(int[][] grid, int x, int[] dx, int y, int[] dy, int n, bool[,] visited, int i,
        ref int nextX, ref int nextY)
    {
        for (var j = 0; j < 8; j++)
        {
            var nx = x + dx[j];
            var ny = y + dy[j];

            if (!IsValid(nx, ny, n) || visited[nx, ny] || !CanMove(x, y, nx, ny) || grid[nx][ny] != i)
                continue;

            nextX = nx;
            nextY = ny;

            break;
        }
    }

    // Helper function to check if the knight can move from cell (x1, y1) to cell (x2, y2)
    private static bool CanMove(int x1, int y1, int x2, int y2)
    {
        var dx = Math.Abs(x1 - x2);
        var dy = Math.Abs(y1 - y2);
            
        return (dx == 1 && dy == 2) || (dx == 2 && dy == 1);
    }

    // Helper function to check if the given (x, y) position is a valid cell on the board
    private static bool IsValid(int x, int y, int n) => x >= 0 && x < n && y >= 0 && y < n;
}
