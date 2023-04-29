namespace LeetCodeCSharpApp.NumberOfOperationsToMakeNetworkConnected01;

public class Solution
{
    public int MakeConnected(int n, int[][] connections)
    {
        var parent = new int[n];
        var ranks = new int[n];

        for (var i = 0; i < n; i++)
        {
            parent[i] = i;
            ranks[i] = 1;
        }

        var spareConnections = 0;

        foreach (var connection in connections)
        {
            var v1 = connection[0];
            var v2 = connection[1];
            var r1 = GetRoot(parent, v1);
            var r2 = GetRoot(parent, v2);

            if (r1 == r2)
                spareConnections++;
            else
            {
                if (ranks[r1] < ranks[r2]) (r1, r2) = (r2, r1);

                parent[r2] = r1;
                ranks[r1] += ranks[r2];
            }
        }

        var components = new HashSet<int>();

        for (var i = 0; i < n; i++)
            components.Add(GetRoot(parent, i));

        return components.Count - 1 > spareConnections ? -1 : components.Count - 1;
    }

    private static int GetRoot(int[] parent, int v)
    {
        while (v != parent[v])
        {
            parent[v] = parent[parent[v]];
            v = parent[v];
        }

        return v;
    }
}
