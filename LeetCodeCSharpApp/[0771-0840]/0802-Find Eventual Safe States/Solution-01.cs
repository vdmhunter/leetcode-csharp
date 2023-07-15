namespace LeetCodeCSharpApp.FindEventualSafeStates01;

public class Solution
{
    public IList<int> EventualSafeNodes(int[][] graph)
    {
        var result = new List<int>();

        if (graph == null || graph.Length == 0)
            return result;

        var nodeCount = graph.Length;
        var color = new int[nodeCount];

        for (var i = 0; i < nodeCount; i++)
            if (Dfs(graph, i, color))
                result.Add(i);

        return result;
    }

    private static bool Dfs(int[][] graph, int start, int[] color)
    {
        if (color[start] != 0)
            return color[start] == 1;

        color[start] = 2;

        if (graph[start].Any(newNode => !Dfs(graph, newNode, color)))
            return false;

        color[start] = 1;

        return true;
    }
}
