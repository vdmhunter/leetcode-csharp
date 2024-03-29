namespace LeetCodeCSharpApp.DesignGraphWithShortestPathCalculator01;

public class Graph
{
    private readonly List<List<int[]>> _g;

    public Graph(int n, int[][] edges)
    {
        _g = new List<List<int[]>>();

        for (var i = 0; i < n; i++)
            _g.Add(new List<int[]>());

        foreach (var e in edges)
            _g[e[0]].Add(new[] { e[1], e[2] });
    }

    public void AddEdge(int[] e)
    {
        _g[e[0]].Add(new[] { e[1], e[2] });
    }

    public int ShortestPath(int node1, int node2)
    {
        var pq = new PriorityQueue<int[], int[]>(Comparer<int[]>.Create((a, b) => b[0].CompareTo(a[0])));
        var cost = new int[_g.Count];

        for (var i = 0; i < _g.Count; i++)
            cost[i] = int.MaxValue;

        cost[node1] = 0;
        pq.Enqueue(new[] { 0, node1 }, new[] { 0, node1 });

        while (pq.Count > 0 && pq.Peek()[1] != node2)
        {
            var cur = pq.Dequeue();
            var nc = cur[0];
            var i = cur[1];

            foreach (var next in _g[i])
            {
                var j = next[0];
                var c = next[1];

                if (-nc + c >= cost[j])
                    continue;

                cost[j] = -nc + c;
                pq.Enqueue(new[] { nc - c, j }, new[] { nc - c, j });
            }
        }

        return cost[node2] == int.MaxValue ? -1 : cost[node2];
    }
}
