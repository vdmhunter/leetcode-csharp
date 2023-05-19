namespace LeetCodeCSharpApp.IsGraphBipartite02;

public class Solution
{
    public bool IsBipartite(int[][] graph)
    {
        var n = graph.Length;
        var color = new int[n]; // 0: uncolored; 1: color A; -1: color B

        for (var i = 0; i < n; i++)
            if (color[i] == 0 && !Bfs(graph, color, i))
                return false;

        return true;
    }

    private static bool Bfs(int[][] graph, int[] color, int start)
    {
        var q = new Queue<int>();

        color[start] = 1;
        q.Enqueue(start);

        while (q.Count > 0)
        {
            var cur = q.Dequeue();

            foreach (var neighbor in graph[cur])
                if (color[neighbor] == 0)
                {
                    color[neighbor] = -color[cur];
                    q.Enqueue(neighbor);
                }
                else if (color[neighbor] == color[cur])
                    return false;
        }

        return true;
    }
}
