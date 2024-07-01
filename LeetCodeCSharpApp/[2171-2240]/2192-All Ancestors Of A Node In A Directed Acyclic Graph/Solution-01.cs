namespace LeetCodeCSharpApp.AllAncestorsOfANodeInADirectedAcyclicGraph01;

public class Solution
{
    public IList<IList<int>> GetAncestors(int n, int[][] edges)
    {
        var result = new List<IList<int>>();
        var dc = new List<List<int>>();

        for (var i = 0; i < n; i++)
        {
            result.Add(new List<int>());
            dc.Add([]);
        }

        foreach (int[] e in edges)
            dc[e[0]].Add(e[1]);

        for (var i = 0; i < n; i++)
            Dfs(i, i, result, dc);

        return result;
    }

    private static void Dfs(int x, int curr, IList<IList<int>> result, List<List<int>> dc)
    {
        foreach (int ch in dc[curr])
        {
            if (result[ch].Count != 0 && result[ch][result[ch].Count - 1] == x)
                continue;

            result[ch].Add(x);
            Dfs(x, ch, result, dc);
        }
    }
}
