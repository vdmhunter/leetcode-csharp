namespace LeetCodeCSharpApp.ShortestCycleInAGraph01;

public class Solution
{
    public int FindShortestCycle(int n, int[][] edges)
    {
        var g = new List<List<int>>();

        for (var i = 0; i < n; ++i)
            g.Add(new List<int>());

        foreach (var e in edges)
        {
            g[e[0]].Add(e[1]);
            g[e[1]].Add(e[0]);
        }

        const int inf = 10000;
        var result = inf;

        for (var i = 0; i < n; ++i)
            result = Math.Min(result, Root(i));

        int Root(int i)
        {
            var dis = Enumerable.Repeat(inf, n).ToList();
            var fa = Enumerable.Repeat(-1, n).ToList();
            dis[i] = 0;
            var bfs = new Queue<int>(new[] { i });

            while (bfs.Count > 0)
            {
                i = bfs.Dequeue();

                foreach (var j in g[i])
                    if (dis[j] == inf)
                    {
                        dis[j] = 1 + dis[i];
                        fa[j] = i;
                        bfs.Enqueue(j);
                    }
                    else if (fa[i] != j)
                        return dis[i] + dis[j] + 1;
            }

            return inf;
        }

        return result < inf ? result : -1;
    }
}
