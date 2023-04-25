// ReSharper disable IdentifierTypo

namespace LeetCodeCSharpApp.SimilarStringGroups01;

public class Solution
{
    public int NumSimilarGroups(string[] strs)
    {
        var n = strs.Length;
        var ds = new DisjointSet(n);

        for (var i = 0; i < n; i++)
        {
            for (var j = i + 1; j < n; j++)
                if (Similar(strs[i], strs[j]))
                    ds.Join(i, j);
        }

        return ds.Size;
    }

    private static bool Similar(string a, string b)
    {
        var n = 0;

        for (var i = 0; i < a.Length; i++)
            if (a[i] != b[i] && ++n > 2)
                return false;

        return true;
    }

    private class DisjointSet
    {
        private readonly int[] _parent;

        public int Size { get; private set; }

        public DisjointSet(int n)
        {
            _parent = new int[n];

            for (var i = 0; i < n; i++)
                _parent[i] = i;

            Size = n;
        }

        private int Find(int x)
        {
            if (x == _parent[x])
                return x;

            return _parent[x] = Find(_parent[x]);
        }

        public void Join(int x, int y)
        {
            x = Find(x);
            y = Find(y);

            if (x == y)
                return;

            _parent[x] = y;
            Size--;
        }
    }
}
