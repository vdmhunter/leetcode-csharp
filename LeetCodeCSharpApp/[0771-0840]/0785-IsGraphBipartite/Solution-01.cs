namespace LeetCodeCSharpApp.IsGraphBipartite01;

public class Solution
{
    public bool IsBipartite(int[][] graph)
    {
        var n = graph.Length;
        var colors = new int[n];

        for (var i = 0; i < n; i++)
            if (colors[i] == 0 && !Dfs(graph, colors, i, 1))
                return false;

        return true;
    }

    private static bool Dfs(int[][] graph, int[] colors, int i, int color)
    {
        colors[i] = color;

        for (var j = 0; j < graph[i].Length; j++)
        {
            var k = graph[i][j]; // adjacent node

            if (colors[k] == -color)
                continue;

            if (colors[k] == color || !Dfs(graph, colors, k, -color))
                return false;
        }

        return true;
    }
}
