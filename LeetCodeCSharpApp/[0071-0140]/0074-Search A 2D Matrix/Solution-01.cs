namespace LeetCodeCSharpApp.SearchA2DMatrix01;

public class Solution
{
    public bool SearchMatrix(int[][] matrix, int target)
    {
        var m = matrix.Length;
        var n = matrix[0].Length;

        var row = 0;

        for (var i = 1; i < m; i++)
            if (matrix[i][0] <= target)
                row = i;

        for (var i = 0; i < n; i++)
            if (matrix[row][i] == target)
                return true;

        return false;
    }
}
