namespace LeetCodeCSharpApp.FindCriticalAndPseudoCriticalEdgesInMinimumSpanningTree01;

public class Solution
{
    public IList<IList<int>> FindCriticalAndPseudoCriticalEdges(int n, int[][] edges)
    {
        for (var i = 0; i < edges.Length; ++i)
        {
            Array.Resize(ref edges[i], edges[i].Length + 1);
            edges[i][3] = i;
        }

        Array.Sort(edges, (a, b) => a[2].CompareTo(b[2]));

        var j = GetMST(n, edges, -1);

        List<int> critical = new(), nonCritical = new();

        for (var i = 0; i < edges.Length; ++i)
            if (j < GetMST(n, edges, i))
                critical.Add(edges[i][3]);
            else if (j == GetMST(n, edges, -1, i))
                nonCritical.Add(edges[i][3]);

        return new List<IList<int>> { critical, nonCritical };
    }

    private static int GetMST(int n, int[][] edges, int blockedge, int preEdge = -1)
    {
        var uf = new UnionFind(n);
        var weight = 0;

        if (preEdge != -1)
        {
            weight += edges[preEdge][2];
            uf.Union(edges[preEdge][0], edges[preEdge][1]);
        }

        for (var i = 0; i < edges.Length; ++i)
        {
            if (i == blockedge)
                continue;

            var edge = edges[i];

            if (uf.Find(edge[0]) == uf.Find(edge[1]))
                continue;

            uf.Union(edge[0], edge[1]);
            weight += edge[2];
        }

        for (var i = 0; i < n; ++i)
            if (uf.Find(i) != uf.Find(0))
                return int.MaxValue;

        return weight;
    }

    private class UnionFind
    {
        private readonly int[] _parent;
        private readonly int[] _rank;

        public UnionFind(int n)
        {
            _rank = new int[n];
            _parent = new int[n];

            for (var i = 0; i < n; ++i)
            {
                _parent[i] = i;
                _rank[i] = 1;
            }
        }

        public int Find(int x)
        {
            if (x == _parent[x])
                return x;

            return _parent[x] = Find(_parent[x]);
        }

        public void Union(int x, int y)
        {
            int fx = Find(x), fy = Find(y);

            if (fx == fy)
                return;

            if (_rank[fx] > _rank[fy])
                (fx, fy) = (fy, fx);

            _parent[fx] = fy;

            if (_rank[fx] == _rank[fy])
                _rank[fy]++;
        }
    }
}
