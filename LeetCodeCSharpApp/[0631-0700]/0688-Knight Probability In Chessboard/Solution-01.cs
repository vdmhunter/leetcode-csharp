namespace LeetCodeCSharpApp.KnightProbabilityInChessboard01;

public class Solution
{
    private double[][][] _dp = null!;

    private readonly int[][] _dirs =
    {
        new[] { -2, -1 }, new[] { -1, -2 }, new[] { 1, -2 }, new[] { 2, -1 },
        new[] { 2, 1 }, new[] { 1, 2 }, new[] { -1, 2 }, new[] { -2, 1 }
    };

    public double KnightProbability(int n, int k, int r, int c)
    {
        _dp = new double[n][][];

        for (var i = 0; i < n; ++i)
        {
            _dp[i] = new double[n][];

            for (var j = 0; j < n; ++j)
                _dp[i][j] = new double[k + 1];
        }

        return Find(n, k, r, c);
    }

    private double Find(int n, int k, int r, int c)
    {
        if (r < 0 || r > n - 1 || c < 0 || c > n - 1)
            return 0.0;

        if (k == 0)
            return 1.0;

        if (_dp[r][c][k] != 0.0)
            return _dp[r][c][k];

        var rate = _dirs.Sum(t => 0.125 * Find(n, k - 1, r + t[0], c + t[1]));

        _dp[r][c][k] = rate;

        return rate;
    }
}
