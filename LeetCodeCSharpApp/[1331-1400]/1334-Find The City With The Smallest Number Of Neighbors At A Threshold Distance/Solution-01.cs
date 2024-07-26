namespace LeetCodeCSharpApp.FindTheCityWithTheSmallestNumberOfNeighborsAtAThresholdDistance01;

public class Solution
{
    public int FindTheCity(int n, int[][] edges, int distanceThreshold)
    {
        var graph = new Graph(edges, n);
        graph.FloydWarshall();
        var result = 0;
        var minReachable = int.MaxValue;

        for (var i = 0; i < n; i++)
        {
            var reachable = 0;

            for (var j = 0; j < n; j++)
                if (graph.Dp[i][j] <= distanceThreshold)
                    reachable++;

            if (reachable > minReachable)
                continue;

            result = i;
            minReachable = reachable;
        }

        return result;
    }

    private class Graph
    {
        private readonly int _n;
        public readonly int[][] Dp;

        public Graph(int[][] edges, int n)
        {
            _n = n;
            Dp = new int[_n][];

            for (var i = 0; i < _n; i++)
                Dp[i] = new int[_n];

            for (var i = 0; i < _n; i++)
            {
                for (var j = 0; j < _n; j++)
                {
                    if (i == j)
                        continue;

                    Dp[i][j] = 100_000;
                }
            }

            foreach (int[] e in edges)
            {
                int cityA = e[0];
                int cityB = e[1];
                int weight = e[2];

                Dp[cityA][cityB] = weight;
                Dp[cityB][cityA] = weight;
            }
        }

        public void FloydWarshall()
        {
            for (var k = 0; k < _n; k++)
                for (var i = 0; i < _n; i++)
                    for (var j = 0; j < _n; j++)
                        Dp[i][j] = Math.Min(Dp[i][j], Dp[i][k] + Dp[k][j]);
        }
    }
}
