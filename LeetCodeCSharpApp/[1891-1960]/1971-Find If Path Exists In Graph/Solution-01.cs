namespace LeetCodeCSharpApp.FindIfPathExistsInGraph01;

public class Solution
{
    public bool ValidPath(int n, int[][] edges, int source, int destination)
    {
        var graph = new Dictionary<int, List<int>>();

        for (var i = 0; i < n; i++)
            graph.Add(i, new List<int>());

        foreach (var edge in edges)
        {
            graph[edge[0]].Add(edge[1]);
            graph[edge[1]].Add(edge[0]);
        }

        var visited = new HashSet<int>();
        var queue = new Queue<int>();
        queue.Enqueue(source);
        visited.Add(source);

        while (queue.Count > 0)
        {
            var node = queue.Dequeue();

            if (node == destination)
                return true;

            foreach (var neighbor in graph[node].Where(neighbor => !visited.Contains(neighbor)))
            {
                queue.Enqueue(neighbor);
                visited.Add(neighbor);
            }
        }

        return false;
    }
}
