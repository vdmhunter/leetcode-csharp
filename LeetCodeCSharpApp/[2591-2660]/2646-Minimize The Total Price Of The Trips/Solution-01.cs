namespace LeetCodeCSharpApp.MinimizeTheTotalPriceOfTheTrips01;

public class Solution
{
    public int MinimumTotalPrice(int n, int[][] edges, int[] price, int[][] trips)
    {
        var tree = new List<List<int>>();

        for (var i = 0; i < n; i++)
            tree.Add(new List<int>());

        foreach (var edge in edges)
        {
            tree[edge[0]].Add(edge[1]);
            tree[edge[1]].Add(edge[0]);
        }

        var counts = new Dictionary<int, int>();

        foreach (var trip in trips)
            Bfs(tree, trip[0], trip[1], counts);

        var currPrice = new int[n];

        for (var i = 0; i < n; i++)
            currPrice[i] = counts.GetValueOrDefault(i, 0) * price[i];

        var result = Helper(tree, 0, -1, currPrice);

        return Math.Min(result[0], result[1]);
    }

    private static int[] Helper(List<List<int>> tree, int curr, int parent, int[] currPrice)
    {
        var neighbors = tree[curr];
        var whole = 0;
        var halved = 0;

        foreach (var n in neighbors)
        {
            if (n == parent)
                continue;

            var neiResult = Helper(tree, n, curr, currPrice);
            whole += neiResult[0];
            halved += Math.Min(neiResult[0], neiResult[1]);
        }

        return new[] { currPrice[curr] + halved, currPrice[curr] / 2 + whole };
    }

    private static void Bfs(List<List<int>> tree, int src, int dst, Dictionary<int, int> counts)
    {
        var n = tree.Count;
        var parent = Enumerable.Repeat(-1, n).ToArray();

        var visited = new bool[n];
        visited[src] = true;

        int curr;

        var queue = new Queue<int>();
        queue.Enqueue(src);

        while (queue.Count > 0)
        {
            curr = queue.Dequeue();

            if (curr == dst)
                break;

            foreach (var nei in tree[curr].Where(nei => !visited[nei]))
            {
                visited[nei] = true;
                parent[nei] = curr;
                queue.Enqueue(nei);
            }
        }

        curr = dst;

        while (curr != -1)
        {
            counts[curr] = counts.GetValueOrDefault(curr, 0) + 1;
            curr = parent[curr];
        }
    }
}
