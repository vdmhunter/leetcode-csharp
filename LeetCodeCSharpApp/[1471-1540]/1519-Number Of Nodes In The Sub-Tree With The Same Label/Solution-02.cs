namespace LeetCodeCSharpApp.NumberOfNodesInTheSubTreeWithTheSameLabel02;

/// <summary>
/// BFS
/// </summary>
public class Solution
{
    public int[] CountSubTrees(int n, int[][] edges, string labels)
    {
        var graph = new Dictionary<int, List<int>>();

        for (var i = 0; i < n; i++)
            graph[i] = new List<int>();

        foreach (var edge in edges)
        {
            graph[edge[1]].Add(edge[0]);
            graph[edge[0]].Add(edge[1]);
        }

        var result = new int[n];

        Bfs(n, labels, graph, result);

        return result;
    }

    private static void Bfs(int n, string labels, Dictionary<int, List<int>> graph, int[] result)
    {
        var counts = new int[n, 26];
        Queue<int> queue = new();

        for (var i = 0; i < n; i++)
        {
            counts[i, labels[i] - 'a'] = 1;

            if (i != 0 && graph[i].Count == 1)
                queue.Enqueue(i);
        }

        while (queue.Count > 0)
            ProcessTheQueue();

        for (var i = 0; i < n; i++)
            result[i] = counts[i, labels[i] - 'a'];

        #region ProcessTheQueue

        void ProcessTheQueue()
        {
            var current = queue.Dequeue();
            var parent = graph[current].First();

            graph[parent].Remove(current);

            for (var j = 0; j < 26; j++)
                counts[parent, j] += counts[current, j];

            if (parent != 0 && graph[parent].Count == 1)
                queue.Enqueue(parent);
        }

        #endregion
    }
}
