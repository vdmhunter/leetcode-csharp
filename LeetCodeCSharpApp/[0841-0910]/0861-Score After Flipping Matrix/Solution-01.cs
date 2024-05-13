namespace LeetCodeCSharpApp.ScoreAfterFlippingMatrix01;

public class Solution
{
    public int MatrixScore(int[][] grid)
    {
        int n = grid.Length;
        int m = grid[0].Length;
        int result = (1 << (m - 1)) * n;

        for (var j = 1; j < m; j++)
        {
            int val = 1 << (m - 1 - j);
            var set = 0;

            for (var i = 0; i < n; ++i)
                if (grid[i][j] == grid[i][0])
                    set++;

            result += Math.Max(set, n - set) * val;
        }

        return result;
    }
}
