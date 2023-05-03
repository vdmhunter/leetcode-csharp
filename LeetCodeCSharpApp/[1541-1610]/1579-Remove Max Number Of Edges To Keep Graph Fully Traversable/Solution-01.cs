namespace LeetCodeCSharpApp.RemoveMaxNumberOfEdgesToKeepGraphFullyTraversable01;

public class Solution
{
    public int MaxNumEdgesToRemove(int n, int[][] edges)
    {
        var uf1 = new UnionFind(n + 1);
        var uf2 = new UnionFind(n + 1);
        int result = 0, e1 = 0;

        result += ProcessEdges(edges, 3, uf1, ref e1);
        uf2.Id = new List<int>(uf1.Id);
        var e2 = e1;

        result += ProcessEdges(edges, 1, uf1, ref e1);
        result += ProcessEdges(edges, 2, uf2, ref e2);

        return e1 == e2 && e1 == n - 1 ? result : -1;
    }

    private static int ProcessEdges(int[][] edges, int t, UnionFind uf, ref int e)
    {
        var result = 0;

        foreach (var edge in edges)
        {
            if (edge[0] != t)
                continue;

            if (!uf.Connected(edge[1], edge[2]))
            {
                uf.Connect(edge[1], edge[2]);
                e++;
            }
            else
                result++;
        }

        return result;
    }

    private class UnionFind
    {
        public List<int> Id;

        public UnionFind(int n)
        {
            Id = Enumerable.Range(0, n).ToList();
        }

        public void Connect(int a, int b)
        {
            int x = Find(a), y = Find(b);

            if (x == y)
                return;

            Id[x] = y;
        }

        public bool Connected(int i, int j)
        {
            return Find(i) == Find(j);
        }

        private int Find(int a)
        {
            return Id[a] == a ? a : Id[a] = Find(Id[a]);
        }
    }
}
