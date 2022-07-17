namespace LeetCodeCSharpApp.ReshapeTheMatrix01;

public class Solution
{
    public int[][] MatrixReshape(int[][] mat, int r, int c)
    {
        int n = mat.Length, m = mat[0].Length;

        if (r * c != n * m)
            return mat;

        var res = new int[r][];

        for (var i = 0; i < r; i++)
            res[i] = new int[c];

        for (var i = 0; i < r * c; i++)
            res[i / c][i % c] = mat[i / m][i % m];

        return res;
    }
}
