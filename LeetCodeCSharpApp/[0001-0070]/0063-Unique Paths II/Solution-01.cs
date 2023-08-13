namespace LeetCodeCSharpApp.UniquePathsII01;

public class Solution
{
    public int UniquePathsWithObstacles(int[][] g)
    {
        for (var i = 0; i < g.Length; i++)
            for (var j = 0; j < g[0].Length; j++)
                g[i][j] = (g[i][j], i, j) switch
                {
                    (1, _, _) => 0,
                    (_, 0, 0) => 1,
                    (_, 0, _) => g[i][j - 1] * 1,
                    (_, _, 0) => g[i - 1][j] * 1,
                    _ => g[i - 1][j] + g[i][j - 1]
                };

        return g[^1][^1];
    }
}
