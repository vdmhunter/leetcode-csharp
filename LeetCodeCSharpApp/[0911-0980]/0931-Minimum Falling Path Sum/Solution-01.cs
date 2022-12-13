namespace LeetCodeCSharpApp.MinimumFallingPathSum01;

public class Solution
{
    public int MinFallingPathSum(int[][] matrix)
    {
        for (var i = 1; i < matrix.Length; ++i)
            for (var j = 0; j < matrix.Length; ++j)
                matrix[i][j] += Math.Min(matrix[i - 1][j],
                    Math.Min(matrix[i - 1][Math.Max(0, j - 1)], matrix[i - 1][Math.Min(matrix.Length - 1, j + 1)]));

        return matrix[^1].Min();
    }
}
