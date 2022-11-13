namespace LeetCodeCSharpApp.MostProfitablePathInATree01;

public class Solution
{
    public int MostProfitablePath(int[][] edges, int bob, int[] amount)
    {
        var graph = new List<int>[amount.Length];

        for (var i = 0; i < amount.Length; i++)
            graph[i] = new List<int>();

        foreach (var edge in edges)
        {
            graph[edge[0]].Add(edge[1]);
            graph[edge[1]].Add(edge[0]);
        }

        return Dfs(graph, 0, bob, amount, new bool[amount.Length], 1)[0];
    }

    private static int[] Dfs(List<int>[] graph, int node, int bob, int[] amount, bool[] seen, int height)
    {
        var result = int.MinValue;
        seen[node] = true;

        var bobPathLen = node == bob ? 1 : 0;

        foreach (var tmp in from nextNode in graph[node]
                 where !seen[nextNode]
                 select Dfs(graph, nextNode, bob, amount, seen, height + 1))
        {
            if (tmp[1] > 0)
                bobPathLen = tmp[1] + 1;

            result = Math.Max(result, tmp[0]);
        }

        if (bobPathLen <= 0 || bobPathLen > height)
            return new[] { result == int.MinValue ? amount[node] : amount[node] + result, bobPathLen };

        if (bobPathLen == height)
            amount[node] /= 2;
        else
            amount[node] = 0;

        return new[] { result == int.MinValue ? amount[node] : amount[node] + result, bobPathLen };
    }
}
