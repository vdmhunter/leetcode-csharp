// ReSharper disable IdentifierTypo

namespace LeetCodeCSharpApp.NumberOfGoodPaths01;

public class Solution
{
    public int NumberOfGoodPaths(int[] vals, int[][] edges)
    {
        Dictionary<int, List<int>> v = new(), c = new();

        for (var i = 0; i < vals.Length; i++)
        {
            if (!v.ContainsKey(vals[i]))
                v[vals[i]] = new List<int>();

            v[vals[i]].Add(i);
        }

        for (var i = 0; i < vals.Length; i++)
            c[i] = new List<int>();

        foreach (var e in edges)
        {
            c[e[0]].Add(e[1]);
            c[e[1]].Add(e[0]);
        }

        return IterateAllNodes(vals, v, c, vals.Length);
    }

    private static int IterateAllNodes(int[] vals, Dictionary<int, List<int>> v, Dictionary<int, List<int>> c,
        int result)
    {
        var uf = new UnionFind(vals.Length);

        foreach (var (cv, vn) in v.OrderBy(x => x.Key))
        {
            foreach (var n in vn)
                Union(n, cv);

            Dictionary<int, int> sbg = new();

            Increase(vn, sbg);

            foreach (var (_, s) in sbg.Where(x => x.Value >= 2))
                result += s * (s - 1) / 2;
        }

        #region Union

        void Union(int n, int cv)
        {
            foreach (var cn in c[n].Where(x => vals[x] <= cv))
                uf.Union(n, cn);
        }

        #endregion

        #region Increase

        void Increase(List<int> vn, Dictionary<int, int> sbg)
        {
            foreach (var g in vn.Select(uf.Find))
            {
                if (!sbg.ContainsKey(g))
                    sbg[g] = 0;

                sbg[g]++;
            }
        }

        #endregion

        return result;
    }
}

public class UnionFind
{
    private readonly int[] _parent;
    private readonly int[] _size;

    public UnionFind(int n)
    {
        _parent = new int[n];
        _size = new int[n];

        for (var i = 0; i < n; i++)
        {
            _parent[i] = i;
            _size[i] = 1;
        }
    }

    public int Find(int node)
    {
        while (node != _parent[node])
        {
            _parent[node] = _parent[_parent[node]];
            node = _parent[node];
        }

        return node;
    }

    public void Union(int u, int v)
    {
        int parentU = Find(u), parentV = Find(v);

        if (parentU == parentV)
            return;

        if (_size[parentU] < _size[parentV])
        {
            _parent[parentU] = parentV;
            _size[parentV] += _size[parentU];
        }
        else
        {
            _parent[parentV] = parentU;
            _size[parentU] += _size[parentV];
        }
    }
}
