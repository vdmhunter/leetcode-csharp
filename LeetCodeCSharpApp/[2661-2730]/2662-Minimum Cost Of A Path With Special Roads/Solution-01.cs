namespace LeetCodeCSharpApp.MinimumCostOfAPathWithSpecialRoads01;

public class Solution
{
    public int MinimumCost(int[] start, int[] target, int[][] specialRoads)
    {
        var n = specialRoads.Length;
        var graph = BuildGraph(n, start, target, specialRoads);
        var dist = Dijkstra(graph);

        return Math.Min(dist[2 * n + 1], Math.Abs(target[0] - start[0]) + Math.Abs(target[1] - start[1]));
    }

    private static List<(int, int)>[] BuildGraph(int n, int[] start, int[] target, int[][] specialRoads)
    {
        var graph = new List<(int, int)>[2 * n + 2];

        for (var i = 0; i < 2 * n + 2; i++)
            graph[i] = new List<(int, int)>();

        for (var i = 0; i < n; i++)
        {
            graph[0].Add((i + 1,
                Math.Abs(specialRoads[i][0] - start[0]) +
                Math.Abs(specialRoads[i][1] - start[1])));

            graph[i + 1].Add((n + i + 1,
                specialRoads[i][4]));

            graph[n + i + 1].Add((2 * n + 1,
                Math.Abs(specialRoads[i][2] - target[0]) +
                Math.Abs(specialRoads[i][3] - target[1])));

            for (var j = 0; j < n; j++)
                if (i != j)
                    graph[n + i + 1].Add((j + 1,
                        Math.Abs(specialRoads[i][2] - specialRoads[j][0]) +
                        Math.Abs(specialRoads[i][3] - specialRoads[j][1])));
        }

        return graph;
    }

    private static int[] Dijkstra(List<(int, int)>[] graph)
    {
        var n = graph.Length;
        var dist = InitializeDistArray(n);
        var visited = new bool[n];

        for (var i = 0; i < n; i++)
        {
            var u = FindClosestUnvisitedNode(dist, visited);

            visited[u] = true;

            foreach (var (v, w) in graph[u])
                if (dist[u] + w < dist[v])
                    dist[v] = dist[u] + w;
        }

        return dist;
    }

    private static int[] InitializeDistArray(int n)
    {
        var dist = new int[n];
        Array.Fill(dist, int.MaxValue);
        dist[0] = 0;

        return dist;
    }

    private static int FindClosestUnvisitedNode(int[] dist, bool[] visited)
    {
        var u = -1;

        for (var j = 0; j < dist.Length; j++)
            if (!visited[j] && (u == -1 || dist[j] < dist[u]))
                u = j;

        return u;
    }
}
