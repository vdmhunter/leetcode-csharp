namespace LeetCodeCSharpApp.MinimumTimeToCollectAllApplesInATree01;

public class Solution
{
    public int MinTime(int n, int[][] edges, IList<bool> hasApple)
    {
        var graph = new Dictionary<int, List<int>>();

        for (var i = 0; i < n; i++)
            graph.Add(i, new List<int>());

        foreach (var edge in edges)
        {
            graph[edge[0]].Add(edge[1]);
            graph[edge[1]].Add(edge[0]);
        }

        var visited = new bool[n];
        var count = Dfs(graph, 0, visited, hasApple);

        return count;
    }

    private static int Dfs(Dictionary<int, List<int>> graph, int node, IList<bool> visited, IList<bool> hasApple)
    {
        visited[node] = true;

        var distance = graph[node]
            .Where(neighbour => !visited[neighbour])
            .Sum(neighbour => Dfs(graph, neighbour, visited, hasApple));

        if ((distance > 0 || hasApple[node]) && node != 0)
            distance += 2;

        return distance;
    }
}
