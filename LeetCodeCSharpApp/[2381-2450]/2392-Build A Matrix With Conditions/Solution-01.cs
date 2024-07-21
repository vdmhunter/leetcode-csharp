namespace LeetCodeCSharpApp.BuildAMatrixWithConditions01;

public class Solution
{
    public int[][] BuildMatrix(int k, int[][] rowConditions, int[][] colConditions)
    {
        int[] rowOrder = TopologicalSort(rowConditions, k);
        int[] colOrder = TopologicalSort(colConditions, k);

        if (rowOrder.Length == 0 || colOrder.Length == 0)
            return [];

        var matrix = new int[k][];

        for (var i = 0; i < k; i++)
            matrix[i] = new int[k];

        for (var i = 0; i < k; i++)
        {
            int rowPos = Array.IndexOf(rowOrder, i + 1);
            int colPos = Array.IndexOf(colOrder, i + 1);

            if (rowPos >= 0 && rowPos < k && colPos >= 0 && colPos < k)
                matrix[rowPos][colPos] = i + 1;
        }

        return matrix;
    }

    private static int[] TopologicalSort(int[][] edges, int n)
    {
        var adj = new List<int>[n + 1];

        for (var i = 0; i <= n; i++)
            adj[i] = [];

        var inDegree = new int[n + 1];

        foreach (int[] edge in edges)
        {
            int u = edge[0];
            int v = edge[1];
            adj[u].Add(v);
            inDegree[v]++;
        }

        var queue = new Queue<int>();

        for (var i = 1; i <= n; i++)
            if (inDegree[i] == 0)
                queue.Enqueue(i);

        var result = new List<int>();

        while (queue.Count > 0)
        {
            int node = queue.Dequeue();
            result.Add(node);

            IEnumerable<int> zeroInDegreeNeighbors = adj[node].Where(neighbor => --inDegree[neighbor] == 0);

            foreach (int neighbor in zeroInDegreeNeighbors)
                queue.Enqueue(neighbor);
        }

        return result.Count != n ? [] : result.ToArray();
    }
}
