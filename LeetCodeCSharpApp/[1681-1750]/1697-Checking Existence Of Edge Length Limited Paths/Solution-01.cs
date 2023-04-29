namespace LeetCodeCSharpApp.CheckingExistenceOfEdgeLengthLimitedPaths01;

public class Solution
{
    public bool[] DistanceLimitedPathsExist(int n, int[][] edgeList, int[][] queries)
    {
        var result = new bool[queries.Length];

        for (var i = 0; i < queries.Length; ++i)
            queries[i] = queries[i].Concat(new[] { i }).ToArray();

        Array.Sort(queries, (a, b) => a[2].CompareTo(b[2]));
        Array.Sort(edgeList, (a, b) => a[2].CompareTo(b[2]));

        var uf = new UnionFind(n);
        var j = 0;

        foreach (var q in queries)
        {
            int u = q[0], v = q[1], limit = q[2], qid = q[3];

            for (; j < edgeList.Length && edgeList[j][2] < limit; ++j)
                uf.Connect(edgeList[j][0], edgeList[j][1]);

            result[qid] = uf.Connected(u, v);
        }

        return result;
    }

    private class UnionFind
    {
        private readonly List<int> _id;

        public UnionFind(int n)
        {
            _id = Enumerable.Range(0, n).ToList();
        }

        public void Connect(int a, int b)
        {
            int x = Find(a), y = Find(b);

            if (x == y)
                return;

            _id[x] = y;
        }

        public bool Connected(int i, int j)
        {
            return Find(i) == Find(j);
        }

        private int Find(int a)
        {
            return _id[a] == a ? a : _id[a] = Find(_id[a]);
        }
    }
}
