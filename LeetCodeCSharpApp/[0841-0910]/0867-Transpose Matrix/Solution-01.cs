namespace LeetCodeCSharpApp.TransposeMatrix01;

public class Solution
{
    public int[][] Transpose(int[][] matrix)
    {
        var m = matrix.Length;
        var n = matrix[0].Length;
        var result = new int[n][];

        for (var j = 0; j < n; j++)
        {
            result[j] = new int[m];

            for (var i = 0; i < m; i++)
                result[j][i] = matrix[i][j];
        }

        return result;
    }
}
