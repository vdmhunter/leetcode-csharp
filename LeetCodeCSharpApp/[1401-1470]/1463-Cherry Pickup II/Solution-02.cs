namespace LeetCodeCSharpApp.CherryPickupII02;

public class Solution
{
    public int CherryPickup(int[][] grid)
    {
        var n = grid.Length;
        var m = grid[0].Length;
        var res = new int[n, m, m];
        res[0, 0, m - 1] = grid[0][0] + grid[0][m - 1];

        for (var i = 1; i < n; i++)
        {
            for (var a = 0; a < Math.Min(i + 1, m); a++)
            {
                for (var b = m - 1; b >= Math.Max(m - 1 - i, 0); b--)
                {
                    var cur = a == b ? grid[i][a] : grid[i][a] + grid[i][b];
                    var k = res[i - 1, a, b];
                    k = Math.Max(k, Get(i - 1, a - 1, b - 1));
                    k = Math.Max(k, Get(i - 1, a - 1, b));
                    k = Math.Max(k, Get(i - 1, a - 1, b + 1));
                    k = Math.Max(k, Get(i - 1, a, b - 1));
                    k = Math.Max(k, Get(i - 1, a, b));
                    k = Math.Max(k, Get(i - 1, a, b + 1));
                    k = Math.Max(k, Get(i - 1, a + 1, b - 1));
                    k = Math.Max(k, Get(i - 1, a + 1, b));
                    k = Math.Max(k, Get(i - 1, a + 1, b + 1));
                    res[i, a, b] = cur + k;
                }
            }
        }

        var result = 0;

        for (var a = 0; a < Math.Min(n, m); a++)
            for (var b = m - 1; b >= Math.Max(m - n, 0); b--)
                result = Math.Max(result, res[n - 1, a, b]);

        return result;

        #region Get

        int Get(int i1, int i2, int i3)
        {
            return i2 < 0 || i2 >= m || i3 < 0 || i3 >= m ? 0 : res[i1, i2, i3];
        }

        #endregion
    }
}
