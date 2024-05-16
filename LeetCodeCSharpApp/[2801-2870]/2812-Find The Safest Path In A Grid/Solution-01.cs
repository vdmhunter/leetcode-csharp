namespace LeetCodeCSharpApp.FindTheSafestPathInAGrid01;

public class Solution
{
    private static readonly int[] DeltasRow = [0, 0, -1, 1];
    private static readonly int[] DeltasCol = [-1, 1, 0, 0];

    public int MaximumSafenessFactor(IList<IList<int>> grid)
    {
        int n = grid.Count;

        if (grid[0][0] == 1 || grid[n - 1][n - 1] == 1)
            return 0;

        int[][] score = InitializeScoreGrid(n);
        Bfs(grid, score, n);

        bool[][] visited = InitializeVisitedGrid(n);

        return FindMaximumSafenessFactor(score, n, visited);
    }

    private static int[][] InitializeScoreGrid(int n)
    {
        var score = new int[n][];

        for (var i = 0; i < n; i++)
        {
            score[i] = new int[n];

            for (var j = 0; j < n; j++)
                score[i][j] = int.MaxValue;
        }

        return score;
    }

    private static bool[][] InitializeVisitedGrid(int n)
    {
        var visited = new bool[n][];

        for (var i = 0; i < n; i++)
            visited[i] = new bool[n];

        return visited;
    }

    private static void Bfs(
        IList<IList<int>> grid,
        int[][] score,
        int n)
    {
        Queue<int[]> queue = InitializeQueueWithStartingPoints(grid, score, n);

        while (queue.Count > 0)
        {
            int[] current = queue.Dequeue();
            int x = current[0], y = current[1];
            int currentScore = score[x][y];

            ProcessNeighbors(queue, score, currentScore, x, y, n);
        }
    }

    private static Queue<int[]> InitializeQueueWithStartingPoints(
        IList<IList<int>> grid,
        int[][] score,
        int n)
    {
        var queue = new Queue<int[]>();

        for (var row = 0; row < n; row++)
        {
            for (var col = 0; col < n; col++)
            {
                if (grid[row][col] != 1)
                    continue;

                score[row][col] = 0;
                queue.Enqueue([row, col]);
            }
        }

        return queue;
    }

    private static void ProcessNeighbors(
        Queue<int[]> queue,
        int[][] score,
        int currentScore,
        int x,
        int y,
        int n)
    {
        for (var i = 0; i < 4; i++)
        {
            int newX = x + DeltasRow[i];
            int newY = y + DeltasCol[i];

            if (!IsWithinBounds(newX, newY, n) || score[newX][newY] <= currentScore + 1)
                continue;

            score[newX][newY] = currentScore + 1;
            queue.Enqueue([newX, newY]);
        }
    }

    private static bool IsWithinBounds(int x, int y, int n)
    {
        return x >= 0 && x < n && y >= 0 && y < n;
    }

    private static int FindMaximumSafenessFactor(
        int[][] score,
        int n,
        bool[][] visited)
    {
        var priorityQueue = new PriorityQueue<int[], int>(Comparer<int>.Create((a, b) => b - a));
        priorityQueue.Enqueue([score[0][0], 0, 0], score[0][0]);

        while (priorityQueue.Count > 0)
        {
            int[] current = priorityQueue.Dequeue();
            int currentSafeScore = current[0];
            int x = current[1], y = current[2];

            if (x == n - 1 && y == n - 1)
                return currentSafeScore;

            visited[x][y] = true;
            EnqueueValidNeighbors(priorityQueue, visited, score, currentSafeScore, x, y, n);
        }

        return -1;
    }

    private static void EnqueueValidNeighbors(
        PriorityQueue<int[], int> priorityQueue,
        bool[][] visited,
        int[][] score,
        int currentSafeScore,
        int x,
        int y,
        int n)
    {
        for (var i = 0; i < 4; i++)
        {
            int newX = x + DeltasRow[i];
            int newY = y + DeltasCol[i];

            if (!IsWithinBounds(newX, newY, n) || visited[newX][newY])
                continue;

            int newSafeScore = Math.Min(currentSafeScore, score[newX][newY]);
            priorityQueue.Enqueue([newSafeScore, newX, newY], newSafeScore);
            visited[newX][newY] = true;
        }
    }
}
