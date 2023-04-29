namespace LeetCodeCSharpApp.SnakesAndLadders01;

public class Solution
{
    public int SnakesAndLadders(int[][] board)
    {
        var n = board.Length;
        var cells = new KeyValuePair<int, int>[n * n + 1];
        var columns = new int[n];
        var label = 1;

        for (var i = 0; i < n; i++) columns[i] = i;
        for (var row = n - 1; row >= 0; row--)
        {
            foreach (var column in columns)
                cells[label++] = new KeyValuePair<int, int>(row, column);

            Array.Reverse(columns);
        }

        var dist = new int[n * n + 1];
        Array.Fill(dist, -1);
        dist[1] = 0;

        var q = new Queue<int>();
        q.Enqueue(1);

        while (q.Count > 0)
        {
            var curr = q.Dequeue();

            for (var next = curr + 1; next <= Math.Min(curr + 6, n * n); next++)
            {
                int row = cells[next].Key, column = cells[next].Value;
                var destination = board[row][column] != -1 ? board[row][column] : next;

                if (dist[destination] != -1)
                    continue;

                dist[destination] = dist[curr] + 1;
                q.Enqueue(destination);
            }
        }

        return dist[n * n];
    }
}
