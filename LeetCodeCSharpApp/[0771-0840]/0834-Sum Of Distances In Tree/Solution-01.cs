namespace LeetCodeCSharpApp.SumOfDistancesInTree01;

public class Solution
{
    public int[] SumOfDistancesInTree(int n, int[][] edges)
    {
        var graph = new List<int>[n];
        var count = new int[n];
        Array.Fill(count, 1);
        var answer = new int[n];

        for (var i = 0; i < graph.Length; i++)
            graph[i] = new List<int>();

        foreach (var edge in edges)
        {
            graph[edge[0]].Add(edge[1]);
            graph[edge[1]].Add(edge[0]);
        }

        PostOrder(0, -1, graph, count, answer);
        PreOrder(0, -1, graph, count, answer, n);

        return answer;
    }

    private static void PostOrder(int node, int parent, List<int>[] graph, int[] count, int[] answer)
    {
        foreach (var child in graph[node].Where(child => child != parent))
        {
            PostOrder(child, node, graph, count, answer);
            count[node] += count[child];
            answer[node] += answer[child] + count[child];
        }
    }

    private static void PreOrder(int node, int parent, List<int>[] graph, int[] count, int[] answer, int n)
    {
        foreach (var child in graph[node].Where(child => child != parent))
        {
            answer[child] = answer[node] + (n - count[child]) - count[child];
            PreOrder(child, node, graph, count, answer, n);
        }
    }
}
