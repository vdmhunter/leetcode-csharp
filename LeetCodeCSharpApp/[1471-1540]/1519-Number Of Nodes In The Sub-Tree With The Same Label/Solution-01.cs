namespace LeetCodeCSharpApp.NumberOfNodesInTheSubTreeWithTheSameLabel01;

/// <summary>
/// DFS
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

        Dfs(graph, 0, -1, labels, result);

        return result;
    }

    private static int[] Dfs(Dictionary<int, List<int>> graph, int current, int parent, string labels, int[] result)
    {
        var count = new int[26];
        count[labels[current] - 'a']++;

        foreach (var child in graph[current])
        {
            if (child == parent)
                continue;

            var childCount = Dfs(graph, child, current, labels, result);

            for (var j = 0; j < 26; j++)
                count[j] += childCount[j];
        }

        result[current] = count[labels[current] - 'a'];

        return count;
    }
}
