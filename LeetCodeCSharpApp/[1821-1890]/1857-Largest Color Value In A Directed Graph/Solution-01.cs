namespace LeetCodeCSharpApp.LargestColorValueInADirectedGraph01;

public class Solution
{
    public int LargestPathValue(string colors, int[][] edges)
    {
        const int k = 26;

        var n = colors.Length;
        var inDegrees = new int[n];
        var graph = InitGraphAndInDegrees(edges, n, inDegrees);

        var counts = new int[n, k];

        for (var i = 0; i < n; i++)
            counts[i, colors[i] - 'a']++;

        int maxCount = 0, visited = 0;
        var zeroIndegree = InitZeroIndegree(n, inDegrees);

        while (zeroIndegree.Count > 0)
        {
            var u = zeroIndegree.First();
            zeroIndegree.Remove(u);
            visited++;

            foreach (var v in graph[u])
            {
                for (var i = 0; i < k; i++)
                    counts[v, i] = Math.Max(counts[v, i], counts[u, i] + (colors[v] - 'a' == i ? 1 : 0));

                inDegrees[v]--;

                if (inDegrees[v] == 0)
                    zeroIndegree.Add(v);
            }

            maxCount = Math.Max(maxCount, Enumerable.Range(0, k).Select(i => counts[u, i]).Max());
        }

        return visited == n ? maxCount : -1;
    }

    private static List<int>[] InitGraphAndInDegrees(int[][] edges, int n, int[] inDegrees)
    {
        var graph = new List<int>[n];

        for (var i = 0; i < n; i++)
            graph[i] = new List<int>();

        foreach (var edge in edges)
        {
            int u = edge[0], v = edge[1];
            graph[u].Add(v);
            inDegrees[v]++;
        }

        return graph;
    }

    private static HashSet<int> InitZeroIndegree(int n, int[] inDegrees)
    {
        var zeroIndegree = new HashSet<int>();

        for (var i = 0; i < n; i++)
            if (inDegrees[i] == 0)
                zeroIndegree.Add(i);

        return zeroIndegree;
    }
}
