namespace LeetCodeCSharpApp.CountUnreachablePairsOfNodesInAnUndirectedGraph01;

public class Solution
{
    public long CountPairs(int n, int[][] edges)
    {
        var dsu = new UnionFindSet(n);

        foreach (var edge in edges)
            dsu.Union(edge[0], edge[1]);

        var componentSize = new Dictionary<int, int>();

        for (var i = 0; i < n; i++)
        {
            var parent = dsu.Find(i);
            componentSize[parent] = componentSize.GetValueOrDefault(parent, 0) + 1;
        }

        long numberOfPaths = 0;
        long remainingNodes = n;

        foreach (var size in componentSize.Values)
        {
            numberOfPaths += size * (remainingNodes - size);
            remainingNodes -= size;
        }

        return numberOfPaths;
    }

    private class UnionFindSet
    {
        private readonly int[] _parent;

        public UnionFindSet(int size)
        {
            _parent = new int[size];

            for (var i = 0; i < _parent.Length; ++i)
                _parent[i] = i;
        }

        public void Union(int x, int y)
        {
            _parent[Find(x)] = _parent[Find(y)];
        }

        public int Find(int x)
        {
            if (_parent[x] != x)
                _parent[x] = Find(_parent[x]);

            return _parent[x];
        }
    }
}
