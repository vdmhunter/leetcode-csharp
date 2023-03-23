namespace LeetCodeCSharpApp.NumberOfOperationsToMakeNetworkConnected02;

public class Solution
{
    public int MakeConnected(int n, int[][] connections)
    {
        if (connections.Length < n - 1)
            return -1;

        var cons = new List<int>[n];

        for (var i = 0; i < n; i++)
            cons[i] = new List<int>();

        foreach (var connection in connections)
        {
            cons[connection[0]].Add(connection[1]);
            cons[connection[1]].Add(connection[0]);
        }

        var visited = new bool[n];
        var componentCount = 0;

        for (var i = 0; i < n; i++)
            if (!visited[i])
            {
                Dfs(cons, i, visited);
                componentCount++;
            }

        return componentCount - 1;
    }

    private static void Dfs(List<int>[] cons, int node, bool[] visited)
    {
        if (visited[node]) 
            return;

        visited[node] = true;

        foreach (var cNode in cons[node])
            Dfs(cons, cNode, visited);
    }
}
