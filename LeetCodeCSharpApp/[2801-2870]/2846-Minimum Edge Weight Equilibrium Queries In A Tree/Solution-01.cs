namespace LeetCodeCSharpApp.MinimumEdgeWeightEquilibriumQueriesInATree01;

public class Solution
{
    public int[] MinOperationsQueries(int n, int[][] edges, int[][] queries)
    {
        const int m = 15;
        const int c = 27;

        var g = Enumerable.Range(0, n).Select(_ => new List<(int, int)>()).ToArray();

        foreach (var e in edges)
        {
            g[e[0]].Add((e[1], e[2]));
            g[e[1]].Add((e[0], e[2]));
        }

        var fa = Enumerable.Range(0, m).Select(_ => new int[n]).ToArray();
        var w = Enumerable.Range(0, n).Select(_ => new int[c]).ToArray();

        var d = new int[n];
        Dfs(0, 0, 0, g, fa, w, d);

        for (var i = 1; i < m; i++)
            for (var j = 0; j < n; j++)
                fa[i][j] = fa[i - 1][fa[i - 1][j]];

        var result = new int[queries.Length];

        for (var i = 0; i < queries.Length; i++)
        {
            int x = queries[i][0], y = queries[i][1], l = Lca(x, y, fa, d);
            var length = d[x] + d[y] - 2 * d[l];
            var maxZ = 0;

            for (var z = 1; z < c; z++)
            {
                var numZ = w[x][z] + w[y][z] - w[l][z] * 2;
                maxZ = Math.Max(maxZ, numZ);
            }

            result[i] = length - maxZ;
        }

        return result;
    }

    private static void Dfs(int x, int f, int dep, List<(int, int)>[] g, int[][] fa, int[][] w, int[] d)
    {
        fa[0][x] = f;
        d[x] = dep;

        foreach (var (c, weight) in g[x])
        {
            if (f == c)
                continue;

            for (var j = 0; j < w[c].Length; j++)
                w[c][j] = w[x][j];

            w[c][weight]++;
            Dfs(c, x, dep + 1, g, fa, w, d);
        }
    }

    private static int Lca(int x, int y, int[][] fa, int[] d)
    {
        var m = fa.Length;

        if (d[x] > d[y])
            (x, y) = (y, x);

        for (var p = 0; 1 << p <= d[y] - d[x]; p++)
            if (((1 << p) & (d[y] - d[x])) != 0)
                y = fa[p][y];

        for (var p = m - 1; p >= 0; p--)
        {
            if (fa[p][x] == fa[p][y])
                continue;

            x = fa[p][x];
            y = fa[p][y];
        }

        return x == y ? x : fa[0][x];
    }
}