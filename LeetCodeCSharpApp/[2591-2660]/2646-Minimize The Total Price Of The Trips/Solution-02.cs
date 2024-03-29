namespace LeetCodeCSharpApp.MinimizeTheTotalPriceOfTheTrips02;

public class Solution
{
    public int MinimumTotalPrice(int n, int[][] edges, int[] price, int[][] trips)
    {
        var tree = InitTree(n, edges);
        var cnt = new int[n];

        foreach (var trip in trips)
        {
            var up = new Dictionary<int, int> { [trip[0]] = -1 };

            Bfs(trip, tree, up);

            for (var u = trip[1]; u >= 0; u = up[u])
                cnt[u]++;
        }

        var (w, h) = Dfs(0, -1, tree, price, cnt);

        return Math.Min(w, h);
    }

    private static List<List<int>> InitTree(int n, int[][] edges)
    {
        var tree = new List<List<int>>();

        for (var i = 0; i < n; i++)
            tree.Add(new List<int>());

        foreach (var e in edges)
        {
            tree[e[0]].Add(e[1]);
            tree[e[1]].Add(e[0]);
        }

        return tree;
    }

    private static void Bfs(int[] trip, List<List<int>> tree, Dictionary<int, int> up)
    {
        var q = new Queue<(int, int)>();
        q.Enqueue((trip[0], -1));

        while (q.Count > 0)
        {
            var (u, p) = q.Dequeue();

            if (u == trip[1])
                break;

            foreach (var v in tree[u].Where(v => v != p))
            {
                q.Enqueue((v, u));
                up[v] = u;
            }
        }
    }

    private static (int, int) Dfs(int u, int p, List<List<int>> tree, int[] price, int[] cnt)
    {
        int whole = 0, halved = 0;

        foreach (var v in tree[u].Where(v => v != p))
        {
            var (w, h) = Dfs(v, u, tree, price, cnt);
            whole += w;
            halved += Math.Min(w, h);
        }

        return (price[u] * cnt[u] + halved, price[u] * cnt[u] / 2 + whole);
    }
}
