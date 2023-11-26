namespace LeetCodeCSharpApp.LargestSubmatrixWithRearrangements01;

public class Solution
{
    public int LargestSubmatrix(int[][] matrix)
    {
        for (var i = 1; i < matrix.Length; i++)
            for (var j = 0; j < matrix[0].Length; j++)
                if (matrix[i][j] == 1)
                    matrix[i][j] = matrix[i - 1][j] + 1;

        return matrix.Max(row =>
        {
            Array.Sort(row);

            return Enumerable.Range(1, row.Length).Max(j => j * row[^j]);
        });
    }
}
