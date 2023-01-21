namespace LeetCodeCSharpApp.SumOfDistancesInTree01;

public class Solution
{
    public int[] SumOfDistancesInTree(int n, int[][] edges)
    {
        var result = new int[n];
        var graph = new List<int>[n];
        var count = new int[n];
        Array.Fill(count, 1);

        for (var i = 0; i < graph.Length; i++)
            graph[i] = new List<int>();

        foreach (var edge in edges)
        {
            graph[edge[0]].Add(edge[1]);
            graph[edge[1]].Add(edge[0]);
        }

        PostOrder(0, -1, graph, count, result);
        PreOrder(0, -1, graph, count, result, n);

        return result;
    }

    private static void PostOrder(int node, int parent, List<int>[] graph, int[] count, int[] result)
    {
        foreach (var child in graph[node].Where(child => child != parent))
        {
            PostOrder(child, node, graph, count, result);
            count[node] += count[child];
            result[node] += result[child] + count[child];
        }
    }

    private static void PreOrder(int node, int parent, List<int>[] graph, int[] count, int[] result, int n)
    {
        foreach (var child in graph[node].Where(child => child != parent))
        {
            result[child] = result[node] + (n - count[child]) - count[child];
            PreOrder(child, node, graph, count, result, n);
        }
    }
}
