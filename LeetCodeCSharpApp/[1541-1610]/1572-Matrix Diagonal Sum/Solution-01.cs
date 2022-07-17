namespace LeetCodeCSharpApp.MatrixDiagonalSum01;

public class Solution
{
    public int DiagonalSum(int[][] mat)
    {
        var sum = 0;
        
        for (var i = 0; i < mat.Length; i++)
        {
            sum += mat[i][i];
            
            if (i != mat.Length - 1 - i)
                sum += mat[i][mat.Length - 1 - i];
        }

        return sum;
    }
}
