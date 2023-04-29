namespace LeetCodeCSharpApp.CountNumberOfPossibleRootNodes01;

public class Solution
{
    private readonly Dictionary<(int, int), int> _visited = new();
    private readonly Dictionary<(int, int), int> _g = new();

    public int RootCount(int[][] edges, int[][] guesses, int k)
    {
        var n = edges.Length;

        foreach (var g in guesses)
            _g[(g[0], g[1])] = 1;

        var adj = new List<List<int>>();

        for (var i = 0; i <= n; i++)
            adj.Add(new List<int>());

        for (var i = 0; i < n; i++)
        {
            adj[edges[i][0]].Add(edges[i][1]);
            adj[edges[i][1]].Add(edges[i][0]);
        }

        var count = 0;

        for (var i = 0; i <= n; i++)
        {
            var guess = Dp(adj, i, -1);

            if (guess >= k)
                count++;
        }

        return count;
    }

    private int Dp(List<List<int>> adj, int node, int par)
    {
        if (_visited.ContainsKey((par, node)))
            return _visited[(par, node)];

        var guess = _g.ContainsKey((par, node)) ? 1 : 0;

        for (var i = 0; i < adj[node].Count; i++)
            if (adj[node][i] != par)
                guess += Dp(adj, adj[node][i], node);

        return _visited[(par, node)] = guess;
    }
}
