namespace LeetCodeCSharpApp.MinimumHeightTrees01;

public class Solution
{
    public IList<int> FindMinHeightTrees(int n, int[][] edges)
    {
        if (n == 1)
            return new List<int> { 0 };

        List<HashSet<int>> adj = InitializeAdjacencyList(n, edges);
        List<int> leaves = FindInitialLeaves(adj);

        return TrimLeaves(n, adj, leaves);
    }

    private static List<HashSet<int>> InitializeAdjacencyList(int n, int[][] edges)
    {
        var adj = new List<HashSet<int>>(n);

        for (var i = 0; i < n; ++i)
            adj.Add([]);

        foreach (int[] edge in edges)
        {
            adj[edge[0]].Add(edge[1]);
            adj[edge[1]].Add(edge[0]);
        }

        return adj;
    }

    private static List<int> FindInitialLeaves(List<HashSet<int>> adj)
    {
        var leaves = new List<int>();

        for (var i = 0; i < adj.Count; ++i)
            if (adj[i].Count == 1)
                leaves.Add(i);

        return leaves;
    }

    private static List<int> TrimLeaves(int n, List<HashSet<int>> adj, List<int> leaves)
    {
        while (n > 2)
        {
            n -= leaves.Count;
            var newLeaves = new List<int>();

            foreach (int i in leaves)
            {
                int j = adj[i].First();
                adj[j].Remove(i);

                if (adj[j].Count == 1)
                    newLeaves.Add(j);
            }

            leaves = newLeaves;
        }

        return leaves;
    }
}
