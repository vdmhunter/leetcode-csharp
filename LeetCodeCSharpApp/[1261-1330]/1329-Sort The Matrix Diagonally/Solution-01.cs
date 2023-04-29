namespace LeetCodeCSharpApp.SortTheMatrixDiagonally01;

public class Solution
{
    public int[][] DiagonalSort(int[][] mat)
    {
        var n = mat.Length;
        var m = mat[0].Length;
        var hm = new Dictionary<int, List<int>>();

        FillHashMap(mat, n, m, hm);

        foreach (var item in hm)
            item.Value.Sort();

        for (var i = n - 1; i >= 0; i--)
            for (var j = m - 1; j >= 0; j--)
            {
                var current = hm[i - j];
                mat[i][j] = current[^1];
                current.RemoveAt(current.Count - 1);
            }

        return mat;
    }

    private static void FillHashMap(int[][] mat, int n, int m, Dictionary<int, List<int>> hm)
    {
        for (var i = 0; i < n; i++)
            for (var j = 0; j < m; j++)
                if (!hm.ContainsKey(i - j))
                    hm.Add(i - j, new List<int> { mat[i][j] });
                else
                    hm[i - j].Add(mat[i][j]);
    }
}
