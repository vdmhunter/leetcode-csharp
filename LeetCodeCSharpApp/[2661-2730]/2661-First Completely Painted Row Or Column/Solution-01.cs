namespace LeetCodeCSharpApp.FirstCompletelyPaintedRowOrColumn01;

public class Solution
{
    public int FirstCompleteIndex(int[] arr, int[][] mat)
    {
        var m = mat.Length;
        var n = mat[0].Length;
        var row = new int[m];
        var col = new int[n];
        var dict = new Dictionary<int, (int, int)>();

        for (var i = 0; i < m; i++)
            for (var j = 0; j < n; j++)
                dict[mat[i][j]] = (i, j);

        for (var i = 0; i < arr.Length; i++)
        {
            var (x, y) = dict[arr[i]];

            if (++row[x] == n || ++col[y] == m)
                return i;
        }

        return -1;
    }
}
