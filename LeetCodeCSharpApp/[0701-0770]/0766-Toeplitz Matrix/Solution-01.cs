namespace LeetCodeCSharpApp.ToeplitzMatrix01;

public class Solution
{
    public bool IsToeplitzMatrix(int[][] matrix)
    {
        for (var i = 0; i < matrix.Length - 1; i++)
            if (!matrix[i][..^1].SequenceEqual(matrix[i + 1][1..]))
                return false;

        return true;
    }
}
