namespace LeetCodeCSharpApp.MaximumRowsCoveredByColumns01;

public class Solution
{
    public int MaximumRows(int[][] mat, int cols)
    {
        int m = mat.Length, n = mat[0].Length, result = 0;

        for (var mask = (1 << cols) - 1; mask < 1 << n; mask = NextPopCount(mask))
        {
            var rows = 0;

            for (var i = 0; i < m; ++i)
                rows += Check(i, mask) == n ? 1 : 0;

            result = Math.Max(result, rows);
        }

        int Check(int i, int mask)
        {
            int j;

            for (j = 0; j < n; ++j)
                if (mat[i][j] == 1 && (mask & (1 << j)) == 0)
                    break;

            return j;
        }

        return result;
    }

    private static int NextPopCount(int n)
    {
        int c = n & -n, r = n + c;
        return (((r ^ n) >> 2) / c) | r;
    }
}
