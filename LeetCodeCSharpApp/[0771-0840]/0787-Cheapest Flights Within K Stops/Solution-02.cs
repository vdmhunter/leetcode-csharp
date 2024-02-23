namespace LeetCodeCSharpApp.CheapestFlightsWithinKStops02;

/// <summary>
///     Dijkstra
///     Time complexity: O(n + e * k * log(e * k))
///     Space complexity: O(n + e * k)
/// </summary>
public class Solution
{
    public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int k)
    {
        var adj = CreateAdjacencyList(flights);
        var stops = InitializeMinStops(n);

        var pq = new PriorityQueue<int[], int>();
        pq.Enqueue([0, src, 0], 0);

        while (pq.Count > 0)
        {
            var temp = pq.Dequeue();
            var dist = temp[0];
            var node = temp[1];
            var steps = temp[2];

            if (steps > stops[node] || steps > k + 1)
                continue;

            stops[node] = steps;

            if (node == dst)
                return dist;

            if (!adj.ContainsKey(node))
                continue;

            foreach (var a in adj[node])
                pq.Enqueue([dist + a[1], a[0], steps + 1], dist + a[1]);
        }

        return -1;
    }

    private static Dictionary<int, List<int[]>> CreateAdjacencyList(int[][] flights)
    {
        var result = new Dictionary<int, List<int[]>>();

        foreach (var flight in flights)
        {
            var source = flight[0];
            var destination = flight[1];
            var price = flight[2];

            if (!result.ContainsKey(source))
                result[source] = [];

            result[source].Add([destination, price]);
        }

        return result;
    }

    private static int[] InitializeMinStops(int n)
    {
        var result = new int[n];

        for (var i = 0; i < n; i++)
            result[i] = int.MaxValue;

        return result;
    }
}
