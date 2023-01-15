namespace LeetCodeCSharpApp.NearestExitFromEntranceInMaze01;

public class Solution
{
    private readonly int[] _dir = { 0, -1, 0, 1, 0 };

    public int NearestExit(char[][] maze, int[] entrance)
    {
        var q = new Queue<int[]>(); // i, j, steps
        q.Enqueue(new[] { entrance[0], entrance[1], 0 });

        while (q.Count != 0)
        {
            var e = q.Dequeue();
            int i = e[0], j = e[1], steps = e[2];
            

            if ((i != entrance[0] || j != entrance[1]) &&
                (i == 0 || j == 0 || i == maze.Length - 1 || j == maze[i].Length - 1))
                return steps;

            CheckDirections(maze, i, j, q, steps);
        }

        return -1;
    }

    private void CheckDirections(char[][] maze, int i, int j, Queue<int[]> q, int steps)
    {
        for (var d = 0; d < 4; d++)
        {
            int di = i + _dir[d], dj = j + _dir[d + 1];

            if (di < 0 || dj < 0 || di >= maze.Length || dj >= maze[di].Length || maze[di][dj] != '.')
                continue;

            maze[di][dj] = '+';
            q.Enqueue(new[] { di, dj, steps + 1 });
        }
    }
}
