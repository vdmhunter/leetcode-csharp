// ReSharper disable IdentifierTypo

namespace LeetCodeCSharpApp.PossibleBipartition01;

public class Solution
{
    public bool PossibleBipartition(int n, int[][] dislikes)
    {
        var graph = new List<int>[n + 1];

        for (var i = 1; i <= n; i++)
            graph[i] = new List<int>();

        foreach (var dislike in dislikes)
        {
            graph[dislike[0]].Add(dislike[1]);
            graph[dislike[1]].Add(dislike[0]);
        }

        var colors = new int[n + 1];

        for (var i = 1; i <= n; i++)
            if (colors[i] == 0 && !Dfs(graph, colors, i, 1))
                return false;

        return true;
    }

    private static bool Dfs(List<int>[] graph, int[] colors, int node, int color)
    {
        if (colors[node] != 0)
            return colors[node] == color;

        colors[node] = color;

        return graph[node].All(neighbor => Dfs(graph, colors, neighbor, -color));
    }
}
