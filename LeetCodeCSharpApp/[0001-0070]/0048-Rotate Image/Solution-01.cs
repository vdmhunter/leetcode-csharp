namespace LeetCodeCSharpApp.RotateImage01;

public class Solution
{
    public void Rotate(int[][] matrix)
    {
        Array.Reverse(matrix);

        for (var i = 0; i < matrix.Length; i++)
            for (var j = 0; j < i; j++)
                (matrix[i][j], matrix[j][i]) = (matrix[j][i], matrix[i][j]);
    }
}
