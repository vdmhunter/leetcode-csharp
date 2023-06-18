namespace LeetCodeCSharpApp.NumberOfIncreasingPathsInAGrid01;

public class Solution
{
    private readonly int[,] _dp = new int[1000, 1000];
    private const int Mod = 1_000_000_007;

    public int CountPaths(int[][] g)
    {
        var m = g.Length;
        var n = g[0].Length;
        var result = 0;

        for (var i = 0; i < m; ++i)
            for (var j = 0; j < n; ++j)
                result = (result + Dfs(g, i, j, 0)) % Mod;

        return result;
    }

    private int Dfs(int[][] g, int i, int j, int v)
    {
        if (Math.Min(i, j) < 0 || i >= g.Length || j >= g[i].Length || g[i][j] <= v)
            return 0;

        return _dp[i, j] != 0
            ? _dp[i, j]
            : _dp[i, j] = (1 +
                           Dfs(g, i + 1, j, g[i][j]) +
                           Dfs(g, i - 1, j, g[i][j]) +
                           Dfs(g, i, j + 1, g[i][j]) +
                           Dfs(g, i, j - 1, g[i][j])) % Mod;
    }
}
