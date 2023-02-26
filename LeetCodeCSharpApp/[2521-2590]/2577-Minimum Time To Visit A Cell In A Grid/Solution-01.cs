namespace LeetCodeCSharpApp.MinimumTimeToVisitACellInAGrid01;

public class Solution
{
    public int MinimumTime(int[][] grid)
    {
        if (grid[0][1] > 1 && grid[1][0] > 1)
            return -1;

        int m = grid.Length, n = grid[0].Length;
        var dirs = new[] { new[] { 1, 0 }, new[] { -1, 0 }, new[] { 0, 1 }, new[] { 0, -1 } };
        var visited = new bool[m, n];
        var pq = new PriorityQueue<int[], int[]>(Comparer<int[]>.Create((a, b) => a[0].CompareTo(b[0])));
        var init = new[] { grid[0][0], 0, 0 };
        pq.Enqueue(init, init);

        while (pq.Count > 0)
        {
            var curr = pq.Dequeue();
            int time = curr[0], row = curr[1], col = curr[2];

            if (row == m - 1 && col == n - 1)
                return time;

            if (visited[row, col])
                continue;

            visited[row, col] = true;

            foreach (var dir in dirs)
            {
                int r = row + dir[0], c = col + dir[1];

                if (r < 0 || r >= m || c < 0 || c >= n || visited[r, c])
                    continue;

                var wait = (grid[r][c] - time) % 2 == 0 ? 1 : 0;
                var next = new[] { Math.Max(grid[r][c] + wait, time + 1), r, c };
                pq.Enqueue(next, next);
            }
        }

        return -1;
    }
}
